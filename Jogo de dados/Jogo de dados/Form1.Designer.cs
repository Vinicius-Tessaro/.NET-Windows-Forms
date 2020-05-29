namespace Jogo_de_dados
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.dado_jogador2 = new System.Windows.Forms.PictureBox();
            this.dado_jogador1 = new System.Windows.Forms.PictureBox();
            this.lblGanhador = new System.Windows.Forms.Label();
            this.btnReinicia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dado_jogador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado_jogador1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(65, 182);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Jogador 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(293, 182);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Jogador 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // dado_jogador2
            // 
            this.dado_jogador2.Image = ((System.Drawing.Image)(resources.GetObject("dado_jogador2.Image")));
            this.dado_jogador2.Location = new System.Drawing.Point(276, 51);
            this.dado_jogador2.Name = "dado_jogador2";
            this.dado_jogador2.Size = new System.Drawing.Size(102, 94);
            this.dado_jogador2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dado_jogador2.TabIndex = 1;
            this.dado_jogador2.TabStop = false;
            // 
            // dado_jogador1
            // 
            this.dado_jogador1.ErrorImage = null;
            this.dado_jogador1.Image = ((System.Drawing.Image)(resources.GetObject("dado_jogador1.Image")));
            this.dado_jogador1.InitialImage = null;
            this.dado_jogador1.Location = new System.Drawing.Point(54, 51);
            this.dado_jogador1.Name = "dado_jogador1";
            this.dado_jogador1.Size = new System.Drawing.Size(102, 94);
            this.dado_jogador1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dado_jogador1.TabIndex = 0;
            this.dado_jogador1.TabStop = false;
            // 
            // lblGanhador
            // 
            this.lblGanhador.AutoSize = true;
            this.lblGanhador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanhador.Location = new System.Drawing.Point(127, 231);
            this.lblGanhador.Name = "lblGanhador";
            this.lblGanhador.Size = new System.Drawing.Size(0, 25);
            this.lblGanhador.TabIndex = 4;
            // 
            // btnReinicia
            // 
            this.btnReinicia.Location = new System.Drawing.Point(176, 275);
            this.btnReinicia.Name = "btnReinicia";
            this.btnReinicia.Size = new System.Drawing.Size(91, 23);
            this.btnReinicia.TabIndex = 5;
            this.btnReinicia.Text = "Reiniciar Jogo";
            this.btnReinicia.UseVisualStyleBackColor = true;
            this.btnReinicia.Click += new System.EventHandler(this.btnReinicia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 310);
            this.Controls.Add(this.btnReinicia);
            this.Controls.Add(this.lblGanhador);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.dado_jogador2);
            this.Controls.Add(this.dado_jogador1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dado_jogador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado_jogador1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dado_jogador1;
        private System.Windows.Forms.PictureBox dado_jogador2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lblGanhador;
        private System.Windows.Forms.Button btnReinicia;
    }
}

