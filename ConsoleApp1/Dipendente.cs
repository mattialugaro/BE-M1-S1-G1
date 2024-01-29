using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dipendente
    {
        private string _azienda;

        public string Azienda
        {
            get
            {
                return _azienda;
            }
            set
            {
                _azienda = value;
            }
        }

        public string anniEsperienza(int exp)
        {
            if(exp >= 5)
            {
                return "sei un veterano";
            }
            else
            {
                return "hai ancora della strada da fare";
            }
        }
    }
}
