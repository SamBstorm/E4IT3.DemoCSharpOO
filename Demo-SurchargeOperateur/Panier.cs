using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SurchargeOperateur
{
    internal class Panier
    {
        private List<Fruit> _fruits = new List<Fruit>();

        public int Count
        {
            get { return _fruits.Count; }
        }

        public void AjouterFruit(Fruit fruit)
        {
            _fruits.Add(fruit);
        }

        public static Panier operator + (Panier left, Panier right)
        {
            Panier result = new Panier();

            foreach (Fruit f in left._fruits)
            {
                result.AjouterFruit(f);
            }

            foreach (Fruit f in right._fruits)
            {
                result.AjouterFruit(f);
            }

            return result;
        }

        public static Panier operator + (Panier left, Fruit right)
        {
            left.AjouterFruit(right);
            return left;
        }

        public static bool operator == (Panier left, Panier right)
        {
            return left.Count == right.Count;
        }

        public static bool operator != (Panier left, Panier right) {
            return !(left == right);
        }
    }
}
