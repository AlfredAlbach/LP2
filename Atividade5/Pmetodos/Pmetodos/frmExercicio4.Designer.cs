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
            this.rchText = new System.Windows.Forms.RichTextBox();
            this.btnContaNum = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnContaLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchText
            // 
            this.rchText.Location = new System.Drawing.Point(142, 29);
            this.rchText.Name = "rchText";
            this.rchText.Size = new System.Drawing.Size(486, 280);
            this.rchText.TabIndex = 0;
            this.rchText.Text = "";
            this.rchText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnContaNum
            // 
            this.btnContaNum.Location = new System.Drawing.Point(75, 352);
            this.btnContaNum.Name = "btnContaNum";
            this.btnContaNum.Size = new System.Drawing.Size(123, 61);
            this.btnContaNum.TabIndex = 1;
            this.btnContaNum.Text = "Quantos numeros tem?";
            this.btnContaNum.UseVisualStyleBackColor = true;
            this.btnContaNum.Click += new System.EventHandler(this.btnContaNum_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(336, 352);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(123, 61);
            this.btnBranco.TabIndex = 2;
            this.btnBranco.Text = "Posição de espaço em branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            // 
            // btnContaLetras
            // 
            this.btnContaLetras.Location = new System.Drawing.Point(579, 352);
            this.btnContaLetras.Name = "btnContaLetras";
            this.btnContaLetras.Size = new System.Drawing.Size(123, 61);
            this.btnContaLetras.TabIndex = 3;
            this.btnContaLetras.Text = "Quantas letras tem?";
            this.btnContaLetras.UseVisualStyleBackColor = true;
            this.btnContaLetras.Click += new System.EventHandler(this.btnContaLetras_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContaLetras);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnContaNum);
            this.Controls.Add(this.rchText);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchText;
        private System.Windows.Forms.Button btnContaNum;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnContaLetras;
    }
}