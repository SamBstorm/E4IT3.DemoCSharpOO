using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Encapsulation
{
    internal class Personne
    {
        public DateTime DateNaissance { get; set; }

        //Propriété Auto-calculé : Dépend d'une valeur externe et retourne le résultat d'un calcul
        public int Age { get
            {
                return DateTime.Now.Year - DateNaissance.Year;
            } 
        }
    }
}
