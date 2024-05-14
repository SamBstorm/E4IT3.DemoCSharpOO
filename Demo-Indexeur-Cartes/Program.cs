namespace Demo_Indexeur_Cartes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.InitDeck();

            //set private, donc plus utilisable
            //deck[0] = new Carte() { couleur = Couleur.Pique, valeur = Valeur.AS };

            for (int i = 0; i < 52; i++)
            {
                Carte c = deck[i];
                Console.WriteLine($"{c.valeur} de {c.couleur}");
            }

            Carte selected = deck[Couleur.Carreau, Valeur.trois];

            selected.couleur = Couleur.Pique;
            selected.valeur = Valeur.AS;

            for (int i = 0; i < 52; i++)
            {
                Carte c = deck[i];
                Console.WriteLine($"{c.valeur} de {c.couleur}");
            }
        }
    }
}
