#region Using declarations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;
using NinjaTrader.Cbi;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.Gui.SuperDom;
using NinjaTrader.Gui.Tools;
using NinjaTrader.Data;
using NinjaTrader.NinjaScript;
using NinjaTrader.Core.FloatingPoint;
using NinjaTrader.NinjaScript.DrawingTools;
#endregion

//This namespace holds Indicators in this folder and is required. Do not change it. 
namespace NinjaTrader.NinjaScript.Indicators
{
	public class CustHorizontalRangeIndicator : Indicator
	{
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description									= @"여기에 지표 대한 설명을 입력하십시오.";
				Name										= "CustHorizontalRangeIndicator";
				Calculate									= Calculate.OnBarClose;
				IsOverlay									= false;
				DisplayInDataBox							= true;
				DrawOnPricePanel							= true;
				DrawHorizontalGridLines						= true;
				DrawVerticalGridLines						= true;
				PaintPriceMarkers							= true;
				ScaleJustification							= NinjaTrader.Gui.Chart.ScaleJustification.Right;
				//Disable this property if your indicator requires custom values that cumulate with each new market data event. 
				//See Help Guide for additional information.
				IsSuspendedWhileInactive					= true;
			}
			else if (State == State.Configure)
			{
			}
		}

		protected override void OnBarUpdate()
		{
			//여기에 indicator 로직을 추가하세요.
		}
	}
}

#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		private CustHorizontalRangeIndicator[] cacheCustHorizontalRangeIndicator;
		public CustHorizontalRangeIndicator CustHorizontalRangeIndicator()
		{
			return CustHorizontalRangeIndicator(Input);
		}

		public CustHorizontalRangeIndicator CustHorizontalRangeIndicator(ISeries<double> input)
		{
			if (cacheCustHorizontalRangeIndicator != null)
				for (int idx = 0; idx < cacheCustHorizontalRangeIndicator.Length; idx++)
					if (cacheCustHorizontalRangeIndicator[idx] != null &&  cacheCustHorizontalRangeIndicator[idx].EqualsInput(input))
						return cacheCustHorizontalRangeIndicator[idx];
			return CacheIndicator<CustHorizontalRangeIndicator>(new CustHorizontalRangeIndicator(), input, ref cacheCustHorizontalRangeIndicator);
		}
	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		public Indicators.CustHorizontalRangeIndicator CustHorizontalRangeIndicator()
		{
			return indicator.CustHorizontalRangeIndicator(Input);
		}

		public Indicators.CustHorizontalRangeIndicator CustHorizontalRangeIndicator(ISeries<double> input )
		{
			return indicator.CustHorizontalRangeIndicator(input);
		}
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		public Indicators.CustHorizontalRangeIndicator CustHorizontalRangeIndicator()
		{
			return indicator.CustHorizontalRangeIndicator(Input);
		}

		public Indicators.CustHorizontalRangeIndicator CustHorizontalRangeIndicator(ISeries<double> input )
		{
			return indicator.CustHorizontalRangeIndicator(input);
		}
	}
}

#endregion
