// Carré Victoria
// TP 3 C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LE_TP_3
{
    internal class Service
    {
        private string nomService;
        //private string[] tableCom = new string[10];
        private Commercial[] tableauCom;
        private int effectif;

        // accesseurs
        public string NomService { get => nomService; set => nomService = value; }
        public int Effectif { get => effectif; set => effectif = value; }
        internal Commercial[] TableauCom { get => tableauCom; set => tableauCom = value; }


        // constructeur
        public Service(string no)
        {
            this.NomService = no; 
            this.TableauCom = new Commercial[10];
            this.Effectif = 0;
        }



        internal void ajouter (Commercial c)
        {
            if (this.Effectif < 10)
            {
                this.TableauCom[this.Effectif] = c;
                this.Effectif++;
            }
        }

        public void afficher()
        {
            Console.WriteLine("\nLes membres du services " + this.NomService + " sont : "); 
            for (int i = 0; i < this.Effectif; i++)
            {
                Console.WriteLine(this.TableauCom[i].Nom + " " + this.TableauCom[i].Prenom);
            }

        }

        public override string ToString()
        {
            return "Information sur le service; \nLe nom du service est : " + this.NomService + "\nL'effectif est de : " + this.Effectif;
        }

        public string plusAge()
        {
            int dateN = 9999;
            string lePlusVieuxN = "a";
            string lePlusVieuxP = "a";
            int age = 1;
            for (int j = 0; j < this.Effectif; j++)
            {
                if (this.TableauCom[j].AnneeNaissance < dateN)
                {
                    dateN = this.TableauCom[j].AnneeNaissance;
                    lePlusVieuxN = this.TableauCom[j].Nom;
                    lePlusVieuxP = this.TableauCom[j].Prenom;
                    age = this.TableauCom[j].calculAge();
                }
            }

            return "\nLe commercial le plus agé du service " + this.NomService + " est " + lePlusVieuxP +" "+ lePlusVieuxN + " né en " + dateN + " il a donc " + age + " ans.";
        }





    }
}
