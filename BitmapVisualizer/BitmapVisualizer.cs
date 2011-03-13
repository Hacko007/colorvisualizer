using System;
using System.Drawing;
using System.Windows.Forms;
using Hackovic.VisualStudio;
using Microsoft.VisualStudio.DebuggerVisualizers;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof( BitmapVisualizer ),
    typeof( ImageVisualizerObjectSource ),
    Target = typeof(Image),
    Description = "Bitmap visualizer")]

namespace Hackovic.VisualStudio
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
