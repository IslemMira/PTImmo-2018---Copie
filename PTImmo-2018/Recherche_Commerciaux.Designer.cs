namespace PTImmo_2018
{
    partial class Recherche_Commerciaux
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
            this.checkBox_actif = new System.Windows.Forms.CheckBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.listView1_Commerciaux = new System.Windows.Forms.ListView();
            this.code_commercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prénom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nb_acheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Statut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.IBien = new System.Windows.Forms.Label();
            this.button1_rechercher = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Visualiser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_actif
            // 
            this.checkBox_actif.AutoSize = true;
            this.checkBox_actif.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_actif.Checked = true;
            this.checkBox_actif.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_actif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_actif.Location = new System.Drawing.Point(154, 110);
            this.checkBox_actif.Name = "checkBox_actif";
            this.checkBox_actif.Size = new System.Drawing.Size(48, 19);
            this.checkBox_actif.TabIndex = 0;
            this.checkBox_actif.Text = "Actif";
            this.checkBox_actif.UseVisualStyleBackColor = false;
            this.checkBox_actif.CheckedChanged += new System.EventHandler(this.checkBox_actif_CheckedChanged);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(154, 265);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(135, 20);
            this.textBox_id.TabIndex = 1;
            // 
            // listView1_Commerciaux
            // 
            this.listView1_Commerciaux.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code_commercial,
            this.Nom,
            this.Prénom,
            this.Nb_acheteur,
            this.Statut});
            this.listView1_Commerciaux.FullRowSelect = true;
            this.listView1_Commerciaux.GridLines = true;
            this.listView1_Commerciaux.Location = new System.Drawing.Point(154, 362);
            this.listView1_Commerciaux.Name = "listView1_Commerciaux";
            this.listView1_Commerciaux.Size = new System.Drawing.Size(597, 237);
            this.listView1_Commerciaux.TabIndex = 12;
            this.listView1_Commerciaux.UseCompatibleStateImageBehavior = false;
            this.listView1_Commerciaux.View = System.Windows.Forms.View.Details;
            this.listView1_Commerciaux.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_Commerciaux_MouseClick);
            // 
            // code_commercial
            // 
            this.code_commercial.Text = "Code commercial";
            this.code_commercial.Width = 106;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 145;
            // 
            // Prénom
            // 
            this.Prénom.Text = "Prénom";
            this.Prénom.Width = 114;
            // 
            // Nb_acheteur
            // 
            this.Nb_acheteur.Text = "Nombre acheteurs";
            this.Nb_acheteur.Width = 101;
            // 
            // Statut
            // 
            this.Statut.Text = "Statut";
            this.Statut.Width = 120;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::PTImmo_2018.Properties.Resources.icons8_name_tag_48;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(101, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 46);
            this.label2.TabIndex = 15;
            this.label2.Text = "Liste de commerciaux";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(154, 149);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 19);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Ancien Employe";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // IBien
            // 
            this.IBien.AutoSize = true;
            this.IBien.BackColor = System.Drawing.Color.Transparent;
            this.IBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBien.Location = new System.Drawing.Point(151, 229);
            this.IBien.Name = "IBien";
            this.IBien.Size = new System.Drawing.Size(130, 15);
            this.IBien.TabIndex = 17;
            this.IBien.Text = "Identifiant Commercial";
            // 
            // button1_rechercher
            // 
            this.button1_rechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_rechercher.Image = global::PTImmo_2018.Properties.Resources.icons8_search_48;
            this.button1_rechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_rechercher.Location = new System.Drawing.Point(554, 233);
            this.button1_rechercher.Name = "button1_rechercher";
            this.button1_rechercher.Size = new System.Drawing.Size(197, 52);
            this.button1_rechercher.TabIndex = 18;
            this.button1_rechercher.Text = "    Rechercher";
            this.button1_rechercher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1_rechercher.UseVisualStyleBackColor = true;
            this.button1_rechercher.Click += new System.EventHandler(this.button1_rechercher_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Ajouter.FlatAppearance.BorderSize = 2;
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Image = global::PTImmo_2018.Properties.Resources.icons8_businessman_48;
            this.Ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajouter.Location = new System.Drawing.Point(554, 127);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(197, 60);
            this.Ajouter.TabIndex = 19;
            this.Ajouter.Text = "      Ajouter        commercial";
            this.Ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ajouter.UseVisualStyleBackColor = false;
            // 
            // Visualiser
            // 
            this.Visualiser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Visualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visualiser.Image = global::PTImmo_2018.Properties.Resources.icons8_businessman_48;
            this.Visualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Visualiser.Location = new System.Drawing.Point(554, 645);
            this.Visualiser.Name = "Visualiser";
            this.Visualiser.Size = new System.Drawing.Size(197, 60);
            this.Visualiser.TabIndex = 20;
            this.Visualiser.Text = "      Modifier";
            this.Visualiser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Visualiser.UseVisualStyleBackColor = false;
            this.Visualiser.Click += new System.EventHandler(this.Visualiser_Click);
            // 
            // Recherche_Commerciaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PTImmo_2018.Properties.Resources.otherbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 709);
            this.Controls.Add(this.Visualiser);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.button1_rechercher);
            this.Controls.Add(this.IBien);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1_Commerciaux);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.checkBox_actif);
            this.Name = "Recherche_Commerciaux";
            this.Text = "Recherche_Commerciaux";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_actif;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.ListView listView1_Commerciaux;
        private System.Windows.Forms.ColumnHeader code_commercial;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Nb_acheteur;
        private System.Windows.Forms.ColumnHeader Statut;
        private System.Windows.Forms.ColumnHeader Prénom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label IBien;
		private System.Windows.Forms.Button button1_rechercher;
		private System.Windows.Forms.Button Ajouter;
		private System.Windows.Forms.Button Visualiser;
	}
}