using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Windows.Forms;
using System.Drawing;


[assembly: System.Diagnostics.DebuggerVisualizer(
	typeof(ColorVisualizer.ColorVisualizer),
	typeof(ColorVisualizer.ColorVisualizerObjectSource),
	Target = typeof(Color),
	Description = "Color visualizer")]

namespace ColorVisualizer
{
	public class ColorVisualizer : DialogDebuggerVisualizer
	{
		protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
		{
			try
			{
				Color wrapper = (Color)objectProvider.GetObject();
				ColorForm frm = new ColorForm { Color = wrapper };				
				frm.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, GetType().ToString());
			}
		}

		/// <summary>
		/// Tests the visualizer by hosting it outside of the debugger.
		/// </summary>
		/// <param name="objectToVisualize">The object to display in the visualizer.</param>
		public static void TestShowVisualizer(object objectToVisualize)
		{
			VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(
				objectToVisualize, typeof(ColorVisualizer), typeof(ColorVisualizerObjectSource), false);

			visualizerHost.ShowVisualizer();
		}

	}

	public class ColorVisualizerObjectSource : VisualizerObjectSource
	{
		public override void GetData(object target, System.IO.Stream outgoingData)
		{
			Color data = (Color)target;
			base.GetData(data, outgoingData);
		}

	}
}
