using CapaControlador_Seguridad;
using CapaControlador_Seguridad.Objetos_de_valor;
using CapaVista_Seguridad.frmReportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Seguridad
{
    public partial class FrmMantenimiento2K : Form
    {
        private ClsModeloEmpleado _Empleado = new ClsModeloEmpleado();
        private ClsPermisoAplicacion _MisPermisos;

        private const int ID_MODULO = 4;
        private const int ID_APLICACION = 16;
        public FrmMantenimiento2K()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblfacultades", 4, 16);
        }

        private void BtnReporte(object sender, EventArgs e)
        {
            FormExamen reporte = new FormExamen();
            reporte.Show();
        }

        private void SeguridadBtnAyudaExamen_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/proyectoasis22k26/codigo/componentes/seguridad/Seguridad/CapaVista_Seguridad/Ayudas/Examen.chm");
        }

        
    }
}
