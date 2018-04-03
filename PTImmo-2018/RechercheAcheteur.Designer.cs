namespace PTImmo_2018
{
	partial class RechercheAcheteur
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_commercial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Prenom = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID_Acheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom_acheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom_acheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tel_acheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email_acheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Visualiser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 125;
            this.label2.Text = "Filtrer par commercial";
            // 
            // comboBox_commercial
            // 
            this.comboBox_commercial.FormattingEnabled = true;
            this.comboBox_commercial.Location = new System.Drawing.Point(272, 278);
            this.comboBox_commercial.Name = "comboBox_commercial";
            this.comboBox_commercial.Size = new System.Drawing.Size(134, 21);
            this.comboBox_commercial.TabIndex = 126;
            this.comboBox_commercial.SelectedIndexChanged += new System.EventHandler(this.Filtre_Commercial);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 129;
            this.label4.Text = "Nom :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 130;
            this.label5.Text = "Prenom :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(218, 116);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(188, 20);
            this.textBox_Nom.TabIndex = 132;
            // 
            // textBox_Prenom
            // 
            this.textBox_Prenom.Location = new System.Drawing.Point(218, 161);
            this.textBox_Prenom.Name = "textBox_Prenom";
            this.textBox_Prenom.Size = new System.Drawing.Size(188, 20);
            this.textBox_Prenom.TabIndex = 133;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Acheteur,
            this.Nom_acheteur,
            this.Prenom_acheteur,
            this.tel_acheteur,
            this.email_acheteur});
            this.listView1.Location = new System.Drawing.Point(131, 359);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(667, 214);
            this.listView1.TabIndex = 137;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // ID_Acheteur
            // 
            this.ID_Acheteur.Text = "ID";
            // 
            // Nom_acheteur
            // 
            this.Nom_acheteur.Text = "Nom";
            this.Nom_acheteur.Width = 105;
            // 
            // Prenom_acheteur
            // 
            this.Prenom_acheteur.Text = "Prénom";
            this.Prenom_acheteur.Width = 100;
            // 
            // tel_acheteur
            // 
            this.tel_acheteur.Text = "Téléphone";
            this.tel_acheteur.Width = 115;
            // 
            // email_acheteur
            // 
            this.email_acheteur.Text = "E-mail";
            this.email_acheteur.Width = 178;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::PTImmo_2018.Properties.Resources.icons8_team_48;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(101, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 46);
            this.label1.TabIndex = 138;
            this.label1.Text = "     Liste acheteurs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rechercher
            // 
            this.Rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rechercher.Image = global::PTImmo_2018.Properties.Resources.icons8_search_48;
            this.Rechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Rechercher.Location = new System.Drawing.Point(601, 260);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(197, 52);
            this.Rechercher.TabIndex = 139;
            this.Rechercher.Text = "    Rechercher";
            this.Rechercher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Ajouter.FlatAppearance.BorderSize = 2;
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Image = global::PTImmo_2018.Properties.Resources.icons8_customer_48;
            this.Ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajouter.Location = new System.Drawing.Point(601, 159);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(197, 60);
            this.Ajouter.TabIndex = 140;
            this.Ajouter.Text = "    Ajouter      Acheteur";
            this.Ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Visualiser
            // 
            this.Visualiser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Visualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualiser.Image = global::PTImmo_2018.Properties.Resources.icons8_contact_details_481;
            this.Visualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Visualiser.Location = new System.Drawing.Point(601, 640);
            this.Visualiser.Name = "Visualiser";
            this.Visualiser.Size = new System.Drawing.Size(197, 60);
            this.Visualiser.TabIndex = 141;
            this.Visualiser.Text = "      Visualiser";
            this.Visualiser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Visualiser.UseVisualStyleBackColor = false;
            this.Visualiser.Click += new System.EventHandler(this.Visualiser_Click);
            // 
            // RechercheAcheteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PTImmo_2018.Properties.Resources.otherbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 741);
            this.Controls.Add(this.Visualiser);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox_Prenom);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_commercial);
            this.Controls.Add(this.label2);
            this.Name = "RechercheAcheteur";
            this.Text = "RechercheAcheteur";
            this.Load += new System.EventHandler(this.RechercheAcheteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox_commercial;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_Nom;
		private System.Windows.Forms.TextBox textBox_Prenom;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID_Acheteur;
        private System.Windows.Forms.ColumnHeader Nom_acheteur;
        private System.Windows.Forms.ColumnHeader Prenom_acheteur;
        private System.Windows.Forms.ColumnHeader tel_acheteur;
        private System.Windows.Forms.ColumnHeader email_acheteur;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Rechercher;
		private System.Windows.Forms.Button Ajouter;
		private System.Windows.Forms.Button Visualiser;
	}
}