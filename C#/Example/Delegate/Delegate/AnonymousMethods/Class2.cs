﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate.AnonymousMethods
{
    internal class Class2
    {
        public static void ddd()
        {
            // Create an array of Point structures.
            Point[] points = { new Point(100, 200), 
                         new Point(150, 250), new Point(250, 375), 
                         new Point(275, 395), new Point(295, 450) };

            // Define the Predicate<T> delegate.
            Predicate<Point> predicate = FindPoints;

            // Find the first Point structure for which X times Y  
            // is greater than 100000. 
            Point first = Array.Find(points, predicate);

            // Display the first structure found.
            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);
        }

        private static bool FindPoints(Point obj)
        {
            return obj.X * obj.Y > 100000;
        }
    }
}
