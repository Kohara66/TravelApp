using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{

    public class Locations
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public Locations(string text, string value)
        {
            this.Text = text;
            this.Value = value;
        }
    }
}






