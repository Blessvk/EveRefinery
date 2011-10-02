﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpecialFNs;
using System.Xml;

namespace EveRefinery
{
	public partial class FrmSettings : Form
	{
		protected Engine		m_Engine;
		protected EveDatabase	m_EveDatabase;
		protected Pages			m_StartPage;
		protected ListView.ColumnHeaderCollection m_ListColumns;
		
		public enum Pages
		{
			Minerals,
			ApiKeys,
		}

		public FrmSettings(Pages a_StartPage, Engine a_Engine, EveDatabase a_EveDatabase, ListView.ColumnHeaderCollection a_ListColumns)
		{
			m_Engine		= a_Engine;
			m_EveDatabase	= a_EveDatabase;
			m_StartPage		= a_StartPage;
			m_ListColumns	= a_ListColumns;
			
			InitializeComponent();
		}

		private void FrmSettings_Load(object sender, EventArgs e)
		{
			InitPage_ApiKeys();
			InitPage_Minerals();
			InitPage_Appearance();
			InitPage_Other();
			InitPage_Developer();
			
			CmbMineralPriceType.DrawItem += Engine.DrawPriceTypeItem;
			TabMain.SelectedIndex = (Int32)m_StartPage;
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			if (!SavePage_ApiKeys())
				return;
			
			if (!SavePage_Minerals())
				return;

			if (!SavePage_Appearance())
				return;

			if (!SavePage_Other())
				return;
				
			m_Engine.UpdateSettingsCache();

			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}

		private void InitPage_ApiKeys()
		{
			for (int i = 0; i < m_Engine.m_Settings.Accounts.Count; i++)
			{
				Settings.AccountsRow currAccount = m_Engine.m_Settings.Accounts[i];
				ListViewItem newItem = LstUsers.Items.Add(currAccount.UserID.ToString());
				newItem.SubItems.Add(currAccount.FullKey);
			}

			for (int i = 0; i < m_Engine.m_Settings.Characters.Count; i++)
			{
				Settings.CharactersRow currCharacter = m_Engine.m_Settings.Characters[i];
				ListViewItem newItem = LstCharacters.Items.Add(currCharacter.UserID.ToString());
				newItem.SubItems.Add(currCharacter.CharacterID.ToString());
				newItem.SubItems.Add(currCharacter.CharacterName);
				newItem.SubItems.Add(currCharacter.CorporationName);
			}
		}

		private bool SavePage_ApiKeys()
		{
			if (HasOrphanedUsers())
			{
				if (DialogResult.Yes != MessageBox.Show("You entered some users, but did not [Load characters]. If you continue now, the corresponding characters will not be available.\nContinue anyway?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
					return false;
			}

			m_Engine.m_Settings.Accounts.Clear();
			for (int i = 0; i < LstUsers.Items.Count; i++)
			{
				ListViewItem currItem = LstUsers.Items[i];
				string userID	= currItem.Text;
				string apiKey	= currItem.SubItems[1].Text;

				Settings.AccountsRow newRow = m_Engine.m_Settings.Accounts.NewAccountsRow();
				newRow.UserID	= Convert.ToUInt32(userID);
				newRow.FullKey	= apiKey;
				m_Engine.m_Settings.Accounts.AddAccountsRow(newRow);
			}

			m_Engine.m_Settings.Characters.Clear();
			for (int i = 0; i < LstCharacters.Items.Count; i++)
			{
				ListViewItem currItem = LstCharacters.Items[i];
				string userID	= currItem.Text;
				string charID	= currItem.SubItems[1].Text;
				string charName = currItem.SubItems[2].Text;
				string charCorp = currItem.SubItems[3].Text;

				Settings.CharactersRow newRow = m_Engine.m_Settings.Characters.NewCharactersRow();
				newRow.UserID			= Convert.ToUInt32(userID);
				newRow.CharacterID		= Convert.ToUInt32(charID);
				newRow.CharacterName	= charName;
				newRow.CorporationName	= charCorp;
				m_Engine.m_Settings.Characters.AddCharactersRow(newRow);
			}

			return true;
		}

		private void InitPage_Minerals()
		{
			TxtTritanium.Value	= (decimal)m_Engine.m_MaterialPrices[(UInt32)Materials.Tritanium];
			TxtPyerite.Value	= (decimal)m_Engine.m_MaterialPrices[(UInt32)Materials.Pyerite];
			TxtMexallon.Value	= (decimal)m_Engine.m_MaterialPrices[(UInt32)Materials.Mexallon];
			TxtIsogen.Value		= (decimal)m_Engine.m_MaterialPrices[(UInt32)Materials.Isogen];
			TxtNoxcium.Value	= (decimal)m_Engine.m_MaterialPrices[(UInt32)Materials.Noxcium];
			TxtZydrine.Value	= (decimal)m_Engine.m_MaterialPrices[(UInt32)Materials.Zydrine];
			TxtMegacyte.Value	= (decimal)m_Engine.m_MaterialPrices[(UInt32)Materials.Megacyte];
			TxtMorphite.Value	= (decimal)m_Engine.m_MaterialPrices[(UInt32)Materials.Morphite];
			
			Init_CmbMineralPriceType();
			Init_CmbMineralRegion();

			Settings.OptionsRow options = m_Engine.m_Settings.Options[0];

			TxtRefineryEfficiency.Value = (decimal)options.RefineryEfficiency * 100;
			TxtRefineryTax.Value		= (decimal)options.RefineryTax * 100;
		}

		private void HandleMineralPricesChange(double[] a_OldPrices)
		{
			Boolean mineralPricesChanged = false;
			for (int i = 0; i < a_OldPrices.Length; i++)
			{
				if (a_OldPrices[i] != m_Engine.m_MaterialPrices[i])
				{
					mineralPricesChanged = true;
					break;
				}
			}

			if (mineralPricesChanged)
				m_Engine.m_Settings.Stats[0].LastMineralPricesEdit = DateTime.UtcNow;
		}

		private bool SavePage_Minerals()
		{
			double[] oldMaterialPrices = (double[])m_Engine.m_MaterialPrices.Clone();

			m_Engine.m_MaterialPrices[(UInt32)Materials.Tritanium]	= (double)TxtTritanium.Value;
			m_Engine.m_MaterialPrices[(UInt32)Materials.Pyerite]	= (double)TxtPyerite.Value;
			m_Engine.m_MaterialPrices[(UInt32)Materials.Mexallon]	= (double)TxtMexallon.Value;
			m_Engine.m_MaterialPrices[(UInt32)Materials.Isogen]		= (double)TxtIsogen.Value;
			m_Engine.m_MaterialPrices[(UInt32)Materials.Noxcium]	= (double)TxtNoxcium.Value;
			m_Engine.m_MaterialPrices[(UInt32)Materials.Zydrine]	= (double)TxtZydrine.Value;
			m_Engine.m_MaterialPrices[(UInt32)Materials.Megacyte]	= (double)TxtMegacyte.Value;
			m_Engine.m_MaterialPrices[(UInt32)Materials.Morphite]	= (double)TxtMorphite.Value;

			Settings.OptionsRow options		= m_Engine.m_Settings.Options[0];

			options.MineralPricesRegion		= TextItemWithUInt32.GetData(CmbMineralRegion.SelectedItem);
			options.MineralPricesType		= TextItemWithUInt32.GetData(CmbMineralPriceType.SelectedItem);

			options.RefineryEfficiency		= (double)(TxtRefineryEfficiency.Value / 100);
			options.RefineryTax				= (double)(TxtRefineryTax.Value / 100);

			HandleMineralPricesChange(oldMaterialPrices);
			return true;
		}
		
		private void InitPage_Appearance()
		{
			foreach (ColumnHeader column in m_ListColumns)
			{
				bool isColumnVisible = (0 != column.Width);
				ListViewItem newItem = new ListViewItem(column.Text);
				newItem.Checked = isColumnVisible;
				newItem.Tag = (Object)column.Index;
				LstColumns.Items.Add(newItem);
			}

			Settings.OptionsRow options = m_Engine.m_Settings.Options[0];

			TxtRedPrice.Value				= (int)(options.RedPrice * 100);
			TxtGreenPrice.Value				= (int)(options.GreenPrice * 100);
			
			ChkOverrideColorsISK.Checked	= options.OverrideAssetsColors;
			TxtGreenIskLoss.Value			= (decimal)options.GreenIskLoss;
			TxtRedIskLoss.Value				= (decimal)options.RedIskLoss;
			Update_OverrideColorsControls_Enabled();
		}
		
		private bool SavePage_Appearance()
		{
			for (int i = 0; i < LstColumns.Items.Count; i++)
			{
				ListViewItem currItem = LstColumns.Items[i];
				Int32 columnIndex = (Int32)currItem.Tag;
				
				if (currItem.Checked)
					ListViewEx.UnhideColumn(m_ListColumns[columnIndex]);
				else
					ListViewEx.HideColumn(m_ListColumns[columnIndex]);
			}

			Settings.OptionsRow options = m_Engine.m_Settings.Options[0];

			options.RedPrice				= ((double)TxtRedPrice.Value) / 100;
			options.GreenPrice				= ((double)TxtGreenPrice.Value) / 100;
			
			options.OverrideAssetsColors	= ChkOverrideColorsISK.Checked;
			options.GreenIskLoss			= (double)TxtGreenIskLoss.Value;
			options.RedIskLoss				= (double)TxtRedIskLoss.Value;
			
			return true;
		}
		
		private void InitPage_Other()
		{
			Settings.OptionsRow options = m_Engine.m_Settings.Options[0];

			ChkCheckUpdates.Checked			= options.CheckUpdates;
			TxtPriceHistory.Value			= options.PriceHistoryDays;
			TxtPricesExpiryDays.Value		= options.PriceExpiryDays;
			TxtMineralPricesExpiryDays.Value = options.MineralPriceExpiryDays;
		}
		
		private bool SavePage_Other()
		{
			Settings.OptionsRow options = m_Engine.m_Settings.Options[0];

			options.CheckUpdates			= ChkCheckUpdates.Checked;
			options.PriceHistoryDays		= (UInt32)TxtPriceHistory.Value;
			options.PriceExpiryDays			= (UInt32)TxtPricesExpiryDays.Value;
			options.MineralPriceExpiryDays	= (UInt32)TxtMineralPricesExpiryDays.Value;
			return true;
		}

		private void InitPage_Developer()
		{
			Boolean isPageShown = false;

			#if (DEBUG)
				isPageShown = true;
			#endif

			if (Environment.GetCommandLineArgs().Contains("/dev"))
				isPageShown = true;

			if (!isPageShown)
				TabMain.TabPages.Remove(TabDeveloper);
		}

		private void BtnAddApiKey_Click(object sender, EventArgs e)
		{
			FrmAddNewApiKey frmAddNewApiKey = new FrmAddNewApiKey();
			if (DialogResult.OK != frmAddNewApiKey.ShowDialog())
				return;

			for (int i = 0; i < LstUsers.Items.Count; i++)
			{
				ListViewItem currItem = LstUsers.Items[i];
				if (currItem.Text == frmAddNewApiKey.m_UserID)
				{
					ErrorMessageBox.Show("This UserID is already present");
					return;
				}
			}

			ListViewItem newItem = LstUsers.Items.Add(frmAddNewApiKey.m_UserID);
			newItem.SubItems.Add(frmAddNewApiKey.m_ApiKey);
		}

		private void DeleteCharactersFromUser(string a_UserID)
		{
			for (int i = 0; i < LstCharacters.Items.Count; i++)
			{
				ListViewItem currItem = LstCharacters.Items[i];

				if (currItem.Text == a_UserID)
				{
					LstCharacters.Items.RemoveAt(i);
					i--;
				}
			}
		}

		private void BtnDeleteApiKey_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem selectedItem in LstUsers.SelectedItems)
			{
				DeleteCharactersFromUser(selectedItem.Text);
				LstUsers.Items.Remove(selectedItem);
			}
		}

		private void UpdateSingleUser(string a_UserID, string a_ApiKey)
		{
			string xmlQueryUrl = "http://api.eve-online.com//account/Characters.xml.aspx?userID=" + a_UserID + "&apiKey=" + a_ApiKey;
			XmlDocument xmlReply = new XmlDocument();

			string errorHeader = "Failed to update user " + a_UserID + ":\n";

			try
			{
				xmlReply = Engine.LoadXmlWithUserAgent(xmlQueryUrl);
			}
			catch (System.Exception a_Exception)
			{
				ErrorMessageBox.Show(errorHeader + a_Exception.Message);
				return;
			}

			XmlNodeList errorNodes = xmlReply.GetElementsByTagName("error");
			if (0 != errorNodes.Count)
			{
				Engine.ShowXmlRequestErrors(errorHeader, errorNodes);
				return;
			}

			XmlNodeList characterNodes = xmlReply.GetElementsByTagName("row");
			if (0 == characterNodes.Count)
			{
				ErrorMessageBox.Show(errorHeader + "No characters found");
				return;
			}

			DeleteCharactersFromUser(a_UserID);

			foreach (XmlNode characterNode in characterNodes)
			{
				ListViewItem newItem = LstCharacters.Items.Add(a_UserID);
				newItem.SubItems.Add(characterNode.Attributes["characterID"].Value);
				newItem.SubItems.Add(characterNode.Attributes["name"].Value);
				newItem.SubItems.Add(characterNode.Attributes["corporationName"].Value);
			}
		}

		private void BtnUpdateChars_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < LstUsers.Items.Count; i++)
			{
				ListViewItem currItem = LstUsers.Items[i];
				string userID = currItem.Text;
				string apiKey = currItem.SubItems[1].Text;

				UpdateSingleUser(userID, apiKey);
			}
		}

		private Boolean HasOrphanedUsers()
		{
			foreach (ListViewItem currUser in LstUsers.Items)
			{
				string userUserID = currUser.Text;
				bool isFound = false;

				foreach (ListViewItem currChar in LstCharacters.Items)
				{
					string charUserID = currChar.Text;

					if (charUserID == userUserID)
					{
						isFound = true;
						break;
					}
				}

				if (!isFound)
					return true;
			}

			return false;
		}
		
		private void OnGreenPriceChange(Int32 a_NewValue)
		{
			if (TrkGreenPrice.Value != a_NewValue)
				TrkGreenPrice.Value = a_NewValue;

			if (TxtGreenPrice.Value != a_NewValue)
				TxtGreenPrice.Value = a_NewValue;

			if (TxtRedPrice.Value > a_NewValue)
				TxtRedPrice.Value = a_NewValue;
		}

		private void OnRedPriceChange(Int32 a_NewValue)
		{
			if (TrkRedPrice.Value != a_NewValue)
				TrkRedPrice.Value = a_NewValue;

			if (TxtRedPrice.Value != a_NewValue)
				TxtRedPrice.Value = a_NewValue;

			if (TxtGreenPrice.Value < a_NewValue)
				TxtGreenPrice.Value = a_NewValue;
		}

		private void TxtRedPrice_ValueChanged(object sender, EventArgs e)
		{
			OnRedPriceChange((Int32)TxtRedPrice.Value);
		}

		private void TrkRedPrice_ValueChanged(object sender, EventArgs e)
		{
			OnRedPriceChange(TrkRedPrice.Value);
		}

		private void TxtGreenPrice_ValueChanged(object sender, EventArgs e)
		{
			OnGreenPriceChange((Int32)TxtGreenPrice.Value);
		}

		private void TrkGreenPrice_ValueChanged(object sender, EventArgs e)
		{
			OnGreenPriceChange(TrkGreenPrice.Value);
		}

		private void Init_CmbMineralPriceType()
		{
			ComboBox currCombo = CmbMineralPriceType;
			currCombo.Items.Clear();

			for (UInt32 i = 0; i < (UInt32)PriceTypes.MaxPriceTypes; i++)
			{
				string enumName = Engine.GetPriceTypeName((PriceTypes)i);
				TextItemWithUInt32 newItem = new TextItemWithUInt32(enumName, i);
				currCombo.Items.Add(newItem);
				
				if (i == m_Engine.m_Settings.Options[0].MineralPricesType)
					currCombo.SelectedItem = newItem;
			}
		}

		private void Init_CmbMineralRegion()
		{
			ComboBox currCombo = CmbMineralRegion;
			currCombo.Items.Clear();

			List<EveRegion> regions = m_EveDatabase.GetRegions();
			foreach (EveRegion currRegion in regions)
			{
				TextItemWithUInt32 newItem = new TextItemWithUInt32(currRegion.Name, currRegion.ID);
				currCombo.Items.Add(newItem);

				if (currRegion.ID == m_Engine.m_Settings.Options[0].MineralPricesRegion)
					currCombo.SelectedItem = newItem;
			}
		}

		private void BtnLoadMineralPrices_Click(object sender, EventArgs e)
		{
			UInt32 regionID		= TextItemWithUInt32.GetData(CmbMineralRegion.SelectedItem);
			UInt32 priceType	= TextItemWithUInt32.GetData(CmbMineralPriceType.SelectedItem);
		
			List<UInt32> loadPricesFor = new List<UInt32>();
			loadPricesFor.Add((UInt32)EveTypeIDs.Tritanium);
			loadPricesFor.Add((UInt32)EveTypeIDs.Pyerite);
			loadPricesFor.Add((UInt32)EveTypeIDs.Mexallon);
			loadPricesFor.Add((UInt32)EveTypeIDs.Isogen);
			loadPricesFor.Add((UInt32)EveTypeIDs.Noxcium);
			loadPricesFor.Add((UInt32)EveTypeIDs.Zydrine);
			loadPricesFor.Add((UInt32)EveTypeIDs.Megacyte);
			loadPricesFor.Add((UInt32)EveTypeIDs.Morphite);

			IPriceProvider provider = MarketPricesDB.CreateEveCentralProvider(m_Engine.m_Settings.Options[0].PriceHistoryDays);

			PriceSettings settings	= new PriceSettings();
			settings.Provider		= PriceProviders.EveCentral;
			settings.RegionID		= regionID;
			settings.SolarID		= 0;
			settings.StationID		= 0;
			settings.PriceType		= (PriceTypes)priceType;

			// @@@@ Check for exceptions?
			List<PriceRecord> prices = provider.GetPrices(loadPricesFor, settings);
			foreach (PriceRecord currRecord in prices)
			{
				if (!currRecord.Settings.Matches(settings))
					continue;

				switch ((EveTypeIDs)currRecord.TypeID)
				{
				case EveTypeIDs.Tritanium:
					TxtTritanium.Value	= (decimal)currRecord.Price;
					break;
				case EveTypeIDs.Pyerite:
					TxtPyerite.Value	= (decimal)currRecord.Price;
					break;
				case EveTypeIDs.Mexallon:
					TxtMexallon.Value	= (decimal)currRecord.Price;
					break;
				case EveTypeIDs.Isogen:
					TxtIsogen.Value		= (decimal)currRecord.Price;
					break;
				case EveTypeIDs.Noxcium:
					TxtNoxcium.Value	= (decimal)currRecord.Price;
					break;
				case EveTypeIDs.Zydrine:
					TxtZydrine.Value	= (decimal)currRecord.Price;
					break;
				case EveTypeIDs.Megacyte:
					TxtMegacyte.Value	= (decimal)currRecord.Price;
					break;
				case EveTypeIDs.Morphite:
					TxtMorphite.Value	= (decimal)currRecord.Price;
					break;
				}
			}
		}

		private void BtnRefineryCalculator_Click(object sender, EventArgs e)
		{
			FrmRefineCalc frmRefineCalc = new FrmRefineCalc();
			if (DialogResult.OK != frmRefineCalc.ShowDialog(this))
				return;
				
			TxtRefineryEfficiency.Value = (decimal)frmRefineCalc.m_RefineryEfficiency * 100;
			TxtRefineryTax.Value		= (decimal)frmRefineCalc.m_TaxesTaken * 100;
		}

		private void LnkGetApiKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
		}
		
		private void Update_OverrideColorsControls_Enabled()
		{
			TxtGreenIskLoss.Enabled = ChkOverrideColorsISK.Checked;
			TxtRedIskLoss.Enabled	= ChkOverrideColorsISK.Checked;
		}

		private void ChkOverrideColorsISK_CheckedChanged(object sender, EventArgs e)
		{
			Update_OverrideColorsControls_Enabled();
		}

		private void BtnStripDatabase_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Title = "Browse for EVE database";
			fileDialog.Filter = "All files (*.*)|*.*|Databases (*.db)|*.db";
			fileDialog.FilterIndex = 2;
			fileDialog.RestoreDirectory = true;
			if (DialogResult.OK != fileDialog.ShowDialog())
				return;

			try
			{
				EveDatabase.StripDatabase(fileDialog.FileName);
			}
			catch (System.Exception a_Exception)
			{
				ErrorMessageBox.Show("Failed to strip database:\n" + a_Exception.Message);
			}
		}
	}
}
