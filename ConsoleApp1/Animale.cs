using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animale
    {
        private string _genere;
        private string _razza;
        private string _territorio;

        public string Genere
        {
            get
            {
                return _genere;
            }
            set
            {
                _genere = value;
            }
        }

        public string Razza
        {
            get
            {
                return _razza;
            }
            set
            {
                _razza = value;
            }
        }

        public string Terrirorio
        {
            get
            {
                return _territorio;
            }
            set
            {
                _territorio = value;
            }
        }

       
    }
}
