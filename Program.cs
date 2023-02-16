// Carré Victoria
// TP 3 C#

using LE_TP_3;


// Les catégories utilisé 

Categorie categorie1 = new Categorie("code1", "salarié");
Categorie categorie2 = new Categorie("code2", "independant");


// Les services

Service service1 = new Service("National");
Service service2 = new Service("International");


// Les commerciaux

Commercial personne1 = new Commercial("Bélier", "Pedro", 2003, categorie1, service1);
Commercial personne2 = new Commercial("Bélier", "Marie-Rose", 2007, categorie2, service1);
Commercial personne3 = new Commercial("Lazare", "Oscar", 1996, categorie2, service2);
Commercial personne4 = new Commercial("Viandox", "Gaspard", 1981, categorie1, service2);
Commercial personne5 = new Commercial("Caskey", "Bob", 1993, categorie2, service1);
Commercial personne6 = new Commercial("Caskey", "Maurice", 2002, categorie1, service2);
Commercial personne7 = new Commercial("Debordenav", "Tota", 2000, categorie2, service1);

Console.WriteLine(personne1);
Console.WriteLine(personne2.compare(personne4));
service1.afficher();

Console.WriteLine(service1.plusAge());




