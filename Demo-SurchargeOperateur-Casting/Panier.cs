using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SurchargeOperateur_Casting
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

        public static explicit operator Panier(Fruit[] fruits)
        {
            Panier result = new Panier();
            foreach (Fruit f in fruits)
            {
                result.AjouterFruit(f);
            }
            return result;
        }

        public static implicit operator Fruit[](Panier panier)
        {
            return panier._fruits.ToArray();
        }
    }
}
