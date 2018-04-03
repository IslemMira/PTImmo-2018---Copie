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
            this.acheteur_d_exis = new System.Windows.Forms.Label();
            this.en_cours = new System.Windows.Forms.RadioButton();
            this.afficher_tout = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_commercial = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.identifiant = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acheteur_d_exis
            // 
            this.acheteur_d_exis.AutoSize = true;
            this.acheteur_d_exis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acheteur_d_exis.Location = new System.Drawing.Point(12, 22);
            this.acheteur_d_exis.Name = "acheteur_d_exis";
            this.acheteur_d_exis.Size = new System.Drawing.Size(169, 16);
            this.acheteur_d_exis.TabIndex = 122;
            this.acheteur_d_exis.Text = "Acheteur deja existant :";
            // 
            // en_cours
            // 
            this.en_cours.AutoSize = true;
            this.en_cours.Location = new System.Drawing.Point(39, 56);
            this.en_cours.Name = "en_cours";
            this.en_cours.Size = new System.Drawing.Size(67, 17);
            this.en_cours.TabIndex = 123;
            this.en_cours.TabStop = true;
            this.en_cours.Text = "En cours";
            this.en_cours.UseVisualStyleBackColor = true;
            // 
            // afficher_tout
            // 
            this.afficher_tout.AutoSize = true;
            this.afficher_tout.Location = new System.Drawing.Point(39, 93);
            this.afficher_tout.Name = "afficher_tout";
            this.afficher_tout.Size = new System.Drawing.Size(86, 17);
            this.afficher_tout.TabIndex = 124;
            this.afficher_tout.TabStop = true;
            this.afficher_tout.Text = "Afficher Tout";
            this.afficher_tout.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 125;
            this.label2.Text = "Filtrer par commercial";
            // 
            // comboBox_commercial
            // 
            this.comboBox_commercial.FormattingEnabled = true;
            this.comboBox_commercial.Location = new System.Drawing.Point(204, 93);
            this.comboBox_commercial.Name = "comboBox_commercial";
            this.comboBox_commercial.Size = new System.Drawing.Size(134, 21);
            this.comboBox_commercial.TabIndex = 126;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(529, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 49);
            this.button1.TabIndex = 127;
            this.button1.Text = "Nouvel acheteur";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 128;
            this.label3.Text = "Identifiant";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 129;
            this.label4.Text = "Nom";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 130;
            this.label5.Text = "Prenom";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // identifiant
            // 
            this.identifiant.Location = new System.Drawing.Point(127, 163);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(188, 20);
            this.identifiant.TabIndex = 131;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(127, 201);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(188, 20);
            this.nom.TabIndex = 132;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(127, 245);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(188, 20);
            this.prenom.TabIndex = 133;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(529, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 49);
            this.button2.TabIndex = 134;
            this.button2.Text = "Recherche";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(39, 328);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(640, 251);
            this.listBox1.TabIndex = 135;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(529, 617);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 49);
            this.button3.TabIndex = 136;
            this.button3.Text = "Visualiser";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // RechercheAcheteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 741);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.identifiant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_commercial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.afficher_tout);
            this.Controls.Add(this.en_cours);
            this.Controls.Add(this.acheteur_d_exis);
            this.Name = "RechercheAcheteur";
            this.Text = "RechercheAcheteur";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label acheteur_d_exis;
		private System.Windows.Forms.RadioButton en_cours;
		private System.Windows.Forms.RadioButton afficher_tout;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox_commercial;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox identifiant;
		private System.Windows.Forms.TextBox nom;
		private System.Windows.Forms.TextBox prenom;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button3;
	}
}