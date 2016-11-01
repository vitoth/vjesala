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
            this.pojam = pojam.ToUpper();
            zaPrikaz = new StringBuilder(new string(ZnakZaNeotkrivenaSlova, pojam.Length));
        }

        public bool ImasLiSlovo(char slovo)
        {
            slovo = char.ToUpper(slovo);
            for (int i=0; i<pojam.Length; ++i)
            {
                if (pojam[i] == slovo)
                    zaPrikaz[i] = slovo;
            }
            return pojam.Contains(slovo);
        }

        public bool JesiLi(string riječ)
        {
            return string.Compare(riječ, pojam, true) == 0;
        }

        public  string Prikaz()
        {
           
            return zaPrikaz.ToString();
        }

        public StringBuilder VratiRijecZaPrikaz
        {
            get { return zaPrikaz; }
        }



        public const char ZnakZaNeotkrivenaSlova = '-';
        public StringBuilder zaPrikaz;
        public string pojam;
    }
}
