using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_projet_agiles.ClassMetiers
{
    class Tache
    {
        public static ArrayList CollClassTache = new ArrayList();

        private int _idTache;
        private string _intituleTache;
        private DateTime _dateDebutPrevue;
        private DateTime _dateDebutReelle;
        private float _dureePrevue;
        private float _dureeReelle;
        private string _etat;
        private List<Collaborateur> collObjetTache;

        public Tache(int idTache, string intituleTache, DateTime dateDebutPrevue, DateTime dateDebutReelle, float dureePrevue, float dureeReelle, string etat)
        {
            _idTache = idTache;
            _intituleTache = intituleTache;
            _dateDebutPrevue = dateDebutPrevue;
            _dateDebutReelle = dateDebutReelle;
            _dureePrevue = dureePrevue;
            _dureeReelle = dureeReelle;
            _etat = etat;

            CollObjetTache = new List<Collaborateur>();
            Tache.CollClassTache.Add(this);
        }

        public int IdTache { get => _idTache; set => _idTache = value; }
        public string IntituleTache { get => _intituleTache; set => _intituleTache = value; }
        public DateTime DateDebutPrevue { get => _dateDebutPrevue; set => _dateDebutPrevue = value; }
        public DateTime DateDebutReelle { get => _dateDebutReelle; set => _dateDebutReelle = value; }
        public float DureePrevue { get => _dureePrevue; set => _dureePrevue = value; }
        public float DureeReelle { get => _dureeReelle; set => _dureeReelle = value; }
        public string Etat { get => _etat; set => _etat = value; }
        public List<Collaborateur> CollObjetTache { get => collObjetTache; set => collObjetTache = value; }
    }
}
