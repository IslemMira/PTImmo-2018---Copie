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
            this.button_Annuler = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_StatutSouhait = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_Ville = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Ville = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nbPieces = new System.Windows.Forms.NumericUpDown();
            this.textBox_Prix = new System.Windows.Forms.TextBox();
            this.textBox_SurfaceHabitable = new System.Windows.Forms.TextBox();
            this.textBox_SurfaceParcelle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nbPieces)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Annuler
            // 
            this.button_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Annuler.Location = new System.Drawing.Point(583, 756);
            this.button_Annuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(100, 28);
            this.button_Annuler.TabIndex = 154;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = true;
            this.button_Annuler.Click += new System.EventHandler(this.Annuler_CreationSouhait);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(423, 756);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 153;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Validation_Creation_Souhait);
            // 
            // comboBox_StatutSouhait
            // 
            this.comboBox_StatutSouhait.FormattingEnabled = true;
            this.comboBox_StatutSouhait.Items.AddRange(new object[] {
            "En cours",
            "Obsolete"});
            this.comboBox_StatutSouhait.Location = new System.Drawing.Point(124, 572);
            this.comboBox_StatutSouhait.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_StatutSouhait.Name = "comboBox_StatutSouhait";
            this.comboBox_StatutSouhait.Size = new System.Drawing.Size(160, 24);
            this.comboBox_StatutSouhait.TabIndex = 152;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 576);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 151;
            this.label7.Text = "Etat :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 526);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 148;
            this.label6.Text = "Prix (max) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 146;
            this.label4.Text = "Nombre de pieces (min) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 145;
            this.label3.Text = "Surface parcelle (min) :";
            // 
            // listBox_Ville
            // 
            this.listBox_Ville.FormattingEnabled = true;
            this.listBox_Ville.ItemHeight = 16;
            this.listBox_Ville.Location = new System.Drawing.Point(184, 176);
            this.listBox_Ville.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_Ville.Name = "listBox_Ville";
            this.listBox_Ville.Size = new System.Drawing.Size(195, 116);
            this.listBox_Ville.TabIndex = 144;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(423, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 143;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Ajouter_VilleSouhait);
            // 
            // textBox_Ville
            // 
            this.textBox_Ville.Location = new System.Drawing.Point(184, 124);
            this.textBox_Ville.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Ville.Name = "textBox_Ville";
            this.textBox_Ville.Size = new System.Drawing.Size(195, 22);
            this.textBox_Ville.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 141;
            this.label2.Text = "Villes souhaitees :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 329);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(193, 20);
            this.label17.TabIndex = 140;
            this.label17.Text = "Surface habitable (min) :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(16, 79);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(190, 24);
            this.label26.TabIndex = 139;
            this.label26.Text = "Souhaits acheteur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 138;
            this.label1.Text = "Fiche de souhaits :";
            // 
            // nbPieces
            // 
            this.nbPieces.Location = new System.Drawing.Point(239, 423);
            this.nbPieces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nbPieces.Name = "nbPieces";
            this.nbPieces.Size = new System.Drawing.Size(88, 22);
            this.nbPieces.TabIndex = 157;
            // 
            // textBox_Prix
            // 
            this.textBox_Prix.Location = new System.Drawing.Point(124, 524);
            this.textBox_Prix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Prix.Name = "textBox_Prix";
            this.textBox_Prix.Size = new System.Drawing.Size(259, 22);
            this.textBox_Prix.TabIndex = 159;
            // 
            // textBox_SurfaceHabitable
            // 
            this.textBox_SurfaceHabitable.Location = new System.Drawing.Point(239, 327);
            this.textBox_SurfaceHabitable.Name = "textBox_SurfaceHabitable";
            this.textBox_SurfaceHabitable.Size = new System.Drawing.Size(88, 22);
            this.textBox_SurfaceHabitable.TabIndex = 160;
            // 
            // textBox_SurfaceParcelle
            // 
            this.textBox_SurfaceParcelle.Location = new System.Drawing.Point(239, 375);
            this.textBox_SurfaceParcelle.Name = "textBox_SurfaceParcelle";
            this.textBox_SurfaceParcelle.Size = new System.Drawing.Size(88, 22);
            this.textBox_SurfaceParcelle.TabIndex = 161;
            // 
            // FicheSouhaitCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 894);
            this.Controls.Add(this.textBox_SurfaceParcelle);
            this.Controls.Add(this.textBox_SurfaceHabitable);
            this.Controls.Add(this.textBox_Prix);
            this.Controls.Add(this.nbPieces);
            this.Controls.Add(this.button_Annuler);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_StatutSouhait);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_Ville);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Ville);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FicheSouhaitCreation";
            this.Text = "FicheSouhaitCreation";
            ((System.ComponentModel.ISupportInitialize)(this.nbPieces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_Annuler;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox_StatutSouhait;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBox_Ville;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox_Ville;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nbPieces;
		private System.Windows.Forms.TextBox textBox_Prix;
        private System.Windows.Forms.TextBox textBox_SurfaceHabitable;
        private System.Windows.Forms.TextBox textBox_SurfaceParcelle;
    }
}