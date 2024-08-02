using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.Polymorphisme
{
    public class PolyTest
    {
        //Il y'à plusieurs façon d'utiliser le polymorphisme

        //ad-hoc (mise en place du polymorphisme au niveau des méthodes et utilisation de GetType)

        public static void Buy(object obj)
        {
            //Vérifier le type de l'objet
            
            if (obj.GetType().Equals(typeof(Table)))
            {
                Table t = (Table)obj;
                t.Deplier();
                t.Plier();
            }
        }

        //Polymorphisme par sous typage
        public static void Buy2(IPliable pliable)
        {
            //pas besoin de vérifier le type
            pliable.Deplier();
            pliable.Plier();
        }


        //Polymorphisme par type paramétrique
        public static void Buy<T>(T obj) where T : IPliable
        {
            //pas besoin de vérifier le type

            obj.Deplier();
            obj.Plier();
        }

        public static void Buy(Table table)
        {

        }

        public static void Buy(Chaise chaise)
        {

        }
    }
}
