// Carré Victoria
// TP 3 C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_TP_3
{
    internal class Categorie
    {
        private string codeCategorie;
        private string libCategorie;

        // accesseurs
        public string CodeCategorie { get => codeCategorie; set => codeCategorie = value; }
        public string LibCategorie { get => libCategorie; set => libCategorie = value; }

        // constructeur
        public Categorie(string co, string li)
        {
            this.CodeCategorie = co;
            this.LibCategorie = li;
        }

        // autre methode
        public override string ToString()
        {
            return "Information sur la cathégorie;\nCode : " + this.CodeCategorie + "\nLibelle : " + this.LibCategorie + "\n\n";
        }
        public Categorie()
        {

        }
    }
}
