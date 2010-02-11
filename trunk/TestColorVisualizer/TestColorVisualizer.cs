using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace TestColorVisualizer
{
	public class TestColorVisualizer
	{
		static void Main()
		{
            ColorVisualizer.ColorVisualizer.TestShowVisualizer(Color.Green);
            string path =  @"C:\temp\forest.jpg";
            if (File.Exists(path))
            {
                Bitmap bmp = new Bitmap(path);
                BitmapVisualizer.BitmapVisualizer.TestShowVisualizer(bmp);
            }
		}
	}
}
