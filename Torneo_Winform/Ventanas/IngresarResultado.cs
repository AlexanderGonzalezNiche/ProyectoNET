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
        public IngresarResultado()
        {
            InitializeComponent();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void IngresarResultado_Load(object sender, EventArgs e)
        {
            //Muestro datos
            
            dataGridView1.DataSource = this.fac.DevolverPartidos();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (this.texId.Text != string.Empty && this.textGolEqui1.Text != string.Empty && this.textGolEqui2.Text != string.Empty)
            {
                int idResult = int.Parse(this.texId.Text);
                //id torneooo
                int golesEq1 = int.Parse(this.textGolEqui1.Text);
                int golesEq2 = int.Parse(this.textGolEqui2.Text);
                string clima = this.textClima.Text;
                string desc = this.textDescrip.Text;
            }

            //VOResultado vO = new VOResultado(Convert.ToInt32(texId.Text), Convert.ToInt32(texIDPartido.Text), Convert.ToInt32(textGolEqui1.Text), Convert.ToInt32(textGolEqui2.Text), Convert.ToString(textClima.Text), Convert.ToString(textDescrip.Text));
            //vO.Partido.
            //Fac.AgregarResultadoAPartido()
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
