namespace PTImmo_2018
{
    partial class FormAcceuil
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
			this.GA = new System.Windows.Forms.Button();
			this.GC = new System.Windows.Forms.Button();
			this.GB = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// GA
			// 
			this.GA.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.GA.BackColor = System.Drawing.Color.Transparent;
			this.GA.Cursor = System.Windows.Forms.Cursors.Hand;
			this.GA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.GA.FlatAppearance.BorderSize = 3;
			this.GA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.GA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GA.Image = global::PTImmo_2018.Properties.Resources.icons8_team_96;
			this.GA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.GA.Location = new System.Drawing.Point(562, 389);
			this.GA.Name = "GA";
			this.GA.Size = new System.Drawing.Size(247, 98);
			this.GA.TabIndex = 2;
			this.GA.Text = "     Gestion       Acheteurs";
			this.GA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.GA.UseVisualStyleBackColor = false;
			this.GA.Click += new System.EventHandler(this.GA_Click);
			// 
			// GC
			// 
			this.GC.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.GC.BackColor = System.Drawing.Color.Transparent;
			this.GC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.GC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.GC.FlatAppearance.BorderSize = 3;
			this.GC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.GC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GC.Image = global::PTImmo_2018.Properties.Resources.icons8_name_tag_96;
			this.GC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.GC.Location = new System.Drawing.Point(562, 525);
			this.GC.Name = "GC";
			this.GC.Size = new System.Drawing.Size(247, 103);
			this.GC.TabIndex = 3;
			this.GC.Text = "Gestion Commerciaux";
			this.GC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.GC.UseVisualStyleBackColor = false;
			this.GC.Click += new System.EventHandler(this.GC_Click);
			// 
			// GB
			// 
			this.GB.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.GB.BackColor = System.Drawing.Color.Transparent;
			this.GB.Cursor = System.Windows.Forms.Cursors.Hand;
			this.GB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.GB.FlatAppearance.BorderSize = 3;
			this.GB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.GB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GB.Image = global::PTImmo_2018.Properties.Resources.icons8_real_estate_96;
			this.GB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.GB.Location = new System.Drawing.Point(562, 252);
			this.GB.Name = "GB";
			this.GB.Size = new System.Drawing.Size(247, 98);
			this.GB.TabIndex = 1;
			this.GB.Text = "     Gestion       Biens";
			this.GB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.GB.UseVisualStyleBackColor = false;
			this.GB.Click += new System.EventHandler(this.GB_Click);
			// 
			// FormAcceuil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackgroundImage = global::PTImmo_2018.Properties.Resources.background11;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(903, 764);
			this.Controls.Add(this.GC);
			this.Controls.Add(this.GA);
			this.Controls.Add(this.GB);
			this.Name = "FormAcceuil";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Immo Billy - Accueil";
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button GA;
        private System.Windows.Forms.Button GC;
		private System.Windows.Forms.Button GB;
	}
}

