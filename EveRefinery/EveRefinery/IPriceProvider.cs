﻿using System;
using System.Collections.Generic;

namespace EveRefinery
{
	enum PriceProviders
	{
		EveCentral,
	}

	struct PriceSettings
	{
		public PriceProviders		Provider;
		public UInt32				RegionID;
		public UInt32				SolarID;
		public UInt32				StationID;
		public PriceTypes			Type;

		public bool Matches(PriceSettings a_Rhs)
		{
			return
				(Provider	== a_Rhs.Provider) && 
				(RegionID	== a_Rhs.RegionID) && 
				(SolarID	== a_Rhs.SolarID) &&
				(StationID	== a_Rhs.StationID) &&
				(Type		== a_Rhs.Type);
		}
	}

	class PriceRecord
	{
		public PriceSettings		Settings;
		public UInt32				TypeID;
		public double				Price;
		public UInt64				UpdateTime;
	}

	interface IPriceProvider
	{
		List<PriceRecord>			GetPrices(List<UInt32> a_TypeIDs, PriceSettings a_Settings);
	}
}