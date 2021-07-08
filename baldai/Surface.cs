using System;
using System.Collections.Generic;
using System.Text;

namespace baldai
{
    class Surface
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public double Length { get; set; } //cm
        public double Width { get; set; }//cm
        public double Height { get; set; }//mm
        public string Shape { get; set; } //sq, circle
        public double BendThoughness { get; set; } //sq, circle

        public List<Miscellaneous> misc = new List<Miscellaneous>();

    }
}
