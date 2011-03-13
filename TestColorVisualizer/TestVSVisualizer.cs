using System;
using System.Data;
using System.Drawing;
using System.IO;
using Hackovic.VisualStudio.NumberVisualizer;

namespace Hackovic.VisualStudio
{
  public class TestVSVisualizer
  {

    [System.STAThreadAttribute]
    static void Main()
    {
      TestNumber();
      //TestColorVis();
      //TestBitmapVisualizer();
      //TestDataSetVisaulizer();
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

      t1.Columns.Add( "T11" );
      t1.Columns.Add( "T12" );
      t1.Columns.Add( "T13" );
      var row = t1.NewRow();
      row[0] = "1";
      row[1] = "2";
      row[2] = "3";
      t1.Rows.Add( row );
      t1.AcceptChanges();


      t2.Columns.Add( "T21" );
      t2.Columns.Add( "T22" );
      t2.Columns.Add( "T23" );

      t3.Columns.Add( "T31" );

      DataSetVisualizer.TestShowVisualizer( ds );
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
