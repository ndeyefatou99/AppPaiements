using AppPaiements;

internal class Program
{
    private static void Main(string[] args)
    {
        
        CarteCredit carte_n_1 = new CarteCredit(150, "Paiement en ligne", 123456789);
        CarteCredit carte_n_2 = new CarteCredit(200, "Paiement resto", 987654321);
        CarteCredit carte_n_3 = new CarteCredit(300, "Paiement vaisselles", 456789123);

        //instance pour la classe paypal

        Paypal payer1 = new Paypal(15000, "Frais Boreal", "fatoudiopcodou@gmail.com");
        Paypal payer2 = new Paypal(900, "Payer loyer", "ndeyefatou.diop@monboreal.ca");

        Utilisateur user1 = new Utilisateur("Fatou");

        carte_n_1.AfficherDetails();
        carte_n_2.AfficherDetails();
        carte_n_3.AfficherDetails();

        payer1.AfficherDetails();
        payer2.AfficherDetails();

        user1.AjouterPaiement(carte_n_1);
        user1.AjouterPaiement(carte_n_2);
        user1.AjouterPaiement(carte_n_3);
        
        user1.AjouterPaiement(payer1);
        user1.AjouterPaiement(payer2);

        user1.AfficherInfos();


    }
}