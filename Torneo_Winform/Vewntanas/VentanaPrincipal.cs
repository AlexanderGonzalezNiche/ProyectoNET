using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace WindowsFormsApp1
{
    public partial class VentanaPrincipal : Form
    {
        public AgregarTorneo vtnTorneo;
        public IngresarResultado vtnResultado;
       
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
       
        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ingresarResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iniciarTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(vtnTorneo == null)
            {
                this.cerrarVentanas();
                vtnTorneo = new AgregarTorneo();
                vtnTorneo.MdiParent = this;
                vtnTorneo.FormClosed += VtnTorneo_FormClosed;
                vtnTorneo.Show();
            }
            else
            {
                vtnTorneo.Activate();
            
            }
        }

        private void VtnTorneo_FormClosed(object sender, FormClosedEventArgs e)
        {
            vtnTorneo = null;
        }

        private void ingresarResultadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(vtnResultado == null)
            {
                this.cerrarVentanas();
                vtnResultado = new IngresarResultado();
                vtnResultado.MdiParent = this;
                vtnResultado.FormClosed += vtnResultado_FormClosed;
                vtnResultado.Show();
            }
            else
            {
                vtnResultado.Activate();
            }
        }

        private void vtnResultado_FormClosed(object sender, FormClosedEventArgs e)
        {
            vtnResultado = null;
        }

        private void cerrarVentanas()
        {
            if (vtnTorneo != null)
            {
                vtnTorneo.Close();
                vtnTorneo = null;
            }

            if (vtnResultado != null)
            {
                vtnResultado.Close();
                vtnResultado = null;
            }
        
        }
    }
}
