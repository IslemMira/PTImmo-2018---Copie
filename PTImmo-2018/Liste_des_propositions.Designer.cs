namespace PTImmo_2018
{
	partial class Liste_des_propositions
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GenererBonVisite = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.FicheAcheteur = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Code_Propo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Code_Souhait = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Code_Bien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_Propo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.CodeProposition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodeSouhait = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateProposition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateVisite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CodeProp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomAcheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrenomAcheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrenomCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idBien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateProp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(193, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(147, 20);
            this.textBox4.TabIndex = 182;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 178;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(785, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 184;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PTImmo_2018.Properties.Resources.icons8_create_document_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(704, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 189;
            this.button1.Text = "Creer visite";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreerVisite_Click);
            // 
            // GenererBonVisite
            // 
            this.GenererBonVisite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenererBonVisite.Image = global::PTImmo_2018.Properties.Resources.icons8_print_32;
            this.GenererBonVisite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenererBonVisite.Location = new System.Drawing.Point(704, 534);
            this.GenererBonVisite.Name = "GenererBonVisite";
            this.GenererBonVisite.Size = new System.Drawing.Size(146, 53);
            this.GenererBonVisite.TabIndex = 190;
            this.GenererBonVisite.Text = "Generer bon de visite";
            this.GenererBonVisite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GenererBonVisite.UseVisualStyleBackColor = true;
            this.GenererBonVisite.Click += new System.EventHandler(this.GenererBonVisite_Click);
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Image = global::PTImmo_2018.Properties.Resources.icons8_edit_property_32;
            this.Modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modifier.Location = new System.Drawing.Point(704, 611);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(146, 53);
            this.Modifier.TabIndex = 191;
            this.Modifier.Text = "     Modifier";
            this.Modifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.Image = global::PTImmo_2018.Properties.Resources.icons8_delete_document_32;
            this.Supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Supprimer.Location = new System.Drawing.Point(704, 690);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(146, 53);
            this.Supprimer.TabIndex = 192;
            this.Supprimer.Text = "   Supprimer";
            this.Supprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // FicheAcheteur
            // 
            this.FicheAcheteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FicheAcheteur.Image = global::PTImmo_2018.Properties.Resources.icons8_customer_48;
            this.FicheAcheteur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FicheAcheteur.Location = new System.Drawing.Point(704, 90);
            this.FicheAcheteur.Name = "FicheAcheteur";
            this.FicheAcheteur.Size = new System.Drawing.Size(146, 53);
            this.FicheAcheteur.TabIndex = 193;
            this.FicheAcheteur.Text = "Fiche Acheteur";
            this.FicheAcheteur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FicheAcheteur.UseVisualStyleBackColor = true;
            this.FicheAcheteur.Click += new System.EventHandler(this.FicheAcheteur_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodeProp,
            this.NomAcheteur,
            this.PrenomAcheteur,
            this.NomCom,
            this.PrenomCom,
            this.idBien,
            this.DateProp});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(105, 251);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(568, 152);
            this.listView1.TabIndex = 204;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Code_Propo
            // 
            this.Code_Propo.Text = "Code Proposition";
            this.Code_Propo.Width = 93;
            // 
            // Code_Souhait
            // 
            this.Code_Souhait.Text = "Code Souhait";
            this.Code_Souhait.Width = 82;
            // 
            // Code_Bien
            // 
            this.Code_Bien.Text = "Code Bien";
            this.Code_Bien.Width = 77;
            // 
            // Date_Propo
            // 
            this.Date_Propo.Text = "Date Proposition";
            this.Date_Propo.Width = 262;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodeProposition,
            this.CodeSouhait,
            this.DateProposition,
            this.DateVisite});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.Location = new System.Drawing.Point(103, 521);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(570, 229);
            this.listView2.TabIndex = 195;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // CodeProposition
            // 
            this.CodeProposition.Text = "Code Proposition";
            this.CodeProposition.Width = 126;
            // 
            // CodeSouhait
            // 
            this.CodeSouhait.Text = "Code Souhait";
            this.CodeSouhait.Width = 100;
            // 
            // DateProposition
            // 
            this.DateProposition.Text = "Date Proposition";
            this.DateProposition.Width = 200;
            // 
            // DateVisite
            // 
            this.DateVisite.Text = "DateVisite";
            this.DateVisite.Width = 211;
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(195, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 196;
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.BackColor = System.Drawing.Color.Transparent;
            this.Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prenom.Location = new System.Drawing.Point(130, 124);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(57, 15);
            this.Prenom.TabIndex = 200;
            this.Prenom.Text = "Prenom :";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.BackColor = System.Drawing.Color.Transparent;
            this.Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nom.Location = new System.Drawing.Point(130, 89);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(40, 15);
            this.Nom.TabIndex = 199;
            this.Nom.Text = "Nom :";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::PTImmo_2018.Properties.Resources.icons8_customer_48;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(101, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 53);
            this.label7.TabIndex = 198;
            this.label7.Text = "         Informations acheteur";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(676, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 201;
            this.label8.Text = "Code acheteur:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::PTImmo_2018.Properties.Resources.icons8_bulleted_list_48;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(101, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 53);
            this.label2.TabIndex = 202;
            this.label2.Text = "      Liste propositions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::PTImmo_2018.Properties.Resources.icons8_visit_48;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(101, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 53);
            this.label6.TabIndex = 203;
            this.label6.Text = "Liste visites";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodeProp
            // 
            this.CodeProp.Text = "Code Proposition";
            // 
            // NomAcheteur
            // 
            this.NomAcheteur.Text = "Nom Acheteur";
            // 
            // PrenomAcheteur
            // 
            this.PrenomAcheteur.Text = "Prénom Acheteur";
            // 
            // NomCom
            // 
            this.NomCom.Text = "Nom Commercial";
            // 
            // PrenomCom
            // 
            this.PrenomCom.Text = "Prénom Commercial";
            // 
            // idBien
            // 
            this.idBien.Text = "Id Bien";
            // 
            // DateProp
            // 
            this.DateProp.Text = "Date Proposition";
            // 
            // Liste_des_propositions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PTImmo_2018.Properties.Resources.otherbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 824);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.FicheAcheteur);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.GenererBonVisite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Name = "Liste_des_propositions";
            this.Text = "Liste_des_propositions";
            this.Load += new System.EventHandler(this.Liste_des_propositions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button GenererBonVisite;
		private System.Windows.Forms.Button Modifier;
		private System.Windows.Forms.Button Supprimer;
		private System.Windows.Forms.Button FicheAcheteur;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ColumnHeader CodeSouhait;
		private System.Windows.Forms.ColumnHeader DateProposition;
		private System.Windows.Forms.ColumnHeader DateVisite;
        private System.Windows.Forms.ColumnHeader Code_Souhait;
        private System.Windows.Forms.ColumnHeader Code_Bien;
        private System.Windows.Forms.ColumnHeader Date_Propo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ColumnHeader Code_Propo;
		private System.Windows.Forms.Label Prenom;
		private System.Windows.Forms.Label Nom;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ColumnHeader CodeProposition;
        private System.Windows.Forms.ColumnHeader CodeProp;
        private System.Windows.Forms.ColumnHeader NomAcheteur;
        private System.Windows.Forms.ColumnHeader PrenomAcheteur;
        private System.Windows.Forms.ColumnHeader NomCom;
        private System.Windows.Forms.ColumnHeader PrenomCom;
        private System.Windows.Forms.ColumnHeader idBien;
        private System.Windows.Forms.ColumnHeader DateProp;
    }
}