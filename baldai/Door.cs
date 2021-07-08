using System;
using System.Collections.Generic;
using System.Text;

namespace baldai
{
    class Door
    {
        public string Name { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public double Length { get; set; } //cm
        public double Width { get; set; }//mm
        public double Height { get; set; }//cm
        public int Hinges { get; set; }
        public string Side { get; set; }
        public List<Miscellaneous> misc = new List<Miscellaneous>();

        public override string ToString()
        {
            return "Pavadinimas - " + Name + " medžiaga - " + Material+"; ";
        }
    }
}
