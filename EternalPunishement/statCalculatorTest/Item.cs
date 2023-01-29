using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace statCalculatorTest
{
    internal class Item
    {
        private string name;
        private string description;
        private string type;

        public Item()
        {
            Name = "None";
            Description="Nothing...";
            type = "?";
        }
        public Item(string name, string description, string type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

    }
}
