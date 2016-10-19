using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraVjesala
{
    public class Vjesala
    {
        private int tijelo = 0;

        public void DodajDioTijela()
        {
            ++tijelo;

        }

        public int NaVjesalima
        {
            get { return tijelo; }
        }

        const int DijelovaTijela = 6;
    }
}
