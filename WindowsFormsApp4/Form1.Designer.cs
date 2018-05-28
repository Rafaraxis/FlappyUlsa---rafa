namespace WindowsFormsApp4
{
    partial class juego
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
            this.components = new System.ComponentModel.Container();
            this.tuboarriba = new System.Windows.Forms.PictureBox();
            this.tuboabajo = new System.Windows.Forms.PictureBox();
            this.jugador = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.puntios = new System.Windows.Forms.Label();
            this.reprobado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tuboarriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reprobado)).BeginInit();
            this.SuspendLayout();
            // 
            // tuboarriba
            // 
            this.tuboarriba.BackColor = System.Drawing.Color.Transparent;
            this.tuboarriba.Image = global::WindowsFormsApp4.Properties.Resources.tubo2;
            this.tuboarriba.Location = new System.Drawing.Point(139, -84);
            this.tuboarriba.Name = "tuboarriba";
            this.tuboarriba.Size = new System.Drawing.Size(102, 258);
            this.tuboarriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tuboarriba.TabIndex = 0;
            this.tuboarriba.TabStop = false;
            // 
            // tuboabajo
            // 
            this.tuboabajo.BackColor = System.Drawing.Color.Transparent;
            this.tuboabajo.Image = global::WindowsFormsApp4.Properties.Resources.tubo1;
            this.tuboabajo.Location = new System.Drawing.Point(134, 319);
            this.tuboabajo.Name = "tuboabajo";
            this.tuboabajo.Size = new System.Drawing.Size(107, 311);
            this.tuboabajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tuboabajo.TabIndex = 1;
            this.tuboabajo.TabStop = false;
            // 
            // jugador
            // 
            this.jugador.Image = global::WindowsFormsApp4.Properties.Resources.tenorio;
            this.jugador.Location = new System.Drawing.Point(26, 217);
            this.jugador.Name = "jugador";
            this.jugador.Size = new System.Drawing.Size(64, 74);
            this.jugador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jugador.TabIndex = 2;
            this.jugador.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.Form1_Load);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            // 
            // puntios
            // 
            this.puntios.AutoSize = true;
            this.puntios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntios.Location = new System.Drawing.Point(48, 198);
            this.puntios.Name = "puntios";
            this.puntios.Size = new System.Drawing.Size(15, 16);
            this.puntios.TabIndex = 3;
            this.puntios.Text = "0";
            // 
            // reprobado
            // 
            this.reprobado.Image = global::WindowsFormsApp4.Properties.Resources.r;
            this.reprobado.Location = new System.Drawing.Point(0, 429);
            this.reprobado.Name = "reprobado";
            this.reprobado.Size = new System.Drawing.Size(291, 42);
            this.reprobado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.reprobado.TabIndex = 4;
            this.reprobado.TabStop = false;
            // 
            // juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.galeria_inicio_grande1;
            this.ClientSize = new System.Drawing.Size(292, 469);
            this.Controls.Add(this.reprobado);
            this.Controls.Add(this.puntios);
            this.Controls.Add(this.jugador);
            this.Controls.Add(this.tuboabajo);
            this.Controls.Add(this.tuboarriba);
            this.Name = "juego";
            this.Text = "Flappy ULSA";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.juego_Keypress);
            ((System.ComponentModel.ISupportInitialize)(this.tuboarriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reprobado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tuboarriba;
        private System.Windows.Forms.PictureBox tuboabajo;
        private System.Windows.Forms.PictureBox jugador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label puntios;
        private System.Windows.Forms.PictureBox reprobado;
    }
}

