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
namespace WindowsFormsApp
{
    public partial class IngresarResultado : Form
    {
        private Fachada Fac;
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
            Fac = new Fachada();
            dataGridView1.DataSource = Fac.DevolverPartidos();
        }
    }
}
