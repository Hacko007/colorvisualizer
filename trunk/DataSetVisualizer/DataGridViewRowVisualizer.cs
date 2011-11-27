using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Hackovic.VisualStudio;
using Microsoft.VisualStudio.DebuggerVisualizers;

[assembly: DebuggerVisualizer(
  typeof (DataGridViewRowVisualizer),
  typeof (DataGridViewRowVisualizerObjectSource),
  Target = typeof (DataGridViewRow),
  Description = "DataGridViewRow visualizer")]

namespace Hackovic.VisualStudio
{
  public class DataGridViewRowVisualizer : DialogDebuggerVisualizer
  {
    protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
    {
      try
      {
        var wrapper = (RowData) objectProvider.GetObject();
        Console.WriteLine(wrapper.RowIndex);
        var frm = new DataGridViewRowForm
                    {
                      RowData = wrapper
                    };
        frm.InitForm();
        frm.ShowDialog();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, GetType().ToString());
      }
    }

    /// <summary>
    ///   Tests the visualizer by hosting it outside of the debugger.
    /// </summary>
    /// <param name = "objectToVisualize">The object to display in the visualizer.</param>
    public static void TestShowVisualizer(object objectToVisualize)
    {
      var visualizerHost = new VisualizerDevelopmentHost(
        objectToVisualize, typeof (DataGridViewRowVisualizer), typeof (DataGridViewRowVisualizerObjectSource), false);

      visualizerHost.ShowVisualizer();
    }
  }

  public class DataGridViewRowVisualizerObjectSource : VisualizerObjectSource
  {
    public override void GetData(object target, Stream outgoingData)
    {
      var data = (DataGridViewRow) target;

      var cells = new RowDataSet.CellInfoDataTable();
      foreach (DataGridViewCell cell in data.Cells)
      {
        var crow = cells.NewCellInfoRow();
        crow.HeaderName = cell.OwningColumn.HeaderText;
        crow.Name = cell.OwningColumn.Name;
        crow.ColumnIndex = cell.ColumnIndex;
        crow.Value = cell.Value;
        cells.Rows.Add(crow);
      }

      var row = new RowData
                  {
                    Cells = cells,
                    RowIndex = data.Index
                  };
      base.GetData(row, outgoingData);
    }
  }

  [Serializable]
  public class RowData
  {
    public int RowIndex { get; set; }

    public RowDataSet.CellInfoDataTable Cells { get; set; }
  }


}