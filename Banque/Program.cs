using Banque;

var ali = new Compte(1, "Ali", 1000);
var omar = new Compte(2, "Omar", 500);
var fatima = new Compte(3, "Fatima", 0);

Console.WriteLine("--- Au départ ---");
ali.Afficher();
omar.Afficher();
fatima.Afficher();

Console.WriteLine("\n--- Opérations ---");
ali.Crediter(200);         // 1200
omar.Debiter(150);          // 350
ali.Virement(fatima, 300);     // 900, 300
fatima.Virement(omar, 100);     // 200, 450
omar.Debiter(10000);        // refusé : solde insuffisant
ali.Crediter(-50);         // refusé : montant invalide

Console.WriteLine("\n--- À la fin ---");
ali.Afficher();
omar.Afficher();
fatima.Afficher();