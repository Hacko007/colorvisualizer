using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Hackovic.VisualStudio.NumberVisualizer;

namespace Hackovic.VisualStudio
{
  public class TestVSVisualizer
  {

    [System.STAThreadAttribute]
    static void Main()
    {
      //TestNumber();
      //TestColorVis();
      //TestBitmapVisualizer();
      TestDataSetVisaulizer();
    }

    private static void TestNumber()
    {      
      IntVisualizer.TestShowVisualizer(1000);
    }

    private static void TestDataSetVisaulizer()
    {
      DataSet ds = new DataSet( "MyDataSet" );
      DataTable t1 = ds.Tables.Add( "T1" );
      DataTable t2 = ds.Tables.Add( "T2" );
      DataTable t3 = ds.Tables.Add( "T3" );
      DataTable t4 = ds.Tables.Add( "T4" );

    var t1_c1 =  t1.Columns.Add( "T11" );
    t1.Columns.Add( "T12" );
      t1.Columns.Add( "T13" );

      

    var t2_c1 =    t2.Columns.Add( "T21" );
    t2.Columns.Add( "T22" );
      t2.Columns.Add( "T23" );

      var t3_c1 = t3.Columns.Add( "T31" );
      t4.Columns.Add( "T41" );
    
      t1.ParentRelations.Add( t2_c1, t1_c1 );
      t1.ChildRelations.Add( t1_c1, t3_c1 );

      var r = t2.NewRow();
      r[0] = "10";
      r[1] = "2.0";
      r[2] = "2.0";
      t2.Rows.Add( r );
      r = t2.NewRow();
      r[0] = "11";
      r[1] = "2.0";
      r[2] = "2.3";
      t2.Rows.Add( r );

      var row = t1.NewRow();
      row[0] = "10";
      row[1] = "20";
      row[2] = "30";
      t1.Rows.Add( row );

      row = t1.NewRow();
      row[0] = "11";
      row[1] = "21";
      row[2] = "31";
      t1.Rows.Add( row );


     
       var r2 = t3.NewRow();
      r2[0] = "10";
      t3.Rows.Add( r2 );

      var r41 = t4.NewRow();
      r41[0] = DateTime.Today;
      t4.Rows.Add(r41);
      var r42 = t4.NewRow();
      r42[0] = DateTime.Now;
      t4.Rows.Add( r42 );

      ds.AcceptChanges();
      BindingSource bindingSource = new BindingSource( ds,ds.Tables[0].TableName );
      
      DataGridView dataGridView = new DataGridView ();
      //dataGridView.DataSource = bindingSource;
      dataGridView.Columns.Add("C1", "C1");
      dataGridView.Rows .Add( new [] { "11/22/1968"})
      ;
      Console.WriteLine( dataGridView.Rows.Count);
      DataSetVisualizer.TestShowVisualizer( ds );
      //DataTableVisualizer.TestShowVisualizer(t1);
      //DataRowVisualizer.TestShowVisualizer(row);
      //DataGridViewRowVisualizer.TestShowVisualizer( dataGridView.Rows[0] );
    }

    private static void TestColorVis()
    {
      ColorVisualizer.TestShowVisualizer( Color.Green );
    }

    private static void TestBitmapVisualizer()
    {
      const string path = @"D:\temp\chart.png";
      if( File.Exists( path ) )
      {
        Bitmap bmp = new Bitmap( path );
        BitmapVisualizer.TestShowVisualizer( bmp );
      }
    }
  }
}
