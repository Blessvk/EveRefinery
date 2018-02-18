﻿namespace EveRefinery
{
	partial class FrmPriceType
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPriceType));
			this.TblMain = new System.Windows.Forms.TableLayoutPanel();
			this.SplOkCancel = new System.Windows.Forms.TableLayoutPanel();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.BtnOk = new System.Windows.Forms.Button();
			this.TabProviders = new System.Windows.Forms.TabControl();
			this.TabEveCentralCom = new System.Windows.Forms.TabPage();
			this.TblEveCentralCom = new System.Windows.Forms.TableLayoutPanel();
			this.Lbl_EveCentralCom_Region = new System.Windows.Forms.Label();
			this.Lbl_EveCentralCom_Solar = new System.Windows.Forms.Label();
			this.Lbl_EveCentralCom_PriceType = new System.Windows.Forms.Label();
			this.Cmb_EveCentralCom_Region = new System.Windows.Forms.ComboBox();
			this.Cmb_EveCentralCom_Solar = new System.Windows.Forms.ComboBox();
			this.Cmb_EveCentralCom_PriceType = new System.Windows.Forms.ComboBox();
			this.Lbl_EveCentralCom_PriceHistory_Hint = new System.Windows.Forms.Label();
			this.Tbl_EveCentralCom_PriceHistory = new System.Windows.Forms.TableLayoutPanel();
			this.Lbl_EveCentralCom_PriceHistory1 = new System.Windows.Forms.Label();
			this.Txt_EveCentralCom_PriceHistory = new System.Windows.Forms.NumericUpDown();
			this.Lbl_EveCentralCom_PriceHistory2 = new System.Windows.Forms.Label();
			this.TblMain.SuspendLayout();
			this.SplOkCancel.SuspendLayout();
			this.TabProviders.SuspendLayout();
			this.TabEveCentralCom.SuspendLayout();
			this.TblEveCentralCom.SuspendLayout();
			this.Tbl_EveCentralCom_PriceHistory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Txt_EveCentralCom_PriceHistory)).BeginInit();
			this.SuspendLayout();
			// 
			// TblMain
			// 
			this.TblMain.ColumnCount = 1;
			this.TblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TblMain.Controls.Add(this.SplOkCancel, 0, 1);
			this.TblMain.Controls.Add(this.TabProviders, 0, 0);
			this.TblMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TblMain.Location = new System.Drawing.Point(0, 0);
			this.TblMain.Name = "TblMain";
			this.TblMain.RowCount = 2;
			this.TblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.TblMain.Size = new System.Drawing.Size(333, 299);
			this.TblMain.TabIndex = 0;
			// 
			// SplOkCancel
			// 
			this.SplOkCancel.ColumnCount = 4;
			this.SplOkCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.SplOkCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.SplOkCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
			this.SplOkCancel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.SplOkCancel.Controls.Add(this.BtnCancel, 3, 0);
			this.SplOkCancel.Controls.Add(this.BtnOk, 1, 0);
			this.SplOkCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplOkCancel.Location = new System.Drawing.Point(2, 276);
			this.SplOkCancel.Margin = new System.Windows.Forms.Padding(2);
			this.SplOkCancel.Name = "SplOkCancel";
			this.SplOkCancel.RowCount = 1;
			this.SplOkCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.SplOkCancel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
			this.SplOkCancel.Size = new System.Drawing.Size(329, 21);
			this.SplOkCancel.TabIndex = 8;
			// 
			// BtnCancel
			// 
			this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnCancel.Location = new System.Drawing.Point(249, 0);
			this.BtnCancel.Margin = new System.Windows.Forms.Padding(0);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(80, 21);
			this.BtnCancel.TabIndex = 0;
			this.BtnCancel.Text = "Cancel";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// BtnOk
			// 
			this.BtnOk.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnOk.Location = new System.Drawing.Point(164, 0);
			this.BtnOk.Margin = new System.Windows.Forms.Padding(0);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(80, 21);
			this.BtnOk.TabIndex = 1;
			this.BtnOk.Text = "OK";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// TabProviders
			// 
			this.TabProviders.Controls.Add(this.TabEveCentralCom);
			this.TabProviders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabProviders.Location = new System.Drawing.Point(3, 3);
			this.TabProviders.Name = "TabProviders";
			this.TabProviders.SelectedIndex = 0;
			this.TabProviders.Size = new System.Drawing.Size(327, 268);
			this.TabProviders.TabIndex = 1;
			// 
			// TabEveCentralCom
			// 
			this.TabEveCentralCom.Controls.Add(this.TblEveCentralCom);
			this.TabEveCentralCom.Location = new System.Drawing.Point(4, 22);
			this.TabEveCentralCom.Name = "TabEveCentralCom";
			this.TabEveCentralCom.Padding = new System.Windows.Forms.Padding(3);
			this.TabEveCentralCom.Size = new System.Drawing.Size(319, 242);
			this.TabEveCentralCom.TabIndex = 0;
			this.TabEveCentralCom.Text = "eve-central.com";
			this.TabEveCentralCom.UseVisualStyleBackColor = true;
			// 
			// TblEveCentralCom
			// 
			this.TblEveCentralCom.ColumnCount = 1;
			this.TblEveCentralCom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TblEveCentralCom.Controls.Add(this.Lbl_EveCentralCom_Region, 0, 0);
			this.TblEveCentralCom.Controls.Add(this.Lbl_EveCentralCom_Solar, 0, 2);
			this.TblEveCentralCom.Controls.Add(this.Lbl_EveCentralCom_PriceType, 0, 4);
			this.TblEveCentralCom.Controls.Add(this.Cmb_EveCentralCom_Region, 0, 1);
			this.TblEveCentralCom.Controls.Add(this.Cmb_EveCentralCom_Solar, 0, 3);
			this.TblEveCentralCom.Controls.Add(this.Cmb_EveCentralCom_PriceType, 0, 5);
			this.TblEveCentralCom.Controls.Add(this.Lbl_EveCentralCom_PriceHistory_Hint, 0, 6);
			this.TblEveCentralCom.Controls.Add(this.Tbl_EveCentralCom_PriceHistory, 0, 7);
			this.TblEveCentralCom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TblEveCentralCom.Location = new System.Drawing.Point(3, 3);
			this.TblEveCentralCom.Name = "TblEveCentralCom";
			this.TblEveCentralCom.Padding = new System.Windows.Forms.Padding(5);
			this.TblEveCentralCom.RowCount = 9;
			this.TblEveCentralCom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.TblEveCentralCom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.TblEveCentralCom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.TblEveCentralCom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.TblEveCentralCom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
			this.TblEveCentralCom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.TblEveCentralCom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.TblEveCentralCom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.TblEveCentralCom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TblEveCentralCom.Size = new System.Drawing.Size(313, 236);
			this.TblEveCentralCom.TabIndex = 1;
			// 
			// Lbl_EveCentralCom_Region
			// 
			this.Lbl_EveCentralCom_Region.AutoSize = true;
			this.Lbl_EveCentralCom_Region.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Lbl_EveCentralCom_Region.Location = new System.Drawing.Point(8, 5);
			this.Lbl_EveCentralCom_Region.Name = "Lbl_EveCentralCom_Region";
			this.Lbl_EveCentralCom_Region.Size = new System.Drawing.Size(297, 15);
			this.Lbl_EveCentralCom_Region.TabIndex = 0;
			this.Lbl_EveCentralCom_Region.Text = "Region :";
			this.Lbl_EveCentralCom_Region.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Lbl_EveCentralCom_Solar
			// 
			this.Lbl_EveCentralCom_Solar.AutoSize = true;
			this.Lbl_EveCentralCom_Solar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Lbl_EveCentralCom_Solar.Location = new System.Drawing.Point(8, 45);
			this.Lbl_EveCentralCom_Solar.Name = "Lbl_EveCentralCom_Solar";
			this.Lbl_EveCentralCom_Solar.Size = new System.Drawing.Size(297, 15);
			this.Lbl_EveCentralCom_Solar.TabIndex = 1;
			this.Lbl_EveCentralCom_Solar.Text = "Solar system :";
			this.Lbl_EveCentralCom_Solar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Lbl_EveCentralCom_PriceType
			// 
			this.Lbl_EveCentralCom_PriceType.AutoSize = true;
			this.Lbl_EveCentralCom_PriceType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Lbl_EveCentralCom_PriceType.Location = new System.Drawing.Point(8, 85);
			this.Lbl_EveCentralCom_PriceType.Name = "Lbl_EveCentralCom_PriceType";
			this.Lbl_EveCentralCom_PriceType.Size = new System.Drawing.Size(297, 15);
			this.Lbl_EveCentralCom_PriceType.TabIndex = 2;
			this.Lbl_EveCentralCom_PriceType.Text = "Price type :";
			this.Lbl_EveCentralCom_PriceType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// Cmb_EveCentralCom_Region
			// 
			this.Cmb_EveCentralCom_Region.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Cmb_EveCentralCom_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Cmb_EveCentralCom_Region.FormattingEnabled = true;
			this.Cmb_EveCentralCom_Region.Location = new System.Drawing.Point(8, 23);
			this.Cmb_EveCentralCom_Region.Name = "Cmb_EveCentralCom_Region";
			this.Cmb_EveCentralCom_Region.Size = new System.Drawing.Size(297, 21);
			this.Cmb_EveCentralCom_Region.Sorted = true;
			this.Cmb_EveCentralCom_Region.TabIndex = 3;
			this.Cmb_EveCentralCom_Region.SelectedIndexChanged += new System.EventHandler(this.CmbRegion_SelectedIndexChanged);
			// 
			// Cmb_EveCentralCom_Solar
			// 
			this.Cmb_EveCentralCom_Solar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Cmb_EveCentralCom_Solar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Cmb_EveCentralCom_Solar.FormattingEnabled = true;
			this.Cmb_EveCentralCom_Solar.Location = new System.Drawing.Point(8, 63);
			this.Cmb_EveCentralCom_Solar.Name = "Cmb_EveCentralCom_Solar";
			this.Cmb_EveCentralCom_Solar.Size = new System.Drawing.Size(297, 21);
			this.Cmb_EveCentralCom_Solar.Sorted = true;
			this.Cmb_EveCentralCom_Solar.TabIndex = 4;
			// 
			// Cmb_EveCentralCom_PriceType
			// 
			this.Cmb_EveCentralCom_PriceType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Cmb_EveCentralCom_PriceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Cmb_EveCentralCom_PriceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Cmb_EveCentralCom_PriceType.DropDownWidth = 300;
			this.Cmb_EveCentralCom_PriceType.FormattingEnabled = true;
			this.Cmb_EveCentralCom_PriceType.Location = new System.Drawing.Point(8, 103);
			this.Cmb_EveCentralCom_PriceType.Name = "Cmb_EveCentralCom_PriceType";
			this.Cmb_EveCentralCom_PriceType.Size = new System.Drawing.Size(297, 21);
			this.Cmb_EveCentralCom_PriceType.TabIndex = 5;
			// 
			// Lbl_EveCentralCom_PriceHistory_Hint
			// 
			this.Lbl_EveCentralCom_PriceHistory_Hint.AutoSize = true;
			this.Lbl_EveCentralCom_PriceHistory_Hint.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Lbl_EveCentralCom_PriceHistory_Hint.Location = new System.Drawing.Point(8, 125);
			this.Lbl_EveCentralCom_PriceHistory_Hint.Name = "Lbl_EveCentralCom_PriceHistory_Hint";
			this.Lbl_EveCentralCom_PriceHistory_Hint.Size = new System.Drawing.Size(297, 75);
			this.Lbl_EveCentralCom_PriceHistory_Hint.TabIndex = 7;
			this.Lbl_EveCentralCom_PriceHistory_Hint.Text = resources.GetString("Lbl_EveCentralCom_PriceHistory_Hint.Text");
			// 
			// Tbl_EveCentralCom_PriceHistory
			// 
			this.Tbl_EveCentralCom_PriceHistory.ColumnCount = 3;
			this.Tbl_EveCentralCom_PriceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.Tbl_EveCentralCom_PriceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.Tbl_EveCentralCom_PriceHistory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
			this.Tbl_EveCentralCom_PriceHistory.Controls.Add(this.Lbl_EveCentralCom_PriceHistory1, 0, 0);
			this.Tbl_EveCentralCom_PriceHistory.Controls.Add(this.Txt_EveCentralCom_PriceHistory, 1, 0);
			this.Tbl_EveCentralCom_PriceHistory.Controls.Add(this.Lbl_EveCentralCom_PriceHistory2, 2, 0);
			this.Tbl_EveCentralCom_PriceHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tbl_EveCentralCom_PriceHistory.Location = new System.Drawing.Point(5, 200);
			this.Tbl_EveCentralCom_PriceHistory.Margin = new System.Windows.Forms.Padding(0);
			this.Tbl_EveCentralCom_PriceHistory.Name = "Tbl_EveCentralCom_PriceHistory";
			this.Tbl_EveCentralCom_PriceHistory.RowCount = 1;
			this.Tbl_EveCentralCom_PriceHistory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.Tbl_EveCentralCom_PriceHistory.Size = new System.Drawing.Size(303, 25);
			this.Tbl_EveCentralCom_PriceHistory.TabIndex = 8;
			// 
			// Lbl_EveCentralCom_PriceHistory1
			// 
			this.Lbl_EveCentralCom_PriceHistory1.AutoSize = true;
			this.Lbl_EveCentralCom_PriceHistory1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Lbl_EveCentralCom_PriceHistory1.Location = new System.Drawing.Point(3, 0);
			this.Lbl_EveCentralCom_PriceHistory1.Name = "Lbl_EveCentralCom_PriceHistory1";
			this.Lbl_EveCentralCom_PriceHistory1.Size = new System.Drawing.Size(74, 25);
			this.Lbl_EveCentralCom_PriceHistory1.TabIndex = 0;
			this.Lbl_EveCentralCom_PriceHistory1.Text = "Price history :";
			this.Lbl_EveCentralCom_PriceHistory1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Txt_EveCentralCom_PriceHistory
			// 
			this.Txt_EveCentralCom_PriceHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Txt_EveCentralCom_PriceHistory.Location = new System.Drawing.Point(83, 3);
			this.Txt_EveCentralCom_PriceHistory.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
			this.Txt_EveCentralCom_PriceHistory.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Txt_EveCentralCom_PriceHistory.Name = "Txt_EveCentralCom_PriceHistory";
			this.Txt_EveCentralCom_PriceHistory.Size = new System.Drawing.Size(74, 20);
			this.Txt_EveCentralCom_PriceHistory.TabIndex = 1;
			this.Txt_EveCentralCom_PriceHistory.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// Lbl_EveCentralCom_PriceHistory2
			// 
			this.Lbl_EveCentralCom_PriceHistory2.AutoSize = true;
			this.Lbl_EveCentralCom_PriceHistory2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Lbl_EveCentralCom_PriceHistory2.Location = new System.Drawing.Point(163, 0);
			this.Lbl_EveCentralCom_PriceHistory2.Name = "Lbl_EveCentralCom_PriceHistory2";
			this.Lbl_EveCentralCom_PriceHistory2.Size = new System.Drawing.Size(189, 25);
			this.Lbl_EveCentralCom_PriceHistory2.TabIndex = 2;
			this.Lbl_EveCentralCom_PriceHistory2.Text = "days";
			this.Lbl_EveCentralCom_PriceHistory2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FrmPriceType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 299);
			this.Controls.Add(this.TblMain);
			this.Name = "FrmPriceType";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Price Settings";
			this.Load += new System.EventHandler(this.FrmPriceType_Load);
			this.TblMain.ResumeLayout(false);
			this.SplOkCancel.ResumeLayout(false);
			this.TabProviders.ResumeLayout(false);
			this.TabEveCentralCom.ResumeLayout(false);
			this.TblEveCentralCom.ResumeLayout(false);
			this.TblEveCentralCom.PerformLayout();
			this.Tbl_EveCentralCom_PriceHistory.ResumeLayout(false);
			this.Tbl_EveCentralCom_PriceHistory.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Txt_EveCentralCom_PriceHistory)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel TblMain;
		private System.Windows.Forms.TableLayoutPanel SplOkCancel;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnOk;
		private System.Windows.Forms.TabControl TabProviders;
		private System.Windows.Forms.TabPage TabEveCentralCom;
		private System.Windows.Forms.TableLayoutPanel TblEveCentralCom;
		private System.Windows.Forms.Label Lbl_EveCentralCom_Region;
		private System.Windows.Forms.Label Lbl_EveCentralCom_Solar;
		private System.Windows.Forms.Label Lbl_EveCentralCom_PriceType;
		private System.Windows.Forms.ComboBox Cmb_EveCentralCom_Region;
		private System.Windows.Forms.ComboBox Cmb_EveCentralCom_Solar;
		private System.Windows.Forms.ComboBox Cmb_EveCentralCom_PriceType;
		private System.Windows.Forms.Label Lbl_EveCentralCom_PriceHistory_Hint;
		private System.Windows.Forms.TableLayoutPanel Tbl_EveCentralCom_PriceHistory;
		private System.Windows.Forms.Label Lbl_EveCentralCom_PriceHistory1;
		private System.Windows.Forms.NumericUpDown Txt_EveCentralCom_PriceHistory;
		private System.Windows.Forms.Label Lbl_EveCentralCom_PriceHistory2;
	}
}