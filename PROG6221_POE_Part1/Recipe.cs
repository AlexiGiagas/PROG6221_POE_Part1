using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_POE_Part1
{
    class Recipe
    {
        public List<Ingredients> Ingredients { get; set; }
        public List<string> Steps { get; set; }
        public double ScaleFactor { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredients>();
            Steps = new List<string>();
            ScaleFactor = 1;
        }

    }
}
