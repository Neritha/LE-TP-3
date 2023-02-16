// Carré Victoria
// TP 3 C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LE_TP_3
{
    internal class Commercial
    {
        private string nom;
        private string prenom;
        private int anneeNaissance;

        private Categorie objcat;
        private Service objserv;


        // accesseures
        public string Nom
        {
            get => nom;
            set => nom = value;
        }
        public string Prenom
        {
            get => prenom;
            set => prenom = value;
        }
        public int AnneeNaissance
        {
            get => anneeNaissance;
            set => anneeNaissance = value;
        }

        // contructeurs
        public Commercial(string no, string pr, int an)
        {
            this.Nom = no;
            this.Prenom = pr;
            this.AnneeNaissance = an;
        }

        public Commercial(string no, string pr, int an, Categorie oc, Service os)
        {
            this.Nom = no;
            this.Prenom = pr;
            this.AnneeNaissance = an;
            this.objcat = oc;
            this.objserv = os;
            this.objserv.ajouter(this);
        }

        // autre methodes
        public int calculAge()
        {
            return DateTime.Now.Year - this.AnneeNaissance;
        }

        public override string ToString()
        {

            return "Information sur le commercial;\nNom : " + this.Nom + "\nPrénom : " + this.Prenom + "\nAnnée de naissance : " + this.AnneeNaissance + "\nCe commercial a donc " + calculAge() + " ans.\n\n" + objcat + objserv;
        }

        public string compare(Commercial c)
        {
            if (c.Nom == this.Nom)
            {
                return "\nLes commerciaux " + c.Prenom + " et " + this.Prenom + " ont le même nom de famille.\n";
            }
            else
            {
                return "\nLes commerciaux " + c.Prenom + " et " + this.Prenom + " n'ont pas le même nom de famille.\n";
            }
        }
    }
}
