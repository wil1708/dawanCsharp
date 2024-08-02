using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDLL.DesignPattern.Creation.Factory
{
    public class ShapeFactory
    {
        //Rôle de cette classe est de construire de nouvelles formes géométriques
        //Ne respecte pas le Open/Close

        public static IShape CreateShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            switch (shapeType)
            {
                case "cercle":
                    return new Cercle();
                case "rectangle":
                    return new Rectangle();
                default:
                    break;
            }

            return null;
        }

        //option 2:
       public static T CreateShape<T>(Type type, params object[] parametres) where T : IShape
        {
            return (T)Activator.CreateInstance(type, parametres);
        }

        //option 3:
        public static IShape CreateShape(IShape shape, params object[] parametres) 
        {
            Type type = shape.GetType();
            return (IShape)Activator.CreateInstance(type, parametres);

        }

        //public static int SommeNumbers(int x, int y)
        //{
        //    return x + y;
        //}

        //public static int SommeNumbers(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        //public static int SommeNumbers(int x, int y, int z, int a)
        //{
        //    return x + y + z + a;
        //}

        //params: un tableau avec un nombre variable de paramètres
        public static int SommeNumbers(params int[] tab)
        {
            return 1;
        }

    }
}
