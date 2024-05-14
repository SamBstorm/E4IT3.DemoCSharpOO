namespace Demo_SurchargeOperateur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit pomme01 = new Fruit();
            Fruit pomme02 = new Fruit();
            Fruit pomme03 = new Fruit();

            Panier panier01 = new Panier();
            panier01.AjouterFruit(pomme01);
            panier01.AjouterFruit(pomme02);
            panier01.AjouterFruit(pomme03);
            Console.WriteLine($"Le premier panier contient {panier01.Count} fruit(s).");

            Fruit orange01 = new Fruit();
            Fruit orange02 = new Fruit();

            Panier panier02 = new Panier();
            panier02.AjouterFruit(orange01);
            panier02.AjouterFruit(orange02);
            Console.WriteLine($"Le second panier contient {panier02.Count} fruit(s).");

            Panier recolte = panier01 + panier02;

            Console.WriteLine($"La récolte total contient {recolte.Count} fruit(s).");

            recolte = recolte + new Fruit();
            Console.WriteLine($"La récolte total contient {recolte.Count} fruit(s).");
        }
    }
}
