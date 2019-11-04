using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_projet_agiles.ClassMetiers
{
    class Projet
    {
        #region attribut

        private static ArrayList collClassProjet = new ArrayList();
        private int idProjet;
        private string IntituleProjet;
        private DateTime DateDebutPrevue;
        private DateTime DateDebutReelle;
        private DateTime DateFinPrevue;
        private DateTime DateFinReelle;
        private string etat;
        private Collaborateur leResponsable;
        private ArrayList lesTachesRestantARealiser;
        private ArrayList lesLots;

        #endregion

        #region construct

        public Projet(int idProjet, string intituleProjet, DateTime dateDebutPrevue, DateTime dateDebutReelle, DateTime dateFinPrevue, DateTime dateFinReelle, string etat)
        {
            this.IdProjet = idProjet;
            IntituleProjet1 = intituleProjet;
            DateDebutPrevue1 = dateDebutPrevue;
            DateDebutReelle1 = dateDebutReelle;
            DateFinPrevue1 = dateFinPrevue;
            DateFinReelle1 = dateFinReelle;
            this.Etat = etat;
        }

        #endregion

        #region getset

        public int IdProjet { get => idProjet; set => idProjet = value; }
        public string IntituleProjet1 { get => IntituleProjet; set => IntituleProjet = value; }
        public DateTime DateDebutPrevue1 { get => DateDebutPrevue; set => DateDebutPrevue = value; }
        public DateTime DateDebutReelle1 { get => DateDebutReelle; set => DateDebutReelle = value; }
        public DateTime DateFinPrevue1 { get => DateFinPrevue; set => DateFinPrevue = value; }
        public DateTime DateFinReelle1 { get => DateFinReelle; set => DateFinReelle = value; }
        public string Etat { get => etat; set => etat = value; }

        #endregion

        #region methodes

        public int pourcentageAvancement()
        {
            return 0;
        }
        #endregion
    }
}
