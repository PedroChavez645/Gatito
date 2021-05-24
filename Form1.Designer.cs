
namespace Gatito
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
            this.FichasGato = new System.Windows.Forms.TableLayoutPanel();
            this.PicReiniciar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PicGanador = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblPlayer1 = new System.Windows.Forms.Label();
            this.LblPlayer2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicReiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGanador)).BeginInit();
            this.SuspendLayout();
            // 
            // FichasGato
            // 
            this.FichasGato.BackColor = System.Drawing.Color.Transparent;
            this.FichasGato.ColumnCount = 3;
            this.FichasGato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FichasGato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FichasGato.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FichasGato.Location = new System.Drawing.Point(24, 12);
            this.FichasGato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FichasGato.Name = "FichasGato";
            this.FichasGato.RowCount = 3;
            this.FichasGato.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FichasGato.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FichasGato.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FichasGato.Size = new System.Drawing.Size(381, 321);
            this.FichasGato.TabIndex = 0;
            // 
            // PicReiniciar
            // 
            this.PicReiniciar.Image = global::Gatito.Properties.Resources.Reiniciar;
            this.PicReiniciar.Location = new System.Drawing.Point(40, 386);
            this.PicReiniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicReiniciar.Name = "PicReiniciar";
            this.PicReiniciar.Size = new System.Drawing.Size(289, 81);
            this.PicReiniciar.TabIndex = 1;
            this.PicReiniciar.TabStop = false;
            this.PicReiniciar.Click += new System.EventHandler(this.PicReiniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gatito.Properties.Resources.f_1;
            this.pictureBox1.Location = new System.Drawing.Point(435, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gatito.Properties.Resources.f_2;
            this.pictureBox2.Location = new System.Drawing.Point(616, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // PicGanador
            // 
            this.PicGanador.Image = global::Gatito.Properties.Resources.f_0;
            this.PicGanador.Location = new System.Drawing.Point(781, 12);
            this.PicGanador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicGanador.Name = "PicGanador";
            this.PicGanador.Size = new System.Drawing.Size(129, 111);
            this.PicGanador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicGanador.TabIndex = 4;
            this.PicGanador.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "VS";
            // 
            // LblPlayer1
            // 
            this.LblPlayer1.AutoSize = true;
            this.LblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer1.ForeColor = System.Drawing.Color.White;
            this.LblPlayer1.Location = new System.Drawing.Point(477, 130);
            this.LblPlayer1.Name = "LblPlayer1";
            this.LblPlayer1.Size = new System.Drawing.Size(17, 17);
            this.LblPlayer1.TabIndex = 6;
            this.LblPlayer1.Text = "0";
            // 
            // LblPlayer2
            // 
            this.LblPlayer2.AutoSize = true;
            this.LblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.LblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlayer2.ForeColor = System.Drawing.Color.White;
            this.LblPlayer2.Location = new System.Drawing.Point(675, 130);
            this.LblPlayer2.Name = "LblPlayer2";
            this.LblPlayer2.Size = new System.Drawing.Size(17, 17);
            this.LblPlayer2.TabIndex = 7;
            this.LblPlayer2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(808, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "GANADOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gatito.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(937, 513);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblPlayer2);
            this.Controls.Add(this.LblPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicGanador);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PicReiniciar);
            this.Controls.Add(this.FichasGato);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicReiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicGanador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FichasGato;
        private System.Windows.Forms.PictureBox PicReiniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PicGanador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPlayer1;
        private System.Windows.Forms.Label LblPlayer2;
        private System.Windows.Forms.Label label2;
    }
}

