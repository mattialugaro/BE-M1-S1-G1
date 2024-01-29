using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Veicolo
    {
        private string _marca;
        private string _modello;

        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                _marca = value;
            }
        }

        public string Modello
        {
            get
            {
                return _modello;
            }
            set
            {
                _modello = value;
            }
        }

        public string kmAlLitro(int km)
        {
            if(km > 50)
            {
                return "questa macchina consuma poco";
            }
            else
            {
                return "le altre macchine consumano meno";
            }
        }
    }
}
