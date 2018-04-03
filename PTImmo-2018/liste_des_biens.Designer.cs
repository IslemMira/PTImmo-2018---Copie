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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Disponible
			// 
			this.Disponible.AutoSize = true;
			this.Disponible.BackColor = System.Drawing.Color.Transparent;
			this.Disponible.Checked = true;
			this.Disponible.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Disponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Disponible.Location = new System.Drawing.Point(164, 98);
			this.Disponible.Name = "Disponible";
			this.Disponible.Size = new System.Drawing.Size(85, 19);
			this.Disponible.TabIndex = 0;
			this.Disponible.Text = "Disponible";
			this.Disponible.UseVisualStyleBackColor = false;
			this.Disponible.CheckedChanged += new System.EventHandler(this.Disponible_CheckedChanged);
			// 
			// SousS
			// 
			this.SousS.AutoSize = true;
			this.SousS.BackColor = System.Drawing.Color.Transparent;
			this.SousS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SousS.Location = new System.Drawing.Point(164, 121);
			this.SousS.Name = "SousS";
			this.SousS.Size = new System.Drawing.Size(89, 19);
			this.SousS.TabIndex = 1;
			this.SousS.Text = "Sous Seing";
			this.SousS.UseVisualStyleBackColor = false;
			this.SousS.CheckedChanged += new System.EventHandler(this.SousS_CheckedChanged);
			// 
			// Vendu
			// 
			this.Vendu.AutoSize = true;
			this.Vendu.BackColor = System.Drawing.Color.Transparent;
			this.Vendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Vendu.Location = new System.Drawing.Point(164, 144);
			this.Vendu.Name = "Vendu";
			this.Vendu.Size = new System.Drawing.Size(61, 19);
			this.Vendu.TabIndex = 2;
			this.Vendu.Text = "Vendu";
			this.Vendu.UseVisualStyleBackColor = false;
			this.Vendu.CheckedChanged += new System.EventHandler(this.Vendu_CheckedChanged);
			// 
			// Retire
			// 
			this.Retire.AutoSize = true;
			this.Retire.BackColor = System.Drawing.Color.Transparent;
			this.Retire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Retire.Location = new System.Drawing.Point(164, 167);
			this.Retire.Name = "Retire";
			this.Retire.Size = new System.Drawing.Size(59, 19);
			this.Retire.TabIndex = 3;
			this.Retire.Text = "Retire";
			this.Retire.UseVisualStyleBackColor = false;
			this.Retire.CheckedChanged += new System.EventHandler(this.Retire_CheckedChanged);
			// 
			// IBien
			// 
			this.IBien.AutoSize = true;
			this.IBien.BackColor = System.Drawing.Color.Transparent;
			this.IBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IBien.Location = new System.Drawing.Point(161, 230);
			this.IBien.Name = "IBien";
			this.IBien.Size = new System.Drawing.Size(88, 15);
			this.IBien.TabIndex = 4;
			this.IBien.Text = "Identifiant Bien";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(164, 264);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 20);
			this.textBox1.TabIndex = 5;
			// 
			// NProprio
			// 
			this.NProprio.AutoSize = true;
			this.NProprio.BackColor = System.Drawing.Color.Transparent;
			this.NProprio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NProprio.Location = new System.Drawing.Point(161, 310);
			this.NProprio.Name = "NProprio";
			this.NProprio.Size = new System.Drawing.Size(101, 15);
			this.NProprio.TabIndex = 6;
			this.NProprio.Text = "Nom Proprietaire";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(164, 339);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(279, 20);
			this.textBox2.TabIndex = 7;
			// 
			// Rechercher
			// 
			this.Rechercher.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Rechercher.Image = global::PTImmo_2018.Properties.Resources.icons8_search_48;
			this.Rechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Rechercher.Location = new System.Drawing.Point(708, 307);
			this.Rechercher.Name = "Rechercher";
			this.Rechercher.Size = new System.Drawing.Size(197, 52);
			this.Rechercher.TabIndex = 8;
			this.Rechercher.Text = "    Rechercher";
			this.Rechercher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Rechercher.UseVisualStyleBackColor = true;
			this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
			// 
			// Ajouter
			// 
			this.Ajouter.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Ajouter.FlatAppearance.BorderSize = 2;
			this.Ajouter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Ajouter.Image = global::PTImmo_2018.Properties.Resources.icons8_add_property_48;
			this.Ajouter.Location = new System.Drawing.Point(708, 207);
			this.Ajouter.Name = "Ajouter";
			this.Ajouter.Size = new System.Drawing.Size(197, 60);
			this.Ajouter.TabIndex = 9;
			this.Ajouter.Text = "    Ajouter Bien";
			this.Ajouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Ajouter.UseVisualStyleBackColor = false;
			this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
			// 
			// Visualiser
			// 
			this.Visualiser.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Visualiser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Visualiser.Image = global::PTImmo_2018.Properties.Resources.icons8_show_property_48;
			this.Visualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Visualiser.Location = new System.Drawing.Point(708, 659);
			this.Visualiser.Name = "Visualiser";
			this.Visualiser.Size = new System.Drawing.Size(197, 60);
			this.Visualiser.TabIndex = 10;
			this.Visualiser.Text = "      Visualiser";
			this.Visualiser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Visualiser.UseVisualStyleBackColor = false;
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
			this.listView1.Location = new System.Drawing.Point(164, 412);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(741, 218);
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
			this.Coordonnées.Width = 298;
			// 
			// Statut
			// 
			this.Statut.Text = "Statut";
			this.Statut.Width = 191;
			// 
			// Nombre_de_visite
			// 
			this.Nombre_de_visite.Text = "Nombre de visite";
			this.Nombre_de_visite.Width = 98;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Image = global::PTImmo_2018.Properties.Resources.icons8_real_estate_48;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(117, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 46);
			this.label1.TabIndex = 12;
			this.label1.Text = "Liste de biens";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = global::PTImmo_2018.Properties.Resources.logo3;
			this.button1.Location = new System.Drawing.Point(708, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(197, 92);
			this.button1.TabIndex = 13;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// liste_des_biens
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::PTImmo_2018.Properties.Resources.otherbackground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(947, 744);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}