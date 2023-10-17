namespace Pmetodos
{
    partial class frmExercicio4
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnContaNumeros = new System.Windows.Forms.Button();
            this.btnPrimeiroBranco = new System.Windows.Forms.Button();
            this.btnContaLetras = new System.Windows.Forms.Button();
            this.lblFrase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(228, 39);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(326, 134);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnContaNumeros
            // 
            this.btnContaNumeros.Location = new System.Drawing.Point(193, 240);
            this.btnContaNumeros.Name = "btnContaNumeros";
            this.btnContaNumeros.Size = new System.Drawing.Size(91, 55);
            this.btnContaNumeros.TabIndex = 1;
            this.btnContaNumeros.Text = "Conta Números";
            this.btnContaNumeros.UseVisualStyleBackColor = true;
            this.btnContaNumeros.Click += new System.EventHandler(this.BtnContaNumeros_Click);
            // 
            // btnPrimeiroBranco
            // 
            this.btnPrimeiroBranco.Location = new System.Drawing.Point(354, 238);
            this.btnPrimeiroBranco.Name = "btnPrimeiroBranco";
            this.btnPrimeiroBranco.Size = new System.Drawing.Size(86, 57);
            this.btnPrimeiroBranco.TabIndex = 2;
            this.btnPrimeiroBranco.Text = "Primeiro Caracter em Branco";
            this.btnPrimeiroBranco.UseVisualStyleBackColor = true;
            this.btnPrimeiroBranco.Click += new System.EventHandler(this.BtnPrimeiroBranco_Click);
            // 
            // btnContaLetras
            // 
            this.btnContaLetras.Location = new System.Drawing.Point(498, 235);
            this.btnContaLetras.Name = "btnContaLetras";
            this.btnContaLetras.Size = new System.Drawing.Size(94, 60);
            this.btnContaLetras.TabIndex = 3;
            this.btnContaLetras.Text = "Conta Letras";
            this.btnContaLetras.UseVisualStyleBackColor = true;
            this.btnContaLetras.Click += new System.EventHandler(this.BtnContaLetras_Click);
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(167, 59);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(33, 13);
            this.lblFrase.TabIndex = 4;
            this.lblFrase.Text = "Frase";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.btnContaLetras);
            this.Controls.Add(this.btnPrimeiroBranco);
            this.Controls.Add(this.btnContaNumeros);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnContaNumeros;
        private System.Windows.Forms.Button btnPrimeiroBranco;
        private System.Windows.Forms.Button btnContaLetras;
        private System.Windows.Forms.Label lblFrase;
    }
}