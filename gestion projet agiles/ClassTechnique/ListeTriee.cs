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

        }
        public static void ajouteDernier(Object o)
        {
            CollClassListeTriee.Add(o);
        }
        public static ArrayList retournePremier()
        {
            return ;
        }
        public static object retourneDernier()
        {
            return CollClassListeTriee[NbElements() - 1];
        }
        public static void suprimePremier()
        {
            
        }
        public static void suprimeDernier()
        {

            CollClassListeTriee.RemoveAt(NbElements() - 1);
        }
        public static int NbElements()
        {
            return 1;
        }

        #endregion
    }
}
