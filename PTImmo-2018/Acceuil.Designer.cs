namespace PTImmo_2018
{
    partial class Acceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bienvenue = new System.Windows.Forms.Label();
            this.GB = new System.Windows.Forms.Button();
            this.GA = new System.Windows.Forms.Button();
            this.GC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bienvenue
            // 
            this.Bienvenue.AutoSize = true;
            this.Bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.35F);
            this.Bienvenue.Location = new System.Drawing.Point(29, 35);
            this.Bienvenue.Name = "Bienvenue";
            this.Bienvenue.Size = new System.Drawing.Size(320, 29);
            this.Bienvenue.TabIndex = 0;
            this.Bienvenue.Text = "Bienvenue chez Immo Billy";
            // 
            // GB
            // 
            this.GB.Location = new System.Drawing.Point(95, 98);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(143, 29);
            this.GB.TabIndex = 1;
            this.GB.Text = "Gestion des Biens";
            this.GB.UseVisualStyleBackColor = true;
            // 
            // GA
            // 
            this.GA.Location = new System.Drawing.Point(95, 142);
            this.GA.Name = "GA";
            this.GA.Size = new System.Drawing.Size(143, 31);
            this.GA.TabIndex = 2;
            this.GA.Text = "Gestion des acheteurs";
            this.GA.UseVisualStyleBackColor = true;
            // 
            // GC
            // 
            this.GC.Location = new System.Drawing.Point(95, 195);
            this.GC.Name = "GC";
            this.GC.Size = new System.Drawing.Size(143, 29);
            this.GC.TabIndex = 3;
            this.GC.Text = "Gestion des Commerciaux";
            this.GC.UseVisualStyleBackColor = true;
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 337);
            this.Controls.Add(this.GC);
            this.Controls.Add(this.GA);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.Bienvenue);
            this.Name = "Acceuil";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenue;
        private System.Windows.Forms.Button GB;
        private System.Windows.Forms.Button GA;
        private System.Windows.Forms.Button GC;
    }
}

