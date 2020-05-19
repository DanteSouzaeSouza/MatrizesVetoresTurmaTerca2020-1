namespace MatrizesVetoresTurmaTerca2020_1
{
    partial class FrmVetorMatriz
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
            this.btnVetor = new System.Windows.Forms.Button();
            this.lstVetor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnVetor
            // 
            this.btnVetor.Location = new System.Drawing.Point(12, 12);
            this.btnVetor.Name = "btnVetor";
            this.btnVetor.Size = new System.Drawing.Size(179, 23);
            this.btnVetor.TabIndex = 0;
            this.btnVetor.Text = "Vetor";
            this.btnVetor.UseVisualStyleBackColor = true;
            // 
            // lstVetor
            // 
            this.lstVetor.FormattingEnabled = true;
            this.lstVetor.ItemHeight = 16;
            this.lstVetor.Location = new System.Drawing.Point(12, 50);
            this.lstVetor.Name = "lstVetor";
            this.lstVetor.Size = new System.Drawing.Size(179, 164);
            this.lstVetor.TabIndex = 1;
            // 
            // FrmVetorMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 238);
            this.Controls.Add(this.lstVetor);
            this.Controls.Add(this.btnVetor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVetorMatriz";
            this.Text = "Vetores e Matrizes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVetor;
        private System.Windows.Forms.ListBox lstVetor;
    }
}

