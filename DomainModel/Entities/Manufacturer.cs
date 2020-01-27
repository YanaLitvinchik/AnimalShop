using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.Entities
{
    public class Manufacturer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Good> Good { get; set; } = new List<Good>();
    }
}
