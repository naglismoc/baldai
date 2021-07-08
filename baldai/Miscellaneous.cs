using System;
using System.Collections.Generic;
using System.Text;

namespace baldai
{
    class Miscellaneous
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public double Length { get; set; } //cm
        public double Width { get; set; }//mm
        public double Height { get; set; }//cm
        public string Shape { get; set; } //sq, circle
        public bool Transparent { get; set; }
        public string PositionX { get; set; }
        public string PositionY { get; set; }

        public List<Miscellaneous> misc = new List<Miscellaneous>();

    }
}
