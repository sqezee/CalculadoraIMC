namespace CalculoIMC
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalculoIMC = new System.Windows.Forms.Button();
            this.lblIMC = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPaciente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(328, 138);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            this.lblPeso.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(328, 180);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            this.lblAltura.Click += new System.EventHandler(this.lblAltura_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(410, 133);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(96, 20);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(410, 180);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(96, 20);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // btnCalculoIMC
            // 
            this.btnCalculoIMC.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalculoIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculoIMC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculoIMC.Location = new System.Drawing.Point(352, 215);
            this.btnCalculoIMC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculoIMC.Name = "btnCalculoIMC";
            this.btnCalculoIMC.Size = new System.Drawing.Size(130, 30);
            this.btnCalculoIMC.TabIndex = 4;
            this.btnCalculoIMC.Text = "Calcular IMC";
            this.btnCalculoIMC.UseVisualStyleBackColor = false;
            this.btnCalculoIMC.Click += new System.EventHandler(this.btnCalculoIMC_Click);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Location = new System.Drawing.Point(328, 271);
            this.lblIMC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(26, 13);
            this.lblIMC.TabIndex = 5;
            this.lblIMC.Text = "IMC";
            this.lblIMC.Click += new System.EventHandler(this.lblIMC_Click);
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(410, 269);
            this.txtIMC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(96, 20);
            this.txtIMC.TabIndex = 6;
            this.txtIMC.TextChanged += new System.EventHandler(this.txtIMC_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(196, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 38);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Calculadora de IMC";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.BackColor = System.Drawing.SystemColors.Menu;
            this.txtClassificacao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtClassificacao.Location = new System.Drawing.Point(410, 307);
            this.txtClassificacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtClassificacao.Multiline = true;
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(186, 51);
            this.txtClassificacao.TabIndex = 12;
            this.txtClassificacao.TextChanged += new System.EventHandler(this.txtClassificacao_TextChanged);
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Location = new System.Drawing.Point(328, 307);
            this.lblClassificacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(69, 13);
            this.lblClassificacao.TabIndex = 11;
            this.lblClassificacao.Text = "Classificação";
            this.lblClassificacao.Click += new System.EventHandler(this.lblClassificacao_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(410, 93);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(96, 20);
            this.txtNome.TabIndex = 14;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(328, 98);
            this.lblPaciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(49, 13);
            this.lblPaciente.TabIndex = 13;
            this.lblPaciente.Text = "Paciente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 406);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.btnCalculoIMC);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalculoIMC;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPaciente;
    }
}

