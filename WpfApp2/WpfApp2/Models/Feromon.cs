using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public class Feromon : Field
    {
        public int Value { get; set; }
        public Feromon(int x, int y, int value) : base(x, y)
        {
            Value = value;
        }
    }
}
