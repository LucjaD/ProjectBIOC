using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public class Ant : Field
    {
        private const int _lostFeromon = 10; 
        public Ant(int x, int y) : base(x, y)
        {
        }

        public void Move(Labirynth labirynth, Field to)
        {
            labirynth.Board[to.X, to.Y] = this;
            labirynth.Board[X, Y] = new Feromon(X,Y, _lostFeromon);
            X = to.X;
            Y = to.Y;

        }
    }

}
