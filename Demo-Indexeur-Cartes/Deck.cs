using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexeur_Cartes
{
    internal class Deck
    {
        private Carte[] _cartes = new Carte[52];

        public Carte this[int index]
        {
            get {
                if (index < 0 || index > 51) return null;
                return _cartes[index];
            }

            private set
            {
                _cartes[index] = value;
            }
        }

        public Carte this[Couleur couleur, Valeur valeur]
        {
            get
            {
                foreach (Carte c in _cartes)
                {
                    if(c.valeur == valeur && c.couleur == couleur) {
                        return c;
                    }
                }
                return null;
            }
        }

        public void InitDeck()
        {
            int i = 0;
            foreach (Couleur color in Enum.GetValues<Couleur>())
            {
                foreach (Valeur value in Enum.GetValues<Valeur>())
                {
                    _cartes[i] = new Carte() { valeur = value, couleur = color };
                    i++;
                }
            }
        }
    }
}
