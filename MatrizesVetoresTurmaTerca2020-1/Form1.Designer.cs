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
            this.btnMatriz = new System.Windows.Forms.Button();
            this.lstMatriz = new System.Windows.Forms.ListBox();
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
            this.btnVetor.Click += new System.EventHandler(this.btnVetor_Click);
            // 
            // lstVetor
            // 
            this.lstVetor.FormattingEnabled = true;
            this.lstVetor.ItemHeight = 16;
            this.lstVetor.Location = new System.Drawing.Point(12, 41);
            this.lstVetor.Name = "lstVetor";
            this.lstVetor.Size = new System.Drawing.Size(179, 180);
            this.lstVetor.TabIndex = 1;
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(270, 13);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(169, 23);
            this.btnMatriz.TabIndex = 2;
            this.btnMatriz.Text = "Matriz";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // lstMatriz
            // 
            this.lstMatriz.FormattingEnabled = true;
            this.lstMatriz.ItemHeight = 16;
            this.lstMatriz.Location = new System.Drawing.Point(270, 43);
            this.lstMatriz.Name = "lstMatriz";
            this.lstMatriz.Size = new System.Drawing.Size(287, 180);
            this.lstMatriz.TabIndex = 3;
            this.lstMatriz.SelectedIndexChanged += new System.EventHandler(this.lstMatriz_SelectedIndexChanged);
            // 
            // FrmVetorMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 237);
            this.Controls.Add(this.lstMatriz);
            this.Controls.Add(this.btnMatriz);
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
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.ListBox lstMatriz;
    }
}

