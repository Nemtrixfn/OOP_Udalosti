using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace OOP_Udalosti
{
    public class Entity
    {
        private int SelectedColor;
        Random Random = new Random();


        public Point Location { get; set; }
        public Double Size { get; set; }
        public Brush Color { get => Colors[SelectedColor]; }
        public List<Brush> Colors { get; set;}

        public Entity() 
        {
            Random = new Random();
            Location = new Point();
            Size = 50;
            Colors = new List<Brush>() 
            {
                Brushes.Blue,
                Brushes.Black,
                Brushes.Yellow,
                Brushes.Orange,
                Brushes.Green,
                Brushes.Red,
                Brushes.AliceBlue, 
                Brushes.Orchid,
                Brushes.Azure,
                Brushes.Bisque, 
                Brushes.Brown

            };
            SelectedColor = Random.Next(0, Colors.Count);
        }

    }
}
