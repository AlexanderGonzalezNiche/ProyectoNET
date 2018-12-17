namespace WindowsFormsApp1
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarDatosDelTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarPartidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarResultadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDePisicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treminarTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarTorneoToolStripMenuItem,
            this.ingresarDatosDelTorneoToolStripMenuItem,
            this.tablaDePisicionesToolStripMenuItem,
            this.treminarTorneoToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.inicioToolStripMenuItem.Text = "Torneo";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // iniciarTorneoToolStripMenuItem
            // 
            this.iniciarTorneoToolStripMenuItem.Name = "iniciarTorneoToolStripMenuItem";
            this.iniciarTorneoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.iniciarTorneoToolStripMenuItem.Text = "Iniciar Torneo";
            this.iniciarTorneoToolStripMenuItem.Click += new System.EventHandler(this.iniciarTorneoToolStripMenuItem_Click);
            // 
            // ingresarDatosDelTorneoToolStripMenuItem
            // 
            this.ingresarDatosDelTorneoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarEquipoToolStripMenuItem,
            this.ingresarPartidoToolStripMenuItem,
            this.ingresarResultadoToolStripMenuItem});
            this.ingresarDatosDelTorneoToolStripMenuItem.Name = "ingresarDatosDelTorneoToolStripMenuItem";
            this.ingresarDatosDelTorneoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.ingresarDatosDelTorneoToolStripMenuItem.Text = "Ingresar datos del Torneo";
            // 
            // ingresarEquipoToolStripMenuItem
            // 
            this.ingresarEquipoToolStripMenuItem.Name = "ingresarEquipoToolStripMenuItem";
            this.ingresarEquipoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ingresarEquipoToolStripMenuItem.Text = "Ingresar o Eliminar Equipo";
            this.ingresarEquipoToolStripMenuItem.Click += new System.EventHandler(this.ingresarEquipoToolStripMenuItem_Click);
            // 
            // ingresarPartidoToolStripMenuItem
            // 
            this.ingresarPartidoToolStripMenuItem.Name = "ingresarPartidoToolStripMenuItem";
            this.ingresarPartidoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ingresarPartidoToolStripMenuItem.Text = "Ingresar Partido";
            this.ingresarPartidoToolStripMenuItem.Click += new System.EventHandler(this.ingresarPartidoToolStripMenuItem_Click);
            // 
            // ingresarResultadoToolStripMenuItem
            // 
            this.ingresarResultadoToolStripMenuItem.Name = "ingresarResultadoToolStripMenuItem";
            this.ingresarResultadoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ingresarResultadoToolStripMenuItem.Text = "Ingresar Resultado";
            this.ingresarResultadoToolStripMenuItem.Click += new System.EventHandler(this.ingresarResultadoToolStripMenuItem_Click);
            // 
            // tablaDePisicionesToolStripMenuItem
            // 
            this.tablaDePisicionesToolStripMenuItem.Name = "tablaDePisicionesToolStripMenuItem";
            this.tablaDePisicionesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.tablaDePisicionesToolStripMenuItem.Text = "Tabla de posiciones";
            // 
            // treminarTorneoToolStripMenuItem
            // 
            this.treminarTorneoToolStripMenuItem.Name = "treminarTorneoToolStripMenuItem";
            this.treminarTorneoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.treminarTorneoToolStripMenuItem.Text = "Treminar Torneo";
            this.treminarTorneoToolStripMenuItem.Click += new System.EventHandler(this.treminarTorneoToolStripMenuItem_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 480);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "TORNEO";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarTorneoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarDatosDelTorneoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarPartidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaDePisicionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarResultadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treminarTorneoToolStripMenuItem;
    }
}

