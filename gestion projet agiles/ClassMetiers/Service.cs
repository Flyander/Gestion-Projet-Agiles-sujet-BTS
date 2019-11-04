using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_projet_agiles.ClassMetiers
{
    class Service
    {
        #region Attributs

        public static ArrayList CollClassServices = new ArrayList();

        private int _idService;
        private string _nomService;
        private Collaborateur _leResponsable;

        #endregion

        #region Constructeur

        public Service(int idService, string nomService, Collaborateur leResponsable)
        {
            IdService = idService;
            NomService = nomService;
            LeResponsable = leResponsable;

            Service.CollClassServices.Add(this);
        }

        #endregion

        #region Getters/Setters

        public int IdService { get => _idService; set => _idService = value; }
        public string NomService { get => _nomService; set => _nomService = value; }
        internal Collaborateur LeResponsable { get => _leResponsable; set => _leResponsable = value; }

        #endregion

        #region Méthodes




        #endregion
    }
}
