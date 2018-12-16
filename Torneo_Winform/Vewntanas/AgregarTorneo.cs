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
        private VOTorneo torneo;

        public AgregarTorneo()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if(this.textBoxID.Text != string.Empty && this.textBoxAño.Text != string.Empty && this.textBoxNombre.Text != string.Empty)
            {
                if (this.torneo == null)//ALTA
                {
                    this.torneo = new VOTorneo();
                    this.torneo.Id = this.textBoxID.Text;
                    this.torneo.Nombre = this.textBoxNombre.Text;
                    this.torneo.Año = this.textBoxAño.Text;
                    bool alta = fac.AltaTorneo(this.torneo);

                    if(alta)
                    {
                        MessageBox.Show("Torneo creado con exito", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    MessageBox.Show("Ya hay un torneo en juego, finalicelo si quiere comenzar uno nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos obligatorios (*) deben tener datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
