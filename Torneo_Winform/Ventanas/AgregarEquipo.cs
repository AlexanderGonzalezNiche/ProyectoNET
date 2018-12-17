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
    public partial class AgregarEquipo : Form
    {
        Fachada fac = new Fachada();
        private VOEquipo equipo;
        public List<VOEquipo> listaEquipos { get; set; }

        public AgregarEquipo()
        {
            InitializeComponent();
            this.ActualizarListas();
        }

        internal void ActualizarListas()
        {
            this.listaEquipos = fac.DevolverEquipos().ToList();
            this.listBoxEquipos.DataSource = this.listaEquipos.OrderBy(vItem => vItem.Nombre).ToList();
            this.listBoxEquipos.DisplayMember = "Nombre";
            this.listBoxEquipos.ValueMember = "Id";
        }

        private void LblIDTorneo_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAño_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (this.textBoxID.Text != string.Empty && this.textBoxNombre.Text != string.Empty && this.textBoxCiudad.Text != string.Empty && this.textBoxDT.Text != string.Empty)
            {
                int idEq = int.Parse(this.textBoxID.Text);
                string nomEq = this.textBoxNombre.Text;
                string ciuEq = this.textBoxCiudad.Text;
                string DTEq = this.textBoxDT.Text;

                if (fac.ExistenEquipos())
                {
                    if (!fac.ExisteEquipo(idEq))
                    {
                        this.CrearEquipo(idEq, nomEq, ciuEq, DTEq);

                    }
                    else
                    {
                        MessageBox.Show("El Equipo ya existe en el sistema", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    this.CrearEquipo(idEq, nomEq, ciuEq, DTEq);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos obligatorios (*) deben tener datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CrearEquipo(int id, string nombre, string ciudad, string DT)
        {
            this.equipo = new VOEquipo();
            this.equipo.Id = id;
            this.equipo.Nombre = nombre;
            this.equipo.Ciudad = ciudad;
            this.equipo.DT = DT;
            this.equipo.Puntos = 0;
            bool alta = fac.AltaEquipo(this.equipo);
            if (alta)
            {
                MessageBox.Show("Equipo creado con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (this.listBoxEquipos.SelectedItem != null)
            {
                DialogResult vResult = MessageBox.Show("¿Seguro que desea eliminar el equipo \"" + (this.listBoxEquipos.SelectedItem as VOEquipo).Nombre + "\"? ¡Recuerde que al hacerlo, se eliminarán todos los datos asociados al mismo!", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (vResult == DialogResult.Yes)
                {
                    if (fac.EliminarEquipo(this.listBoxEquipos.SelectedItem as VOEquipo))
                    {
                        this.ActualizarListas();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error, intente nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione el equipo que desea eliminar ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
