
using CapaModelo_Seguridad.Contratos;
using CapaModelo_Seguridad.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * ==================================================================
 * Área : Seguridad
 * Autor : Carlos David Calderón Ramirez
 * Carné : 9959-23-848
 * Fecha : 22/09/2026
 * ==================================================================
 * Propósito :
 * Aqui es esta clase se encuentran los querys utilizados para
 * realizar las diferentes acciones como insertar, seleccionar,
 * modificar y eliminar junto con el metodo para cada accion.
 * ===================================================================
*/

namespace CapaModelo_Seguridad.Repositorios
{
    public class ClsRepositorioExamen : ClsSentencias, IRepositorioExamen
    {
        private string _SelectAll;

        public ClsRepositorioExamen()
        {
            _SelectAll = "SELECT * FROM tblfacultades";
        }

        public IEnumerable<ClsExamen> SeguridadMetObtenerTodos()
        {
            var ListaVideos = new List<ClsExamen>();
            var TablaDatos = SeguridadMetEjecucionConsulta(_SelectAll, CommandType.Text);
            foreach (DataRow Fila in TablaDatos.Rows)
            {
                var Video = new ClsExamen();
                Video.Idfacultad = Convert.ToInt32(Fila[0]);
                Video.nombrefacultad = Fila[1].ToString();
      
                Video.Estado = Fila[3].ToString();
                Video.Codigo = Fila[2].ToString();
               
                ListaVideos.Add(Video);
            }
            TablaDatos.Clear();
            TablaDatos = null;
            return ListaVideos;
        }
    }
}
