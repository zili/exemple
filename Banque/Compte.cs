namespace Banque;

public class Compte
{
    private int Numero { get; }
    private string Titulaire { get; }
    private decimal Solde { get; set; }

    public Compte(int numero, string titulaire, decimal solde)
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = solde;
    }

    public bool Crediter(decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine($"Crédit refusé : montant invalide ({montant} €).");
            return false;
        }

        Solde += montant;
        return true;
    }

    public bool Debiter(decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine($"Débit refusé : montant invalide ({montant} €).");
            return false;
        }
        if (montant > Solde)
        {
            Console.WriteLine($"Débit refusé : solde insuffisant sur le compte {Numero}.");
            return false;
        }

        Solde -= montant;
        return true;
    }

    public bool Virement(
                Compte destinataire, 
                decimal montant)
    {
        // On ne crédite que si le débit a réussi
        if (!Debiter(montant)) return false;
        destinataire.Crediter(montant);
        return true;
    }

    public void Afficher()
    {
        Console.WriteLine($"Compte {Numero} - {Titulaire} : {Solde} €");
    }
}