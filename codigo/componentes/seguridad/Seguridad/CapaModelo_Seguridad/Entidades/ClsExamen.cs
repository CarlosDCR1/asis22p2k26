
using System;
using System.Collections.Generic;
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
 * Aqui en esta clase se encuentran los get y set necesarios y 
 * utilizados en la vista del formulario
 * ===================================================================
*/

namespace CapaModelo_Seguridad.Entidades
{
    public class ClsExamen
    {
        public int Idfacultad { get; set; }
        public string nombrefacultad { get; set; }


        public string Estado { get; set; }
        public string Codigo { get; set; }

    }
}