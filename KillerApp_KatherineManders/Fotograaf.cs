using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerApp_KatherineManders
{
    public class Fotograaf
    {
   
        private string naam;
        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        private List<string> fotos;
        public List<string> Fotos
        {
            get { return fotos; }
            set { fotos = value; }
        }

        private int aantalFotos;
        public int AantalFotos
        {
            get { return aantalFotos; }
            set { aantalFotos = value; }
        }



    }
}
