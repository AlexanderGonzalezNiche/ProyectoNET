using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Torneo_Clases;
using Torneo_Clases.Value_Objects;

namespace WindowsFormsApp
{
    
    public partial class AgregarTorneo : Form
    {
        Fachada fac = new Fachada();
        public AgregarTorneo()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
           
            Torneo_Clases.Logica.Torneo tor = new Torneo_Clases.Logica.Torneo(Convert.ToInt32(textBoxID.Text),Convert.ToString(textBoxNombre.Text),Convert.ToDateTime(textBoxFecha.Text));
            VOTorneo votor = new VOTorneo(tor);
            fac.AltaTorneo(votor);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
