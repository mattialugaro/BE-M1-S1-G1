using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Atleta
    {
        private string _sport;

        public string Sport
        {
            get
            {
                return _sport;
            }
            set
            {
                _sport = value;
            }
        }

        public string vittorie(int medaglie)
        {
            if (medaglie > 5)
            {
                return "Sei un campione";
            }
            else
            {
                return "Meglio di niente";
            }
        }

    }   

}
