using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraVjesala
{
    public class Igra
    {
        public Igra()
        {
            Random izbornik = new Random();
            int indeks = izbornik.Next(0, fondRiječi.Count());
            skrivenaRiječ = new SkrivenaRijec(fondRiječi[indeks]);
            
        }

        public void UnesiSlovo(char slovo)
        {
            bool pogodak = skrivenaRiječ.ImasLiSlovo(slovo);
            if (pogodak)
                skrivenaRiječ.Prikaz();
            else
            {
                vješala.DodajDioTijela();
                vješala.PrikažiSe();
            }
        }

        public bool SvaSlovaOtkrivena
        {
            get { return string.Compare(skrivenaRiječ.zaPrikaz.ToString(), skrivenaRiječ.pojam, true)== 0;  }
        }

        public bool IgraGotova
        {
            get { return vješala.NaVjesalima == Vjesala.DijelovaTijela; }
        }

        private SkrivenaRijec skrivenaRiječ;
        private Vjesala vješala = new Vjesala();

        private string[] fondRiječi = { "mama", "tata", "sunce", "auto" };
    }
}
