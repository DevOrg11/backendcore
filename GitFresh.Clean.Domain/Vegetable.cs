using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFresh.Clean.Domain
{
    public class Vegetable
    {
        public int VegetableId { get; set; }
        public string? Name { get; set; }
        public double GlycemicIndex { get; set; }
        public double Carbs { get; set; }
        public double Protein { get; set; }

    }
}
