namespace PTImmo_2018
{
    partial class liste_des_biens
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
            this.Disponible = new System.Windows.Forms.CheckBox();
            this.SousS = new System.Windows.Forms.CheckBox();
            this.Vendu = new System.Windows.Forms.CheckBox();
            this.Retire = new System.Windows.Forms.CheckBox();
            this.IBien = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NProprio = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Visualiser = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.code_Bien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Coordonnées = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Statut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre_de_visite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Disponible
            // 
            this.Disponible.AutoSize = true;
            this.Disponible.Checked = true;
            this.Disponible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Disponible.Location = new System.Drawing.Point(21, 22);
            this.Disponible.Name = "Disponible";
            this.Disponible.Size = new System.Drawing.Size(75, 17);
            this.Disponible.TabIndex = 0;
            this.Disponible.Text = "Disponible";
            this.Disponible.UseVisualStyleBackColor = true;
            this.Disponible.CheckedChanged += new System.EventHandler(this.Disponible_CheckedChanged);
            // 
            // SousS
            // 
            this.SousS.AutoSize = true;
            this.SousS.Location = new System.Drawing.Point(21, 45);
            this.SousS.Name = "SousS";
            this.SousS.Size = new System.Drawing.Size(80, 17);
            this.SousS.TabIndex = 1;
            this.SousS.Text = "Sous Seing";
            this.SousS.UseVisualStyleBackColor = true;
            this.SousS.CheckedChanged += new System.EventHandler(this.SousS_CheckedChanged);
            // 
            // Vendu
            // 
            this.Vendu.AutoSize = true;
            this.Vendu.Location = new System.Drawing.Point(21, 68);
            this.Vendu.Name = "Vendu";
            this.Vendu.Size = new System.Drawing.Size(57, 17);
            this.Vendu.TabIndex = 2;
            this.Vendu.Text = "Vendu";
            this.Vendu.UseVisualStyleBackColor = true;
            this.Vendu.CheckedChanged += new System.EventHandler(this.Vendu_CheckedChanged);
            // 
            // Retire
            // 
            this.Retire.AutoSize = true;
            this.Retire.Location = new System.Drawing.Point(21, 91);
            this.Retire.Name = "Retire";
            this.Retire.Size = new System.Drawing.Size(54, 17);
            this.Retire.TabIndex = 3;
            this.Retire.Text = "Retire";
            this.Retire.UseVisualStyleBackColor = true;
            this.Retire.CheckedChanged += new System.EventHandler(this.Retire_CheckedChanged);
            // 
            // IBien
            // 
            this.IBien.AutoSize = true;
            this.IBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.IBien.Location = new System.Drawing.Point(21, 150);
            this.IBien.Name = "IBien";
            this.IBien.Size = new System.Drawing.Size(88, 15);
            this.IBien.TabIndex = 4;
            this.IBien.Text = "Identifiant Bien";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 5;
            // 
            // NProprio
            // 
            this.NProprio.AutoSize = true;
            this.NProprio.Location = new System.Drawing.Point(256, 150);
            this.NProprio.Name = "NProprio";
            this.NProprio.Size = new System.Drawing.Size(85, 13);
            this.NProprio.TabIndex = 6;
            this.NProprio.Text = "Nom Proprietaire";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(249, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 20);
            this.textBox2.TabIndex = 7;
            // 
            // Rechercher
            // 
            this.Rechercher.Location = new System.Drawing.Point(554, 177);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(96, 24);
            this.Rechercher.TabIndex = 8;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(658, 254);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 9;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            // 
            // Visualiser
            // 
            this.Visualiser.Location = new System.Drawing.Point(658, 293);
            this.Visualiser.Name = "Visualiser";
            this.Visualiser.Size = new System.Drawing.Size(75, 23);
            this.Visualiser.TabIndex = 10;
            this.Visualiser.Text = "Visualiser";
            this.Visualiser.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.code_Bien,
            this.Coordonnées,
            this.Statut,
            this.Nombre_de_visite});
            this.listView1.FullRowSelect = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(21, 221);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(629, 218);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
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
            // liste_des_biens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 451);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Visualiser);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.NProprio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.IBien);
            this.Controls.Add(this.Retire);
            this.Controls.Add(this.Vendu);
            this.Controls.Add(this.SousS);
            this.Controls.Add(this.Disponible);
            this.Name = "liste_des_biens";
            this.Text = "liste_des_biens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Disponible;
        private System.Windows.Forms.CheckBox SousS;
        private System.Windows.Forms.CheckBox Vendu;
        private System.Windows.Forms.CheckBox Retire;
        private System.Windows.Forms.Label IBien;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label NProprio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Visualiser;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader code_Bien;
        private System.Windows.Forms.ColumnHeader Coordonnées;
        private System.Windows.Forms.ColumnHeader Statut;
        private System.Windows.Forms.ColumnHeader Nombre_de_visite;
    }
}