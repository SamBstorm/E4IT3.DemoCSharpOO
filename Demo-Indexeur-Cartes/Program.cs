namespace Demo_Indexeur_Cartes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carte[] deck = new Carte[52];

            int i = 0;
            foreach (Couleur color in Enum.GetValues<Couleur>())
            {
                foreach (Valeur value in Enum.GetValues<Valeur>())
                {
                    deck[i] = new Carte() { valeur = value, couleur = color };
                    i++;
                }
            }

            foreach (Carte c in deck)
            {
                Console.WriteLine($"{c.valeur} de {c.couleur}");
            }
        }
    }
}
