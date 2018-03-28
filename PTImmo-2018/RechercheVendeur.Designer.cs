namespace PTImmo_2018
{
    partial class RechercheVendeur
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
            this.button1 = new System.Windows.Forms.Button();
            this.button1_consulter = new System.Windows.Forms.Button();
            this.button1_rechercher = new System.Windows.Forms.Button();
            this.listView1_vendeurs = new System.Windows.Forms.ListView();
            this.code_vendeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_nom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button1_consulter
            // 
            this.button1_consulter.Location = new System.Drawing.Point(569, 268);
            this.button1_consulter.Name = "button1_consulter";
            this.button1_consulter.Size = new System.Drawing.Size(75, 23);
            this.button1_consulter.TabIndex = 20;
            this.button1_consulter.Text = "Consulter";
            this.button1_consulter.UseVisualStyleBackColor = true;
            // 
            // button1_rechercher
            // 
            this.button1_rechercher.Location = new System.Drawing.Point(459, 115);
            this.button1_rechercher.Name = "button1_rechercher";
            this.button1_rechercher.Size = new System.Drawing.Size(75, 23);
            this.button1_rechercher.TabIndex = 18;
            this.button1_rechercher.Text = "Rechercher";
            this.button1_rechercher.UseVisualStyleBackColor = true;
            // 
            // listView1_vendeurs
            // 
            this.listView1_vendeurs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code_vendeur,
            this.Nom,
            this.prenom});
            this.listView1_vendeurs.FullRowSelect = true;
            this.listView1_vendeurs.Location = new System.Drawing.Point(61, 177);
            this.listView1_vendeurs.Name = "listView1_vendeurs";
            this.listView1_vendeurs.Size = new System.Drawing.Size(473, 221);
            this.listView1_vendeurs.TabIndex = 17;
            this.listView1_vendeurs.UseCompatibleStateImageBehavior = false;
            this.listView1_vendeurs.View = System.Windows.Forms.View.Details;
            // 
            // code_vendeur
            // 
            this.code_vendeur.Text = "Code vendeur";
            this.code_vendeur.Width = 148;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 170;
            // 
            // prenom
            // 
            this.prenom.Text = "Prénom";
            this.prenom.Width = 151;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id vendeur";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(61, 53);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(135, 20);
            this.textBox_id.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nom";
            // 
            // textBox1_nom
            // 
            this.textBox1_nom.Location = new System.Drawing.Point(61, 117);
            this.textBox1_nom.Name = "textBox1_nom";
            this.textBox1_nom.Size = new System.Drawing.Size(135, 20);
            this.textBox1_nom.TabIndex = 22;
            // 
            // RechercheVendeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.textBox1_nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1_consulter);
            this.Controls.Add(this.button1_rechercher);
            this.Controls.Add(this.listView1_vendeurs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_id);
            this.Name = "RechercheVendeur";
            this.Text = "RechercheVendeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button1_consulter;
        private System.Windows.Forms.Button button1_rechercher;
        private System.Windows.Forms.ListView listView1_vendeurs;
        private System.Windows.Forms.ColumnHeader code_vendeur;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_nom;
    }
}