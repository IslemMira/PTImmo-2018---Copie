using System.Windows.Forms;

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
            this.listView1_vendeurs = new System.Windows.Forms.ListView();
            this.code_vendeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.Rechercher = new System.Windows.Forms.Button();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Identidiant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Visualiser = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Bouton_Ajouter_bien = new System.Windows.Forms.Button();
            this.Button_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1_vendeurs
            // 
            this.listView1_vendeurs.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1_vendeurs.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView1_vendeurs.BackColor = System.Drawing.Color.Gainsboro;
            this.listView1_vendeurs.BackgroundImageTiled = true;
            this.listView1_vendeurs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1_vendeurs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code_vendeur,
            this.Nom,
            this.prenom});
            this.listView1_vendeurs.FullRowSelect = true;
            this.listView1_vendeurs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1_vendeurs.HoverSelection = true;
            this.listView1_vendeurs.Location = new System.Drawing.Point(140, 264);
            this.listView1_vendeurs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1_vendeurs.Name = "listView1_vendeurs";
            this.listView1_vendeurs.Size = new System.Drawing.Size(630, 272);
            this.listView1_vendeurs.TabIndex = 17;
            this.listView1_vendeurs.UseCompatibleStateImageBehavior = false;
            this.listView1_vendeurs.View = System.Windows.Forms.View.Details;
            this.listView1_vendeurs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_vendeurs_MouseClick);
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
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::PTImmo_2018.Properties.Resources.user;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(135, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 57);
            this.label3.TabIndex = 139;
            this.label3.Text = "     Liste vendeurs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rechercher
            // 
            this.Rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rechercher.Image = global::PTImmo_2018.Properties.Resources.icons8_search_48;
            this.Rechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Rechercher.Location = new System.Drawing.Point(725, 162);
            this.Rechercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(263, 64);
            this.Rechercher.TabIndex = 140;
            this.Rechercher.Text = "    Rechercher";
            this.Rechercher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(281, 206);
            this.textBox_Nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(249, 22);
            this.textBox_Nom.TabIndex = 144;
            // 
            // textBox_Identidiant
            // 
            this.textBox_Identidiant.Location = new System.Drawing.Point(281, 158);
            this.textBox_Identidiant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Identidiant.Name = "textBox_Identidiant";
            this.textBox_Identidiant.Size = new System.Drawing.Size(249, 22);
            this.textBox_Identidiant.TabIndex = 143;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 142;
            this.label4.Text = "Nom :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 141;
            this.label5.Text = "Identifiant :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Visualiser
            // 
            this.Visualiser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Visualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualiser.Image = global::PTImmo_2018.Properties.Resources.icons8_contact_details_481;
            this.Visualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Visualiser.Location = new System.Drawing.Point(801, 362);
            this.Visualiser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Visualiser.Name = "Visualiser";
            this.Visualiser.Size = new System.Drawing.Size(187, 79);
            this.Visualiser.TabIndex = 145;
            this.Visualiser.Text = "Visualiser";
            this.Visualiser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Visualiser.UseVisualStyleBackColor = false;
            this.Visualiser.Click += new System.EventHandler(this.Visualiser_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Ajouter.FlatAppearance.BorderSize = 2;
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Image = global::PTImmo_2018.Properties.Resources.icons8_add_property_48;
            this.Ajouter.Location = new System.Drawing.Point(725, 63);
            this.Ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(263, 74);
            this.Ajouter.TabIndex = 146;
            this.Ajouter.Text = "Créer Vendeur";
            this.Ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajouter.UseVisualStyleBackColor = false;
            // 
            // Bouton_Ajouter_bien
            // 
            this.Bouton_Ajouter_bien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Bouton_Ajouter_bien.FlatAppearance.BorderSize = 2;
            this.Bouton_Ajouter_bien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bouton_Ajouter_bien.Image = global::PTImmo_2018.Properties.Resources.icons8_add_property_48;
            this.Bouton_Ajouter_bien.Location = new System.Drawing.Point(725, 570);
            this.Bouton_Ajouter_bien.Margin = new System.Windows.Forms.Padding(4);
            this.Bouton_Ajouter_bien.Name = "Bouton_Ajouter_bien";
            this.Bouton_Ajouter_bien.Size = new System.Drawing.Size(263, 74);
            this.Bouton_Ajouter_bien.TabIndex = 147;
            this.Bouton_Ajouter_bien.Text = "    Ajouter Bien";
            this.Bouton_Ajouter_bien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bouton_Ajouter_bien.UseVisualStyleBackColor = false;
            this.Bouton_Ajouter_bien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Bouton_Ajouter_bien_MouseClick);
            // 
            // Button_Annuler
            // 
            this.Button_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Annuler.Image = global::PTImmo_2018.Properties.Resources.icons8_file_delete_48;
            this.Button_Annuler.Location = new System.Drawing.Point(175, 572);
            this.Button_Annuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Annuler.Name = "Button_Annuler";
            this.Button_Annuler.Size = new System.Drawing.Size(212, 70);
            this.Button_Annuler.TabIndex = 148;
            this.Button_Annuler.Text = "ANNULER";
            this.Button_Annuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Annuler.UseVisualStyleBackColor = true;
            this.Button_Annuler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_Annuler_MouseClick);
            // 
            // RechercheVendeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PTImmo_2018.Properties.Resources.otherbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 678);
            this.Controls.Add(this.Button_Annuler);
            this.Controls.Add(this.Bouton_Ajouter_bien);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Visualiser);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.textBox_Identidiant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1_vendeurs);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RechercheVendeur";
            this.Text = "RechercheVendeur";
            this.Load += new System.EventHandler(this.RechercheVendeur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader code_vendeur;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader prenom;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Rechercher;
		private System.Windows.Forms.TextBox textBox_Nom;
		private System.Windows.Forms.TextBox textBox_Identidiant;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button Visualiser;
        private Button Ajouter;
        private Button Bouton_Ajouter_bien;
        private Button Button_Annuler;
        private ListView listView1_vendeurs;
    }
}