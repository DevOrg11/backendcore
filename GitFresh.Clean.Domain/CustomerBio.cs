using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitFresh.Clean.Domain
{
    public class CustomerBio
    {
        public int BioID { get; set; }
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMI { get; set; }
        public string? Allergies { get; set; }
        public double SugarLevel { get; set; }
        public double CholesterolLevel { get; set; }
        public string? Body_Type { get; set; }
        public string? RelationshipType { get; set; }

    }
}
