namespace Demo_SurchargeOperateur_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] fruits = new Fruit[3];

            for (int i = 0; i < fruits.Length; i++)
            {
                fruits[i] = new Fruit();
            }

            Panier recolte = (Panier)fruits;

            Fruit[] fruitsDeLaRecolte = recolte;
        }
    }
}
