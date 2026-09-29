using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_Seguridad.Contratos;
using System.Data.Odbc;
using CapaModelo_Seguridad.Entidades;
using CapaModelo_Seguridad.Repositorios;

namespace CapaControlador_Seguridad
{
    public class ClsModeloExamen
    {
        private int _Idfacultad;
        private string _Codigo;
        private string _nombrefacultad;

        private string _Estado;

        private ClsRepositorioExamen _RepositorioExamen;

        private List<ClsModeloExamen> _ListaVideo;

        public int Idfacultad { get => _Idfacultad; set => _Idfacultad = value; }
        public string nombrefacultad { get => _nombrefacultad; set => _nombrefacultad = value; }

        public string Estado_facultad { get => _Estado; set => _Estado = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }


        public ClsModeloExamen()
        {
            _RepositorioExamen = new ClsRepositorioExamen();
        }

        public List<ClsModeloExamen> SeguridadMetObtenerTodos()
        {
            var ResultadoConsulta = _RepositorioExamen.SeguridadMetObtenerTodos();
            _ListaVideo = new List<ClsModeloExamen>();
            foreach (ClsExamen Item in ResultadoConsulta)
            {
                _ListaVideo.Add(new ClsModeloExamen
                {
                    _Idfacultad = Item.Idfacultad,
                    _nombrefacultad = Item.nombrefacultad,
                    _Estado = Item.Estado,
                    _Codigo = Item.Codigo,
                    
                });
            }
            return _ListaVideo;
        }
    }
}
