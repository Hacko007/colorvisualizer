using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Hackovic.VisualStudio;
using Microsoft.VisualStudio.DebuggerVisualizers;

[assembly: DebuggerVisualizer(
  typeof( DataRowVisualizer ),
  typeof( DataRowVisualizerObjectSource ),
  Target = typeof( DataRow ),
  Description = "DataRow visualizer" )]
namespace Hackovic.VisualStudio
{
  public class DataRowVisualizer : DialogDebuggerVisualizer
  {
    protected override void Show( IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider )
    {
      try
      {
        var wrapper = (DataRowData)objectProvider.GetObject();
        var frm = new DataRowForm
                    {
                     DataRow = wrapper
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
    ///   Tests the visualizer by hosting it outside of the debugger.
    /// </summary>
    /// <param name = "objectToVisualize">The object to display in the visualizer.</param>
    public static void TestShowVisualizer( object objectToVisualize )
    {
      var visualizerHost = new VisualizerDevelopmentHost(
        objectToVisualize, typeof( DataRowVisualizer ), typeof( DataRowVisualizerObjectSource ), false );

      visualizerHost.ShowVisualizer();
    }
  }

  public class DataRowVisualizerObjectSource : VisualizerObjectSource
  {
    public override void GetData( object target, Stream outgoingData )
    {
      var data = (DataRow)target;
      var columns = new string[data.Table.Columns.Count];
      var i = 0;
      foreach (DataColumn dataColumn in data.Table.Columns)
      {
        columns[i++] = dataColumn.ColumnName;
      }
      DataRowData dataRowData = new DataRowData
                                  {
                                    Columns = columns,
                                    ItemArray = data.ItemArray,
                                    RowState = data.RowState
                                  };
      base.GetData( dataRowData, outgoingData );
    }
  }

  [Serializable]
  public class DataRowData
  {
    public string[] Columns { get; set; }

    public object[] ItemArray { get; set; }

    public DataRowState RowState { get; set; }
  }
}