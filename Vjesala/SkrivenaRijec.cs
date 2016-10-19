using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraVjesala
{
    public class SkrivenaRijec
    {
        public SkrivenaRijec(string pojam)
        {
            this.pojam = pojam;
            zaPrikaz = new StringBuilder(new string('_', pojam.Length));
        }

        public bool ImasLiSlovo(char slovo)
        {
            for (int i=0; i<pojam.Length; ++i)
            {
                if (pojam[i] == slovo)
                    zaPrikaz[i] = slovo;
            }
            return pojam.Contains(slovo);
        }

        public string Prikaz()
        {
            return zaPrikaz.ToString();
        }
        StringBuilder zaPrikaz;
        string pojam;
    }
}
