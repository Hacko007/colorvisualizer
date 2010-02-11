using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Windows.Forms;
using System.Drawing;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(BitmapVisualizer.BitmapVisualizer),
    typeof(BitmapVisualizer.ImageVisualizerObjectSource),
    Target = typeof(Image),
    Description = "Bitmap visualizer")]

namespace BitmapVisualizer
{
    public class BitmapVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            try
            {
                Bitmap wrapper = (Bitmap)objectProvider.GetObject();
                BitmapForm frm = new BitmapForm { Bitmap = wrapper };
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
                objectToVisualize, typeof(BitmapVisualizer), typeof(ImageVisualizerObjectSource), false);

            visualizerHost.ShowVisualizer();
        }
    }
    public class ImageVisualizerObjectSource : VisualizerObjectSource
    {
        public override void GetData(object target, System.IO.Stream outgoingData)
        {
            Bitmap data = (Bitmap)target;
            base.GetData(data, outgoingData);
        }

    }
}
