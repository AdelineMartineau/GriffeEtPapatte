using System;
using System.Collections.Generic;
using System.Text;

namespace GriffeEtPapatte
{
    class Alea {

        private Random random;

        public Alea() {

            random = new Random();
        }

        public int AleaDix() {
            return random.Next(0, 11);
        }

    }
}
