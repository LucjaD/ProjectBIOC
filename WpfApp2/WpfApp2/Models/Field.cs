using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp2.Models
{
    public class Field
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Field(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
