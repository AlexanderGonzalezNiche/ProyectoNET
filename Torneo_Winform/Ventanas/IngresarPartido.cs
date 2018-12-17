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
    public partial class IngresarPartido : Form
    {
        Fachada fac = new Fachada();
        public List<VOEquipo> listaEquiposLocales { get; set; }
        public List<VOEquipo> listaEquiposVisitantes { get; set; }
        private VOPartido partido;
        public IngresarResultado vtnResultado;

        public IngresarPartido()
        {
            InitializeComponent();
            this.dateTimePicker.MinDate = DateTime.Today;
            this.ActualizarListas();
        }

        internal void ActualizarListas()
        {
            listaEquiposLocales = fac.DevolverEquipos();
            listaEquiposVisitantes = fac.DevolverEquipos();

            this.cbxEquipoLocal.DataSource = listaEquiposLocales;
            this.cbxEquipoVisitante.DataSource = listaEquiposVisitantes;

            this.cbxEquipoLocal.ValueMember = this.cbxEquipoVisitante.ValueMember = "Id";
            this.cbxEquipoLocal.DisplayMember = this.cbxEquipoVisitante.ValueMember = "Nombre";
        }

        private void IngresarPartido_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (this.cbxEquipoLocal.SelectedIndex > -1 && this.cbxEquipoVisitante.SelectedIndex > -1 && this.dateTimePicker.Value != null && this.textBoxId.Text != string.Empty)  
            {
                int idEq = int.Parse(this.textBoxId.Text);
                string estadio = this.textBoxEstadio.Text;
                string juez = this.textBoxJuez.Text;
                VOEquipo eq1 = this.cbxEquipoLocal.SelectedItem as VOEquipo;
                VOEquipo eq2 = this.cbxEquipoVisitante.SelectedItem as VOEquipo;
                DateTime fecha = this.dateTimePicker.Value;
                if(fac.ExistenPartidos())
                {
                    if (!fac.ExistePartido(idEq))
                    {
                        this.CrearPartido(idEq, eq1, eq2, juez, estadio, fecha);
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un partido con este id", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    this.CrearPartido(idEq, eq1, eq2, juez, estadio, fecha);
                }           
            }
            else
            {
                MessageBox.Show("Todos los campos obligatorios (*) deben tener datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CrearPartido(int id, VOEquipo eq1, VOEquipo eq2, string juez, string estadio, DateTime fecha)
        {
            this.partido = new VOPartido();
            this.partido.Id = id;
            this.partido.Equipo1 = eq1;
            this.partido.Equipo2 = eq2;
            this.partido.Estadio = estadio;
            this.partido.Juez = juez;
            this.partido.Fecha = fecha;
            bool alta = fac.AltaPartido(this.partido);
            if (alta)
            {
                MessageBox.Show("Partido creado con exito", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hubo un error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
