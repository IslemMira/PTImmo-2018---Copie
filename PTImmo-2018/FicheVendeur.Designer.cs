namespace PTImmo_2018
{
    partial class FicheVendeur
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
            this.textBox4_E_Mail = new System.Windows.Forms.TextBox();
            this.textBox3_Telephone = new System.Windows.Forms.TextBox();
            this.textBox2_Prenom = new System.Windows.Forms.TextBox();
            this.textBox1_Nom = new System.Windows.Forms.TextBox();
            this.textBox10_CP = new System.Windows.Forms.TextBox();
            this.textBox11_Ville = new System.Windows.Forms.TextBox();
            this.textBox12_Adresse = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.code_Bien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordonnées = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Statut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre_de_visite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_AjCodeVendeur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AjouterBien = new System.Windows.Forms.Button();
            this.Visualiser = new System.Windows.Forms.Button();
            this.Button_Annuler = new System.Windows.Forms.Button();
            this.ModifierVendeur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox4_E_Mail
            // 
            this.textBox4_E_Mail.Enabled = false;
            this.textBox4_E_Mail.Location = new System.Drawing.Point(218, 197);
            this.textBox4_E_Mail.Name = "textBox4_E_Mail";
            this.textBox4_E_Mail.ReadOnly = true;
            this.textBox4_E_Mail.Size = new System.Drawing.Size(228, 20);
            this.textBox4_E_Mail.TabIndex = 15;
            // 
            // textBox3_Telephone
            // 
            this.textBox3_Telephone.Enabled = false;
            this.textBox3_Telephone.Location = new System.Drawing.Point(218, 160);
            this.textBox3_Telephone.Name = "textBox3_Telephone";
            this.textBox3_Telephone.ReadOnly = true;
            this.textBox3_Telephone.Size = new System.Drawing.Size(154, 20);
            this.textBox3_Telephone.TabIndex = 14;
            // 
            // textBox2_Prenom
            // 
            this.textBox2_Prenom.Enabled = false;
            this.textBox2_Prenom.Location = new System.Drawing.Point(218, 125);
            this.textBox2_Prenom.Name = "textBox2_Prenom";
            this.textBox2_Prenom.ReadOnly = true;
            this.textBox2_Prenom.Size = new System.Drawing.Size(154, 20);
            this.textBox2_Prenom.TabIndex = 13;
            // 
            // textBox1_Nom
            // 
            this.textBox1_Nom.Enabled = false;
            this.textBox1_Nom.Location = new System.Drawing.Point(218, 90);
            this.textBox1_Nom.Name = "textBox1_Nom";
            this.textBox1_Nom.ReadOnly = true;
            this.textBox1_Nom.Size = new System.Drawing.Size(154, 20);
            this.textBox1_Nom.TabIndex = 12;
            // 
            // textBox10_CP
            // 
            this.textBox10_CP.Enabled = false;
            this.textBox10_CP.Location = new System.Drawing.Point(199, 391);
            this.textBox10_CP.Name = "textBox10_CP";
            this.textBox10_CP.ReadOnly = true;
            this.textBox10_CP.Size = new System.Drawing.Size(96, 20);
            this.textBox10_CP.TabIndex = 45;
            // 
            // textBox11_Ville
            // 
            this.textBox11_Ville.Enabled = false;
            this.textBox11_Ville.Location = new System.Drawing.Point(199, 353);
            this.textBox11_Ville.Name = "textBox11_Ville";
            this.textBox11_Ville.ReadOnly = true;
            this.textBox11_Ville.Size = new System.Drawing.Size(185, 20);
            this.textBox11_Ville.TabIndex = 44;
            // 
            // textBox12_Adresse
            // 
            this.textBox12_Adresse.Enabled = false;
            this.textBox12_Adresse.Location = new System.Drawing.Point(199, 318);
            this.textBox12_Adresse.Name = "textBox12_Adresse";
            this.textBox12_Adresse.ReadOnly = true;
            this.textBox12_Adresse.Size = new System.Drawing.Size(185, 20);
            this.textBox12_Adresse.TabIndex = 43;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code_Bien,
            this.Coordonnées,
            this.Statut,
            this.Nombre_de_visite});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(136, 493);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(747, 172);
            this.listView1.TabIndex = 47;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // code_Bien
            // 
            this.code_Bien.Text = "Code Bien";
            this.code_Bien.Width = 148;
            // 
            // Coordonnées
            // 
            this.Coordonnées.Text = "Coordonnées";
            this.Coordonnées.Width = 170;
            // 
            // Statut
            // 
            this.Statut.Text = "Statut";
            this.Statut.Width = 151;
            // 
            // Nombre_de_visite
            // 
            this.Nombre_de_visite.Text = "Nombre de visite";
            this.Nombre_de_visite.Width = 170;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::PTImmo_2018.Properties.Resources.user;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(101, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 53);
            this.label1.TabIndex = 65;
            this.label1.Text = "         Informations vendeur";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(688, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "Code vendeur:";
            // 
            // textBox_AjCodeVendeur
            // 
            this.textBox_AjCodeVendeur.Enabled = false;
            this.textBox_AjCodeVendeur.Location = new System.Drawing.Point(796, 24);
            this.textBox_AjCodeVendeur.Name = "textBox_AjCodeVendeur";
            this.textBox_AjCodeVendeur.ReadOnly = true;
            this.textBox_AjCodeVendeur.Size = new System.Drawing.Size(87, 20);
            this.textBox_AjCodeVendeur.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 85;
            this.label4.Text = "E-mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 84;
            this.label5.Text = "Telephone :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 83;
            this.label6.Text = "Prenom :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(133, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 82;
            this.label7.Text = "Nom :";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::PTImmo_2018.Properties.Resources.map32;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(133, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 48);
            this.label8.TabIndex = 86;
            this.label8.Text = "     Adresse";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(133, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 89;
            this.label9.Text = "CP :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(133, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 88;
            this.label10.Text = "Ville :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(133, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 15);
            this.label11.TabIndex = 87;
            this.label11.Text = "Rue :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 132;
            this.label3.Text = "Liste biens :";
            // 
            // AjouterBien
            // 
            this.AjouterBien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AjouterBien.FlatAppearance.BorderSize = 2;
            this.AjouterBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterBien.Image = global::PTImmo_2018.Properties.Resources.icons8_add_property_48;
            this.AjouterBien.Location = new System.Drawing.Point(684, 722);
            this.AjouterBien.Name = "AjouterBien";
            this.AjouterBien.Size = new System.Drawing.Size(197, 60);
            this.AjouterBien.TabIndex = 133;
            this.AjouterBien.Text = "    Ajouter Bien";
            this.AjouterBien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AjouterBien.UseVisualStyleBackColor = false;
            this.AjouterBien.Click += new System.EventHandler(this.AjouterBien_Click);
            // 
            // Visualiser
            // 
            this.Visualiser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Visualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualiser.Image = global::PTImmo_2018.Properties.Resources.icons8_show_property_48;
            this.Visualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Visualiser.Location = new System.Drawing.Point(389, 722);
            this.Visualiser.Name = "Visualiser";
            this.Visualiser.Size = new System.Drawing.Size(179, 60);
            this.Visualiser.TabIndex = 134;
            this.Visualiser.Text = "      Visualiser";
            this.Visualiser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Visualiser.UseVisualStyleBackColor = false;
            this.Visualiser.Click += new System.EventHandler(this.Visualiser_Click);
            // 
            // Button_Annuler
            // 
            this.Button_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Annuler.Image = global::PTImmo_2018.Properties.Resources.icons8_file_delete_48;
            this.Button_Annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Annuler.Location = new System.Drawing.Point(136, 722);
            this.Button_Annuler.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Annuler.Name = "Button_Annuler";
            this.Button_Annuler.Size = new System.Drawing.Size(159, 57);
            this.Button_Annuler.TabIndex = 143;
            this.Button_Annuler.Text = "Fermer";
            this.Button_Annuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Annuler.UseVisualStyleBackColor = true;
            this.Button_Annuler.Click += new System.EventHandler(this.Button_Annuler_Click);
            // 
            // ModifierVendeur
            // 
            this.ModifierVendeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierVendeur.Image = global::PTImmo_2018.Properties.Resources.user;
            this.ModifierVendeur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ModifierVendeur.Location = new System.Drawing.Point(718, 70);
            this.ModifierVendeur.Name = "ModifierVendeur";
            this.ModifierVendeur.Size = new System.Drawing.Size(165, 56);
            this.ModifierVendeur.TabIndex = 144;
            this.ModifierVendeur.Text = "   Modifier     Vendeur";
            this.ModifierVendeur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ModifierVendeur.UseVisualStyleBackColor = true;
            this.ModifierVendeur.Click += new System.EventHandler(this.ModifierVendeur_Click);
            // 
            // FicheVendeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PTImmo_2018.Properties.Resources.otherbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(919, 823);
            this.Controls.Add(this.ModifierVendeur);
            this.Controls.Add(this.Button_Annuler);
            this.Controls.Add(this.Visualiser);
            this.Controls.Add(this.AjouterBien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_AjCodeVendeur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox10_CP);
            this.Controls.Add(this.textBox11_Ville);
            this.Controls.Add(this.textBox12_Adresse);
            this.Controls.Add(this.textBox4_E_Mail);
            this.Controls.Add(this.textBox3_Telephone);
            this.Controls.Add(this.textBox2_Prenom);
            this.Controls.Add(this.textBox1_Nom);
            this.Name = "FicheVendeur";
            this.Text = "FicheVendeur";
            this.Load += new System.EventHandler(this.FicheVendeur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4_E_Mail;
        private System.Windows.Forms.TextBox textBox3_Telephone;
        private System.Windows.Forms.TextBox textBox2_Prenom;
        private System.Windows.Forms.TextBox textBox1_Nom;
        private System.Windows.Forms.TextBox textBox10_CP;
        private System.Windows.Forms.TextBox textBox11_Ville;
        private System.Windows.Forms.TextBox textBox12_Adresse;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader code_Bien;
        private System.Windows.Forms.ColumnHeader Coordonnées;
        private System.Windows.Forms.ColumnHeader Statut;
        private System.Windows.Forms.ColumnHeader Nombre_de_visite;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_AjCodeVendeur;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button AjouterBien;
		private System.Windows.Forms.Button Visualiser;
		private System.Windows.Forms.Button Button_Annuler;
		private System.Windows.Forms.Button ModifierVendeur;
	}
}