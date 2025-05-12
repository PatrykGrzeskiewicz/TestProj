using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestProj
{
    internal class Class1
    {
        public int Rnd(int from, int to)
        {
            Random random = new Random();
            return random.Next(from, to);

            string d = "";

            MessageBoxButton button = MessageBoxButton.YesNo;

        }
    }
}
