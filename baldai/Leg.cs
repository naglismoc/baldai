using System;
using System.Collections.Generic;
using System.Text;

namespace baldai
{
    class Leg
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public double Length { get; set; } //mm
        public double Width { get; set; }//mm
        public double Height { get; set; }//cm
        public string Shape { get; set; } //sq, circle
        public double PreasureThoughness { get; set; } //sq, circle
        public List<Miscellaneous> misc = new List<Miscellaneous>();

        public override string ToString()
        {
            return "Pavadinimas - " + Name + " medžiaga - " + Material + "; ";
        }
    }
}
