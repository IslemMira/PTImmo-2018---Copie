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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.checkBox_actif = new System.Windows.Forms.CheckBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.code_commercial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nb_acheteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Statut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1_rechercher = new System.Windows.Forms.Button();
            this.button1_Ajouter = new System.Windows.Forms.Button();
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code_commercial,
            this.Nom,
            this.Nb_acheteur,
            this.Statut});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "coucou";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.Location = new System.Drawing.Point(28, 173);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(629, 218);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // code_commercial
            // 
            this.code_commercial.Text = "Code commercial";
            this.code_commercial.Width = 148;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 170;
            // 
            // Nb_acheteur
            // 
            this.Nb_acheteur.Text = "Nombre acheteurs";
            this.Nb_acheteur.Width = 151;
            // 
            // Statut
            // 
            this.Statut.Text = "Statut";
            this.Statut.Width = 170;
            // 
            // button1_rechercher
            // 
            this.button1_rechercher.Location = new System.Drawing.Point(248, 126);
            this.button1_rechercher.Name = "button1_rechercher";
            this.button1_rechercher.Size = new System.Drawing.Size(75, 23);
            this.button1_rechercher.TabIndex = 13;
            this.button1_rechercher.Text = "Rechercher";
            this.button1_rechercher.UseVisualStyleBackColor = true;
            // 
            // button1_Ajouter
            // 
            this.button1_Ajouter.Location = new System.Drawing.Point(582, 410);
            this.button1_Ajouter.Name = "button1_Ajouter";
            this.button1_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.button1_Ajouter.TabIndex = 14;
            this.button1_Ajouter.Text = "Ajouter";
            this.button1_Ajouter.UseVisualStyleBackColor = true;
            // 
            // Recherche_Commerciaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.button1_Ajouter);
            this.Controls.Add(this.button1_rechercher);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader code_commercial;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Nb_acheteur;
        private System.Windows.Forms.ColumnHeader Statut;
        private System.Windows.Forms.Button button1_rechercher;
        private System.Windows.Forms.Button button1_Ajouter;
    }
}