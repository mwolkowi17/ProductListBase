using System;
using System.Collections.Generic;
using System.Text;

namespace ProductBase
{
    class ProductDefinition
    {
        public int ProductDefinitionId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int YearOfProduction { get; set; }
        public double ActualPrice { get; set; }
    }
}
