namespace WindowsFormsApp
{
    partial class AgregarEquipo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxEquipos = new System.Windows.Forms.ListBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.LblIDTorneo = new System.Windows.Forms.Label();
            this.textBoxDT = new System.Windows.Forms.TextBox();
            this.labelDT = new System.Windows.Forms.Label();
            this.textBoxPuntos = new System.Windows.Forms.TextBox();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxEquipos
            // 
            this.listBoxEquipos.FormattingEnabled = true;
            this.listBoxEquipos.Location = new System.Drawing.Point(382, 64);
            this.listBoxEquipos.Name = "listBoxEquipos";
            this.listBoxEquipos.Size = new System.Drawing.Size(254, 264);
            this.listBoxEquipos.TabIndex = 0;
            this.listBoxEquipos.SelectedIndexChanged += new System.EventHandler(this.listBoxEquipos_SelectedIndexChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(118, 76);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 5;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(118, 129);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCiudad.TabIndex = 7;
            this.textBoxCiudad.TextChanged += new System.EventHandler(this.textBoxAño_TextChanged);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(118, 29);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 3;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(12, 136);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(47, 13);
            this.labelCiudad.TabIndex = 8;
            this.labelCiudad.Text = "Ciudad *";
            this.labelCiudad.Click += new System.EventHandler(this.labelFecha_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 83);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(51, 13);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre *";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // LblIDTorneo
            // 
            this.LblIDTorneo.AutoSize = true;
            this.LblIDTorneo.Location = new System.Drawing.Point(12, 36);
            this.LblIDTorneo.Name = "LblIDTorneo";
            this.LblIDTorneo.Size = new System.Drawing.Size(61, 13);
            this.LblIDTorneo.TabIndex = 4;
            this.LblIDTorneo.Text = "ID Equipo *";
            this.LblIDTorneo.Click += new System.EventHandler(this.LblIDTorneo_Click);
            // 
            // textBoxDT
            // 
            this.textBoxDT.Location = new System.Drawing.Point(118, 184);
            this.textBoxDT.Name = "textBoxDT";
            this.textBoxDT.Size = new System.Drawing.Size(100, 20);
            this.textBoxDT.TabIndex = 9;
            // 
            // labelDT
            // 
            this.labelDT.AutoSize = true;
            this.labelDT.Location = new System.Drawing.Point(12, 191);
            this.labelDT.Name = "labelDT";
            this.labelDT.Size = new System.Drawing.Size(29, 13);
            this.labelDT.TabIndex = 10;
            this.labelDT.Text = "DT *";
            // 
            // textBoxPuntos
            // 
            this.textBoxPuntos.Location = new System.Drawing.Point(118, 242);
            this.textBoxPuntos.Name = "textBoxPuntos";
            this.textBoxPuntos.Size = new System.Drawing.Size(100, 20);
            this.textBoxPuntos.TabIndex = 11;
            // 
            // labelPuntos
            // 
            this.labelPuntos.AutoSize = true;
            this.labelPuntos.Location = new System.Drawing.Point(12, 249);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(40, 13);
            this.labelPuntos.TabIndex = 12;
            this.labelPuntos.Text = "Puntos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Equipos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(275, 78);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 14;
            this.buttonAgregar.Text = "Agregar >>";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(275, 213);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 15;
            this.buttonEliminar.Text = "<< Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // AgregarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(722, 340);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPuntos);
            this.Controls.Add(this.labelPuntos);
            this.Controls.Add(this.textBoxDT);
            this.Controls.Add(this.labelDT);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.LblIDTorneo);
            this.Controls.Add(this.listBoxEquipos);
            this.Name = "AgregarEquipo";
            this.Text = "Ingresar Equipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEquipos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label LblIDTorneo;
        private System.Windows.Forms.TextBox textBoxDT;
        private System.Windows.Forms.Label labelDT;
        private System.Windows.Forms.TextBox textBoxPuntos;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}