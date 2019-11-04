using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_projet_agiles.ClassTechnique
{
    static class ListeTriee
    {
        #region Attributs
        public static ArrayList CollClassListeTriee = new ArrayList();
        #endregion

        #region methode technique
        public static void ajoutePremier(Object o)
        {
            CollClassListeTriee.Insert(0, o);
        }
        public static void ajouteDernier(Object o)
        {

        }
        public static object retournePremier()
        {
            return CollClassListeTriee[0];
        }
        public static ArrayList retourneDernier()
        {
            return ;
        }
        public static void suprimePremier()
        {
            CollClassListeTriee.RemoveAt(0);
        }
        public static void suprimeDernier()
        {

        }
        public static int NbElements()
        {
            return CollClassListeTriee.Count;
        }

        #endregion
    }
}
