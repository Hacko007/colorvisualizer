using System;
using System.Windows.Forms;
using Hackovic.VisualStudio.NumberVisualizer;
using Microsoft.VisualStudio.DebuggerVisualizers;
using NumberVisualizer;

  [assembly: System.Diagnostics.DebuggerVisualizer(
    typeof( IntVisualizer ),
    typeof( IntVisualizerObjectSource ),
    Target = typeof(int),
    Description = "Number formats")]
namespace Hackovic.VisualStudio.NumberVisualizer
{

  public class IntVisualizer : DialogDebuggerVisualizer
  {

    protected override void Show( IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider )
    {
      try
      {
        int wrapper = (int)objectProvider.GetObject();
        var frm = new NumberForm
        {
          Int = wrapper
        };
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
          objectToVisualize, typeof( IntVisualizer ), typeof( IntVisualizerObjectSource ), false );

      visualizerHost.ShowVisualizer();
    }
  }
  public class IntVisualizerObjectSource : VisualizerObjectSource
  {
    public override void GetData( object target, System.IO.Stream outgoingData )
    {
      int data = (int)target;
      base.GetData( data, outgoingData );
    }

  }

}

