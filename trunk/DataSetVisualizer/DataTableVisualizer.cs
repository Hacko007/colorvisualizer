using System;
using System.Data;
using System.Windows.Forms;
using Hackovic.VisualStudio;
using Microsoft.VisualStudio.DebuggerVisualizers;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof( DataTableVisualizer ),
    typeof( DataTableVisualizerObjectSource ),
    Target = typeof( DataTable),
    Description = "DataTable Save Visualizer" )]

namespace Hackovic.VisualStudio
{
  public class DataTableVisualizer : DialogDebuggerVisualizer
  {
    protected override void Show( IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider )
    {
      try
      {
        DataTable wrapper = (DataTable)objectProvider.GetObject();

        if( wrapper.DataSet == null )
        {
          var ds = new DataSet("Table visualizer");
          ds.Tables.Add(wrapper);        
        }

        DataSetForm frm = new DataSetForm
                            {
                              DataSet = wrapper.DataSet,
                              DisableTableListBox = true
                            };
        frm.InitForm();
        frm.ShowDialog();
      }
      catch( Exception ex )
      {
        MessageBox.Show( ex.Message, GetType().ToString() );
      }
    }

    /// <summary>
    /// Tests the visualizer by hosting it outside of the debugger.
    /// </summary>
    /// <param name="objectToVisualize">The object to display in the visualizer.</param>
    public static void TestShowVisualizer( object objectToVisualize )
    {
      VisualizerDevelopmentHost visualizerHost = new VisualizerDevelopmentHost(
        objectToVisualize, typeof( DataTableVisualizer ), typeof( DataTableVisualizerObjectSource ), false );

      visualizerHost.ShowVisualizer();
    }
  }


  public class DataTableVisualizerObjectSource : VisualizerObjectSource
  {
    public override void GetData( object target, System.IO.Stream outgoingData )
    {
      var data = (DataTable)target;
      base.GetData( data, outgoingData );
    }

  }
}