using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_projet_agiles.ClassMetiers
{
    class Lot
    {
        #region Attributs
        public static ArrayList CollClassLot = new ArrayList();

        private int _idLot;
        private DateTime _dateDebutPrevue;
        private DateTime _dateDebutReelle;
        private string _etat;
        private Projet _leProjet;
        private ArrayList collObjetTache;
        #endregion

        #region Constructeurs
        public Lot(int idLot, DateTime dateDebutPrevue, DateTime dateDebutReelle, string etat, Projet projet)
        {
            _idLot = idLot;
            _dateDebutPrevue = dateDebutPrevue;
            _dateDebutReelle = dateDebutReelle;
            _etat = etat;
            _leProjet = projet;

            CollObjetTache = new ArrayList();
            Lot.CollClassLot.Add(this);

        }
        #endregion

        #region Getters/Setters
        public int IdLot { get => _idLot; set => _idLot = value; }
        public DateTime DateDebutPrevue { get => _dateDebutPrevue; set => _dateDebutPrevue = value; }
        public DateTime DateDebutReelle { get => _dateDebutReelle; set => _dateDebutReelle = value; }
        public string Etat { get => _etat; set => _etat = value; }
        public ArrayList CollObjetTache { get => collObjetTache; set => collObjetTache = value; }
        public Projet LeProjet { get => _leProjet; set => _leProjet = value; }
        #endregion
    }
}
