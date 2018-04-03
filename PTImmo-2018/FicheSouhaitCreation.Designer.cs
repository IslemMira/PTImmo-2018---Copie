namespace PTImmo_2018
{
	partial class FicheSouhaitCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicheSouhaitCreation));
            this.listBox_Ville = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Ville = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nbPieces = new System.Windows.Forms.NumericUpDown();
            this.textBox_Prix = new System.Windows.Forms.TextBox();
            this.textBox_SurfaceHabitable = new System.Windows.Forms.TextBox();
            this.textBox_SurfaceParcelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button_Valider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nbPieces)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Ville
            // 
            this.listBox_Ville.FormattingEnabled = true;
            this.listBox_Ville.Location = new System.Drawing.Point(288, 380);
            this.listBox_Ville.Name = "listBox_Ville";
            this.listBox_Ville.Size = new System.Drawing.Size(147, 95);
            this.listBox_Ville.TabIndex = 144;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(535, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 143;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Ajouter_VilleSouhait);
            // 
            // textBox_Ville
            // 
            this.textBox_Ville.Location = new System.Drawing.Point(288, 329);
            this.textBox_Ville.Name = "textBox_Ville";
            this.textBox_Ville.Size = new System.Drawing.Size(147, 20);
            this.textBox_Ville.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 141;
            this.label2.Text = "Villes souhaitees :";
            // 
            // nbPieces
            // 
            this.nbPieces.Location = new System.Drawing.Point(288, 165);
            this.nbPieces.Name = "nbPieces";
            this.nbPieces.Size = new System.Drawing.Size(66, 20);
            this.nbPieces.TabIndex = 157;
            // 
            // textBox_Prix
            // 
            this.textBox_Prix.Location = new System.Drawing.Point(287, 222);
            this.textBox_Prix.Name = "textBox_Prix";
            this.textBox_Prix.Size = new System.Drawing.Size(195, 20);
            this.textBox_Prix.TabIndex = 159;
            // 
            // textBox_SurfaceHabitable
            // 
            this.textBox_SurfaceHabitable.Location = new System.Drawing.Point(287, 103);
            this.textBox_SurfaceHabitable.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_SurfaceHabitable.Name = "textBox_SurfaceHabitable";
            this.textBox_SurfaceHabitable.Size = new System.Drawing.Size(67, 20);
            this.textBox_SurfaceHabitable.TabIndex = 160;
            // 
            // textBox_SurfaceParcelle
            // 
            this.textBox_SurfaceParcelle.Location = new System.Drawing.Point(287, 134);
            this.textBox_SurfaceParcelle.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_SurfaceParcelle.Name = "textBox_SurfaceParcelle";
            this.textBox_SurfaceParcelle.Size = new System.Drawing.Size(67, 20);
            this.textBox_SurfaceParcelle.TabIndex = 161;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::PTImmo_2018.Properties.Resources.icons8_to_do_48;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(101, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 53);
            this.label5.TabIndex = 162;
            this.label5.Text = "         Nouveau souhait";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(130, 165);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 15);
            this.label19.TabIndex = 165;
            this.label19.Text = "Nb Pieces (min) :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(130, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 15);
            this.label18.TabIndex = 164;
            this.label18.Text = "Surface parcelle (min) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 163;
            this.label1.Text = "Surface habitable (min) :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(130, 223);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 15);
            this.label23.TabIndex = 166;
            this.label23.Text = "Prix Max :";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(133, 614);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 57);
            this.button3.TabIndex = 224;
            this.button3.Text = "ANNULER";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_Valider
            // 
            this.button_Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Valider.Image = global::PTImmo_2018.Properties.Resources.icons8_check_file_48;
            this.button_Valider.Location = new System.Drawing.Point(451, 614);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(159, 57);
            this.button_Valider.TabIndex = 223;
            this.button_Valider.Text = "VALIDER";
            this.button_Valider.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Valider.UseVisualStyleBackColor = true;
            // 
            // FicheSouhaitCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PTImmo_2018.Properties.Resources.otherbackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(662, 726);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_Valider);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_SurfaceParcelle);
            this.Controls.Add(this.textBox_SurfaceHabitable);
            this.Controls.Add(this.textBox_Prix);
            this.Controls.Add(this.nbPieces);
            this.Controls.Add(this.listBox_Ville);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Ville);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "FicheSouhaitCreation";
            this.Text = "FicheSouhaitCreation";
            this.Load += new System.EventHandler(this.FicheSouhaitCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbPieces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ListBox listBox_Ville;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox_Ville;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nbPieces;
		private System.Windows.Forms.TextBox textBox_Prix;
        private System.Windows.Forms.TextBox textBox_SurfaceHabitable;
        private System.Windows.Forms.TextBox textBox_SurfaceParcelle;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button_Valider;
	}
}