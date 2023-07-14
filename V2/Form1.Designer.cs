namespace V2
{
    partial class Form1
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
            this.btnAgregarCompetidor = new System.Windows.Forms.Button();
            this.lstbParticipantes = new System.Windows.Forms.ListBox();
            this.gbInscripcion = new System.Windows.Forms.GroupBox();
            this.btnEmpezarTorneo = new System.Windows.Forms.Button();
            this.lbRonda = new System.Windows.Forms.Label();
            this.lbPuntos = new System.Windows.Forms.ListBox();
            this.gbListaTorneo = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbInscripcion.SuspendLayout();
            this.gbListaTorneo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarCompetidor
            // 
            this.btnAgregarCompetidor.Location = new System.Drawing.Point(9, 451);
            this.btnAgregarCompetidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarCompetidor.Name = "btnAgregarCompetidor";
            this.btnAgregarCompetidor.Size = new System.Drawing.Size(346, 62);
            this.btnAgregarCompetidor.TabIndex = 0;
            this.btnAgregarCompetidor.Text = "Agregar competidor";
            this.btnAgregarCompetidor.UseVisualStyleBackColor = true;
            this.btnAgregarCompetidor.Click += new System.EventHandler(this.btnAgregarCompetidor_Click);
            // 
            // lstbParticipantes
            // 
            this.lstbParticipantes.FormattingEnabled = true;
            this.lstbParticipantes.ItemHeight = 20;
            this.lstbParticipantes.Location = new System.Drawing.Point(9, 29);
            this.lstbParticipantes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstbParticipantes.Name = "lstbParticipantes";
            this.lstbParticipantes.Size = new System.Drawing.Size(344, 404);
            this.lstbParticipantes.TabIndex = 1;
            // 
            // gbInscripcion
            // 
            this.gbInscripcion.Controls.Add(this.btnEmpezarTorneo);
            this.gbInscripcion.Controls.Add(this.lstbParticipantes);
            this.gbInscripcion.Controls.Add(this.btnAgregarCompetidor);
            this.gbInscripcion.Location = new System.Drawing.Point(18, 89);
            this.gbInscripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInscripcion.Name = "gbInscripcion";
            this.gbInscripcion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbInscripcion.Size = new System.Drawing.Size(364, 592);
            this.gbInscripcion.TabIndex = 4;
            this.gbInscripcion.TabStop = false;
            this.gbInscripcion.Text = "Lista de Competidores";
            // 
            // btnEmpezarTorneo
            // 
            this.btnEmpezarTorneo.Enabled = false;
            this.btnEmpezarTorneo.Location = new System.Drawing.Point(9, 522);
            this.btnEmpezarTorneo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmpezarTorneo.Name = "btnEmpezarTorneo";
            this.btnEmpezarTorneo.Size = new System.Drawing.Size(346, 62);
            this.btnEmpezarTorneo.TabIndex = 2;
            this.btnEmpezarTorneo.Text = "Empezar torneo";
            this.btnEmpezarTorneo.UseVisualStyleBackColor = true;
            this.btnEmpezarTorneo.Click += new System.EventHandler(this.btnEmpezarTorneo_Click);
            // 
            // lbRonda
            // 
            this.lbRonda.AutoSize = true;
            this.lbRonda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRonda.Location = new System.Drawing.Point(18, 14);
            this.lbRonda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRonda.Name = "lbRonda";
            this.lbRonda.Size = new System.Drawing.Size(325, 46);
            this.lbRonda.TabIndex = 2;
            this.lbRonda.Text = "Rondas totales: ";
            // 
            // lbPuntos
            // 
            this.lbPuntos.FormattingEnabled = true;
            this.lbPuntos.ItemHeight = 20;
            this.lbPuntos.Location = new System.Drawing.Point(9, 29);
            this.lbPuntos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(326, 404);
            this.lbPuntos.TabIndex = 5;
            this.lbPuntos.SelectedIndexChanged += new System.EventHandler(this.lbPuntos_SelectedIndexChanged);
            // 
            // gbListaTorneo
            // 
            this.gbListaTorneo.Controls.Add(this.button2);
            this.gbListaTorneo.Controls.Add(this.button1);
            this.gbListaTorneo.Controls.Add(this.lbPuntos);
            this.gbListaTorneo.Enabled = false;
            this.gbListaTorneo.Location = new System.Drawing.Point(420, 89);
            this.gbListaTorneo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListaTorneo.Name = "gbListaTorneo";
            this.gbListaTorneo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbListaTorneo.Size = new System.Drawing.Size(346, 592);
            this.gbListaTorneo.TabIndex = 6;
            this.gbListaTorneo.TabStop = false;
            this.gbListaTorneo.Text = "Ronda actual: ";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(9, 522);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(326, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "Siguiente Ronda";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(9, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 62);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cargar Puntos a";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 691);
            this.Controls.Add(this.gbListaTorneo);
            this.Controls.Add(this.gbInscripcion);
            this.Controls.Add(this.lbRonda);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbInscripcion.ResumeLayout(false);
            this.gbListaTorneo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCompetidor;
        private System.Windows.Forms.ListBox lstbParticipantes;
        private System.Windows.Forms.GroupBox gbInscripcion;
        private System.Windows.Forms.Label lbRonda;
        private System.Windows.Forms.Button btnEmpezarTorneo;
        private System.Windows.Forms.ListBox lbPuntos;
        private System.Windows.Forms.GroupBox gbListaTorneo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

