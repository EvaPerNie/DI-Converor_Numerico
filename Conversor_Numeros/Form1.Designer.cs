namespace Conversor_Numeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNumDecimal = new System.Windows.Forms.Label();
            this.lblNumBinario = new System.Windows.Forms.Label();
            this.lblNumOctal = new System.Windows.Forms.Label();
            this.lblNumHexadecimal = new System.Windows.Forms.Label();
            this.textDecimal = new System.Windows.Forms.TextBox();
            this.textBinario = new System.Windows.Forms.TextBox();
            this.textOctal = new System.Windows.Forms.TextBox();
            this.textHexadecimal = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(39, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(405, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conversor Numérico";
            // 
            // lblNumDecimal
            // 
            this.lblNumDecimal.AutoSize = true;
            this.lblNumDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDecimal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNumDecimal.Location = new System.Drawing.Point(51, 78);
            this.lblNumDecimal.Name = "lblNumDecimal";
            this.lblNumDecimal.Size = new System.Drawing.Size(123, 16);
            this.lblNumDecimal.TabIndex = 0;
            this.lblNumDecimal.Text = "Número Decimal";
            // 
            // lblNumBinario
            // 
            this.lblNumBinario.AutoSize = true;
            this.lblNumBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBinario.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNumBinario.Location = new System.Drawing.Point(111, 123);
            this.lblNumBinario.Name = "lblNumBinario";
            this.lblNumBinario.Size = new System.Drawing.Size(57, 16);
            this.lblNumBinario.TabIndex = 0;
            this.lblNumBinario.Text = "Binario";
            // 
            // lblNumOctal
            // 
            this.lblNumOctal.AutoSize = true;
            this.lblNumOctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOctal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNumOctal.Location = new System.Drawing.Point(122, 174);
            this.lblNumOctal.Name = "lblNumOctal";
            this.lblNumOctal.Size = new System.Drawing.Size(44, 16);
            this.lblNumOctal.TabIndex = 0;
            this.lblNumOctal.Text = "Octal";
            // 
            // lblNumHexadecimal
            // 
            this.lblNumHexadecimal.AutoSize = true;
            this.lblNumHexadecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumHexadecimal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNumHexadecimal.Location = new System.Drawing.Point(75, 222);
            this.lblNumHexadecimal.Name = "lblNumHexadecimal";
            this.lblNumHexadecimal.Size = new System.Drawing.Size(99, 16);
            this.lblNumHexadecimal.TabIndex = 0;
            this.lblNumHexadecimal.Text = "Hexadecimal";
            // 
            // textDecimal
            // 
            this.textDecimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDecimal.ForeColor = System.Drawing.Color.Black;
            this.textDecimal.Location = new System.Drawing.Point(197, 73);
            this.textDecimal.MaxLength = 50;
            this.textDecimal.Multiline = true;
            this.textDecimal.Name = "textDecimal";
            this.textDecimal.Size = new System.Drawing.Size(150, 23);
            this.textDecimal.TabIndex = 1;
            // 
            // textBinario
            // 
            this.textBinario.Enabled = false;
            this.textBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBinario.ForeColor = System.Drawing.Color.Black;
            this.textBinario.Location = new System.Drawing.Point(197, 120);
            this.textBinario.Name = "textBinario";
            this.textBinario.Size = new System.Drawing.Size(150, 23);
            this.textBinario.TabIndex = 0;
            // 
            // textOctal
            // 
            this.textOctal.Enabled = false;
            this.textOctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOctal.ForeColor = System.Drawing.Color.Black;
            this.textOctal.Location = new System.Drawing.Point(197, 171);
            this.textOctal.Name = "textOctal";
            this.textOctal.Size = new System.Drawing.Size(150, 23);
            this.textOctal.TabIndex = 0;
            // 
            // textHexadecimal
            // 
            this.textHexadecimal.Enabled = false;
            this.textHexadecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHexadecimal.ForeColor = System.Drawing.Color.Black;
            this.textHexadecimal.Location = new System.Drawing.Point(197, 219);
            this.textHexadecimal.Name = "textHexadecimal";
            this.textHexadecimal.Size = new System.Drawing.Size(150, 23);
            this.textHexadecimal.TabIndex = 0;
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.Black;
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.Color.White;
            this.btnConvertir.Location = new System.Drawing.Point(47, 279);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(300, 30);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "CONVERTIR";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Green;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(47, 330);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(300, 30);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Conversor_Numeros.Properties.Resources.Binary_Digits_Bits;
            this.pictureBox1.Location = new System.Drawing.Point(373, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 301);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox2.Location = new System.Drawing.Point(196, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 25);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 391);
            this.Controls.Add(this.textDecimal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.textHexadecimal);
            this.Controls.Add(this.textOctal);
            this.Controls.Add(this.textBinario);
            this.Controls.Add(this.lblNumHexadecimal);
            this.Controls.Add(this.lblNumOctal);
            this.Controls.Add(this.lblNumBinario);
            this.Controls.Add(this.lblNumDecimal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Conversor de tipos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNumDecimal;
        private System.Windows.Forms.Label lblNumBinario;
        private System.Windows.Forms.Label lblNumOctal;
        private System.Windows.Forms.Label lblNumHexadecimal;
        private System.Windows.Forms.TextBox textDecimal;
        private System.Windows.Forms.TextBox textBinario;
        private System.Windows.Forms.TextBox textOctal;
        private System.Windows.Forms.TextBox textHexadecimal;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

