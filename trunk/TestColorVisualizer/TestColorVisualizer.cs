using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TestColorVisualizer
{
	public class TestColorVisualizer
	{
		static void Main()
		{
			ColorVisualizer.ColorVisualizer.TestShowVisualizer(Color.Beige);
			ColorVisualizer.ColorVisualizer.TestShowVisualizer(Color.FromArgb(15,46,123 ));
			ColorVisualizer.ColorVisualizer.TestShowVisualizer(Color.Black);
			ColorVisualizer.ColorVisualizer.TestShowVisualizer(SystemColors.Control);
			ColorVisualizer.ColorVisualizer.TestShowVisualizer(Color.Green);
		}
	}
}
