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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1_Commerciaux = new System.Windows.Forms.ListView();
            this.code_commercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nb_acheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Statut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1_rechercher = new System.Windows.Forms.Button();
            this.button1_Ajouter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Prénom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // checkBox_actif
            // 
            this.checkBox_actif.AutoSize = true;
            this.checkBox_actif.Location = new System.Drawing.Point(28, 47);
            this.checkBox_actif.Name = "checkBox_actif";
            this.checkBox_actif.Size = new System.Drawing.Size(47, 17);
            this.checkBox_actif.TabIndex = 0;
            this.checkBox_actif.Text = "Actif";
            this.checkBox_actif.UseVisualStyleBackColor = true;
            this.checkBox_actif.CheckedChanged += new System.EventHandler(this.checkBox_actif_CheckedChanged);
           
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(28, 129);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(135, 20);
            this.textBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id commercial";
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
            this.listView1_Commerciaux.Location = new System.Drawing.Point(12, 167);
            this.listView1_Commerciaux.Name = "listView1_Commerciaux";
            this.listView1_Commerciaux.Size = new System.Drawing.Size(597, 237);
            this.listView1_Commerciaux.TabIndex = 12;
            this.listView1_Commerciaux.UseCompatibleStateImageBehavior = false;
            this.listView1_Commerciaux.View = System.Windows.Forms.View.Details;
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
            // Nb_acheteur
            // 
            this.Nb_acheteur.DisplayIndex = 3;
            this.Nb_acheteur.Text = "Nombre acheteurs";
            this.Nb_acheteur.Width = 101;
            // 
            // Statut
            // 
            this.Statut.DisplayIndex = 4;
            this.Statut.Text = "Statut";
            this.Statut.Width = 120;
            // 
            // button1_rechercher
            // 
            this.button1_rechercher.Location = new System.Drawing.Point(248, 126);
            this.button1_rechercher.Name = "button1_rechercher";
            this.button1_rechercher.Size = new System.Drawing.Size(75, 23);
            this.button1_rechercher.TabIndex = 13;
            this.button1_rechercher.Text = "Rechercher";
            this.button1_rechercher.UseVisualStyleBackColor = true;
            this.button1_rechercher.Click += new System.EventHandler(this.Recherche_IdCommercial);
            // 
            // button1_Ajouter
            // 
            this.button1_Ajouter.Location = new System.Drawing.Point(534, 423);
            this.button1_Ajouter.Name = "button1_Ajouter";
            this.button1_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.button1_Ajouter.TabIndex = 14;
            this.button1_Ajouter.Text = "Ajouter";
            this.button1_Ajouter.UseVisualStyleBackColor = true;
            this.button1_Ajouter.Click += new System.EventHandler(this.Button_AjouterCommercial);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Prénom
            // 
            this.Prénom.DisplayIndex = 2;
            this.Prénom.Text = "Prénom";
            this.Prénom.Width = 114;
            // 
            // Recherche_Commerciaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button1_Ajouter);
            this.Controls.Add(this.button1_rechercher);
            this.Controls.Add(this.listView1_Commerciaux);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.checkBox_actif);
            this.Name = "Recherche_Commerciaux";
            this.Text = "Recherche_Commerciaux";
            this.Load += new System.EventHandler(this.Recherche_Commerciaux_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_actif;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1_Commerciaux;
        private System.Windows.Forms.ColumnHeader code_commercial;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Nb_acheteur;
        private System.Windows.Forms.ColumnHeader Statut;
        private System.Windows.Forms.Button button1_rechercher;
        private System.Windows.Forms.Button button1_Ajouter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Prénom;
    }
}