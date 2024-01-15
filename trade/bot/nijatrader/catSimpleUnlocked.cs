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
using NinjaTrader.NinjaScript.Indicators;
using NinjaTrader.NinjaScript.DrawingTools;
#endregion

//This namespace holds Strategies in this folder and is required. Do not change it. 
namespace NinjaTrader.NinjaScript.Strategies
{
	public class catSimpleUnlocked : Strategy
	{
		protected override void OnStateChange()
		{
			if (State == State.SetDefaults)
			{
				Description									= @"cat Simple Test";
				Name										= "catSimpleUnlocked";
				Calculate									= Calculate.OnBarClose;
				EntriesPerDirection							= 1;
				EntryHandling								= EntryHandling.AllEntries;
				IsExitOnSessionCloseStrategy				= true;
				ExitOnSessionCloseSeconds					= 30;
				IsFillLimitOnTouch							= false;
				MaximumBarsLookBack							= MaximumBarsLookBack.TwoHundredFiftySix;
				OrderFillResolution							= OrderFillResolution.Standard;
				Slippage									= 0;
				StartBehavior								= StartBehavior.WaitUntilFlat;
				TimeInForce									= TimeInForce.Gtc;
				TraceOrders									= false;
				RealtimeErrorHandling						= RealtimeErrorHandling.StopCancelClose;
				StopTargetHandling							= StopTargetHandling.PerEntryExecution;
				BarsRequiredToTrade							= 20;
				// Disable this property for performance gains in Strategy Analyzer optimizations
				// See the Help Guide for additional information
				IsInstantiatedOnEachOptimizationIteration	= true;
				FastMA					= 9;
				SlowMA					= 21;
				AddPlot(Brushes.Green, "FastMA"); // stored as Plots[0] and Values[0]
				AddPlot(Brushes.Blue, "SlowMA");  // stored as Plots[1] and Values[0]
			}
			else if (State == State.Configure)
			{
			}
		}

		protected override void OnBarUpdate()
		{
			if (BarsInProgress != 0) 
				return;
			// Check if RTH
			bool market_open = ToTime(Time[0]) >= 093000 && ToTime(Time[0]) <= 160000;
			// Moving Average
			bool cross_above = CrossAbove(SMA(FastMA), SMA(SlowMA), 1);
			bool cross_below = CrossBelow(SMA(FastMA), SMA(SlowMA), 1);
			Values[0][0] = SMA(FastMA)[0];
			Values[1][0] = SMA(SlowMA)[0];
			// Enter Positions
			if (market_open)
			{
				if (cross_above)
				{
					EnterLong(Convert.ToInt32(DefaultQuantity), "");
				}
				else if (cross_below)
				{
					EnterShort(Convert.ToInt32(DefaultQuantity), "");
				}
			}
			// Exitl Positions
			if (!market_open)
			{
				ExitLong();
			}
		}

		#region Properties
		[NinjaScriptProperty]
		[Range(1, int.MaxValue)]
		[Display(Name="FastMA", Order=1, GroupName="Parameters")]
		public int FastMA
		{ get; set; }

		[NinjaScriptProperty]
		[Range(1, int.MaxValue)]
		[Display(Name="SlowMA", Order=2, GroupName="Parameters")]
		public int SlowMA
		{ get; set; }
		#endregion

	}
}
