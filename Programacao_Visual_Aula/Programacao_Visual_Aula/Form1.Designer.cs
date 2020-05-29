namespace Programacao_Visual_Aula
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AV1_A = new System.Windows.Forms.TextBox();
            this.AV1_B = new System.Windows.Forms.TextBox();
            this.AV1_MED = new System.Windows.Forms.TextBox();
            this.AV2Text = new System.Windows.Forms.TextBox();
            this.Media_Final = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota AV1-A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota AV1-B";
            // 
            // AV1_A
            // 
            this.AV1_A.Location = new System.Drawing.Point(88, 90);
            this.AV1_A.Name = "AV1_A";
            this.AV1_A.Size = new System.Drawing.Size(100, 20);
            this.AV1_A.TabIndex = 1;
            // 
            // AV1_B
            // 
            this.AV1_B.Location = new System.Drawing.Point(88, 132);
            this.AV1_B.Name = "AV1_B";
            this.AV1_B.Size = new System.Drawing.Size(100, 20);
            this.AV1_B.TabIndex = 2;
            // 
            // AV1_MED
            // 
            this.AV1_MED.Location = new System.Drawing.Point(229, 42);
            this.AV1_MED.Name = "AV1_MED";
            this.AV1_MED.ReadOnly = true;
            this.AV1_MED.ShortcutsEnabled = false;
            this.AV1_MED.Size = new System.Drawing.Size(100, 20);
            this.AV1_MED.TabIndex = 10;
            this.AV1_MED.TabStop = false;
            // 
            // AV2Text
            // 
            this.AV2Text.Location = new System.Drawing.Point(229, 109);
            this.AV2Text.Name = "AV2Text";
            this.AV2Text.Size = new System.Drawing.Size(100, 20);
            this.AV2Text.TabIndex = 3;
            // 
            // Media_Final
            // 
            this.Media_Final.Location = new System.Drawing.Point(229, 170);
            this.Media_Final.Name = "Media_Final";
            this.Media_Final.ReadOnly = true;
            this.Media_Final.ShortcutsEnabled = false;
            this.Media_Final.Size = new System.Drawing.Size(100, 20);
            this.Media_Final.TabIndex = 10;
            this.Media_Final.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Média AV1 (peso 1)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nota AV2 (peso 2)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Média final";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular Média";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 219);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Media_Final);
            this.Controls.Add(this.AV2Text);
            this.Controls.Add(this.AV1_MED);
            this.Controls.Add(this.AV1_B);
            this.Controls.Add(this.AV1_A);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AV1_A;
        private System.Windows.Forms.TextBox AV1_B;
        private System.Windows.Forms.TextBox AV1_MED;
        private System.Windows.Forms.TextBox AV2Text;
        private System.Windows.Forms.TextBox Media_Final;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

