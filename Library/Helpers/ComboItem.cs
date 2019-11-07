using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Helpers
{
    class ComboItem
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public ComboItem(int id, string value)
        {
            this.Id = id;
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}
