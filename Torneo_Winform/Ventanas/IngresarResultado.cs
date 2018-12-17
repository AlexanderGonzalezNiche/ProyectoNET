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
    public partial class IngresarResultado : Form
    {
        Fachada fac = new Fachada();
        public List<VOPartido> listaPartidos { get; set; }

        public IngresarResultado()
        {
            InitializeComponent();
            this.ActualizarListas();
        }

        internal void ActualizarListas()
        {
            listaPartidos = fac.DevolverPartidos();
            cbxPartidos.DataSource = listaPartidos;

            this.cbxPartidos.ValueMember = this.cbxPartidos.ValueMember = "Id";
            this.cbxPartidos.DisplayMember = this.cbxPartidos.DisplayMember = "Id";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void IngresarResultado_Load(object sender, EventArgs e)
        {
             
         }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (this.texId.Text != string.Empty && this.textGolEqui1.Text != string.Empty && this.textGolEqui2.Text != string.Empty && this.cbxPartidos.SelectedItem.ToString() != string.Empty)
            {
                int idResult = int.Parse(this.texId.Text);
                int idPartido = int.Parse(this.cbxPartidos.SelectedItem.ToString());
                int golesEq1 = int.Parse(this.textGolEqui1.Text);
                int golesEq2 = int.Parse(this.textGolEqui2.Text);
                string clima = this.textClima.Text;
                string desc = this.richTextBoxDescripcion.Text;
               
                VOResultado res = new VOResultado();
                res.Id = idResult;
                res.GolesEquipo1 = golesEq1;
                res.GolesEquipo2 = golesEq2;
                res.Clima = clima;
                res.Descripcion = desc;

                bool agregado = fac.AgregarResultadoAPartido(res, idPartido);

                if(agregado)
                {
                    MessageBox.Show("Se ha ingresado el resultado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error al ingresar resultado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
