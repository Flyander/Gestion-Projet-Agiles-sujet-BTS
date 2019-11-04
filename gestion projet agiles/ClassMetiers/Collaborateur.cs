using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_projet_agiles.ClassMetiers
{
    class Collaborateur
    {
        #region Attributs

        public static ArrayList CollClassCollaborateurs = new ArrayList();

        private int _idCollaborateur;
        private string _nomCollaborateur;
        private Service _leService;

        #endregion

        #region Constructeur

        public Collaborateur(int idCollaborateur, string nomCollaborateur, Service leService)
        {
            IdCollaborateur = idCollaborateur;
            NomCollaborateur = nomCollaborateur;
            LeService = leService;

            Collaborateur.CollClassCollaborateurs.Add(this);
        }

        #endregion

        #region Getters/Setters

        public int IdCollaborateur { get => _idCollaborateur; set => _idCollaborateur = value; }
        public string NomCollaborateur { get => _nomCollaborateur; set => _nomCollaborateur = value; }
        public Service LeService { get => _leService; set => _leService = value; }

        #endregion


        #region Méthodes




        #endregion
    }
}
