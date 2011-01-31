using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(DataSetVisualizer.DataSetVisualizer),
    typeof(DataSetVisualizer.DataSetVisualizerObjectSource),
    Target = typeof(DataSet),
    Description = "DataSet Save visualizer")]
namespace DataSetVisualizer
{
    public class DataSetVisualizer: DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            try
            {
                DataSet wrapper = (DataSet)objectProvider.GetObject();
                DataSetForm frm = new DataSetForm { DataSet = wrapper };
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
                objectToVisualize, typeof(DataSetVisualizer), typeof(DataSetVisualizerObjectSource), false);

            visualizerHost.ShowVisualizer();
        }
    }
    public class DataSetVisualizerObjectSource : VisualizerObjectSource
    {
        public override void GetData(object target, System.IO.Stream outgoingData)
        {
            DataSet data = (DataSet)target;
            base.GetData(data, outgoingData);
        }

    }
}
