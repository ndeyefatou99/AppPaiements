using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        
        CarteCredit carte_n_1 = new CarteCredit(150, "Paiement en ligne", 123456789);
        CarteCredit carte_n_2 = new CarteCredit(200, "Paiement resto", 987654321);
        CarteCredit carte_n_3 = new CarteCredit(300, "Paiement vaisselles", 456789123);

        carte_n_1.AfficherDetails();
        carte_n_2.AfficherDetails();
        carte_n_3.AfficherDetails();

    }
}