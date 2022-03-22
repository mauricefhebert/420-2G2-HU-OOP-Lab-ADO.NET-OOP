namespace Laboratoire10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEtudiant = new System.Windows.Forms.TabPage();
            this.btnEtudiantAfficher = new System.Windows.Forms.Button();
            this.btnEtudiantModifier = new System.Windows.Forms.Button();
            this.btnEtudiantRechercher = new System.Windows.Forms.Button();
            this.btnEtudiantSupprimer = new System.Windows.Forms.Button();
            this.btnEtudiantAjouter = new System.Windows.Forms.Button();
            this.dgEtudiant = new System.Windows.Forms.DataGridView();
            this.cmbEtudiantProg = new System.Windows.Forms.ComboBox();
            this.rdAutre = new System.Windows.Forms.RadioButton();
            this.rdFeminin = new System.Windows.Forms.RadioButton();
            this.rdMasculin = new System.Windows.Forms.RadioButton();
            this.dtBirthdayEtudiant = new System.Windows.Forms.DateTimePicker();
            this.txtAdresseEtudiant = new System.Windows.Forms.TextBox();
            this.txtLastNameEtudiant = new System.Windows.Forms.TextBox();
            this.txtFirstNameEtudiant = new System.Windows.Forms.TextBox();
            this.txtNumEtudiant = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabProgramme = new System.Windows.Forms.TabPage();
            this.dgProg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProgrammesAfficher = new System.Windows.Forms.Button();
            this.btnProgrammesModifier = new System.Windows.Forms.Button();
            this.btnProgrammesSupprimer = new System.Windows.Forms.Button();
            this.btnProgrammesAjouter = new System.Windows.Forms.Button();
            this.txtProgDesc = new System.Windows.Forms.TextBox();
            this.txtProgNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabEtudiant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEtudiant)).BeginInit();
            this.tabProgramme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProg)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEtudiant);
            this.tabControl1.Controls.Add(this.tabProgramme);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEtudiant
            // 
            this.tabEtudiant.Controls.Add(this.btnEtudiantAfficher);
            this.tabEtudiant.Controls.Add(this.btnEtudiantModifier);
            this.tabEtudiant.Controls.Add(this.btnEtudiantRechercher);
            this.tabEtudiant.Controls.Add(this.btnEtudiantSupprimer);
            this.tabEtudiant.Controls.Add(this.btnEtudiantAjouter);
            this.tabEtudiant.Controls.Add(this.dgEtudiant);
            this.tabEtudiant.Controls.Add(this.cmbEtudiantProg);
            this.tabEtudiant.Controls.Add(this.rdAutre);
            this.tabEtudiant.Controls.Add(this.rdFeminin);
            this.tabEtudiant.Controls.Add(this.rdMasculin);
            this.tabEtudiant.Controls.Add(this.dtBirthdayEtudiant);
            this.tabEtudiant.Controls.Add(this.txtAdresseEtudiant);
            this.tabEtudiant.Controls.Add(this.txtLastNameEtudiant);
            this.tabEtudiant.Controls.Add(this.txtFirstNameEtudiant);
            this.tabEtudiant.Controls.Add(this.txtNumEtudiant);
            this.tabEtudiant.Controls.Add(this.label9);
            this.tabEtudiant.Controls.Add(this.label8);
            this.tabEtudiant.Controls.Add(this.label7);
            this.tabEtudiant.Controls.Add(this.label6);
            this.tabEtudiant.Controls.Add(this.label5);
            this.tabEtudiant.Controls.Add(this.label4);
            this.tabEtudiant.Controls.Add(this.label3);
            this.tabEtudiant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabEtudiant.Location = new System.Drawing.Point(4, 24);
            this.tabEtudiant.Name = "tabEtudiant";
            this.tabEtudiant.Padding = new System.Windows.Forms.Padding(3);
            this.tabEtudiant.Size = new System.Drawing.Size(768, 398);
            this.tabEtudiant.TabIndex = 0;
            this.tabEtudiant.Text = "Etudiants";
            this.tabEtudiant.UseVisualStyleBackColor = true;
            this.tabEtudiant.Enter += new System.EventHandler(this.tabEtudiant_Enter);
            // 
            // btnEtudiantAfficher
            // 
            this.btnEtudiantAfficher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEtudiantAfficher.Location = new System.Drawing.Point(653, 182);
            this.btnEtudiantAfficher.Name = "btnEtudiantAfficher";
            this.btnEtudiantAfficher.Size = new System.Drawing.Size(97, 36);
            this.btnEtudiantAfficher.TabIndex = 13;
            this.btnEtudiantAfficher.Text = "Afficher";
            this.btnEtudiantAfficher.UseVisualStyleBackColor = true;
            this.btnEtudiantAfficher.Click += new System.EventHandler(this.btnEtudiantAfficher_Click);
            // 
            // btnEtudiantModifier
            // 
            this.btnEtudiantModifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEtudiantModifier.Location = new System.Drawing.Point(653, 140);
            this.btnEtudiantModifier.Name = "btnEtudiantModifier";
            this.btnEtudiantModifier.Size = new System.Drawing.Size(97, 36);
            this.btnEtudiantModifier.TabIndex = 12;
            this.btnEtudiantModifier.Text = "Modifier";
            this.btnEtudiantModifier.UseVisualStyleBackColor = true;
            this.btnEtudiantModifier.Click += new System.EventHandler(this.btnEtudiantModifier_Click);
            // 
            // btnEtudiantRechercher
            // 
            this.btnEtudiantRechercher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEtudiantRechercher.Location = new System.Drawing.Point(653, 57);
            this.btnEtudiantRechercher.Name = "btnEtudiantRechercher";
            this.btnEtudiantRechercher.Size = new System.Drawing.Size(97, 36);
            this.btnEtudiantRechercher.TabIndex = 10;
            this.btnEtudiantRechercher.Text = "Rechercher";
            this.btnEtudiantRechercher.UseVisualStyleBackColor = true;
            this.btnEtudiantRechercher.Click += new System.EventHandler(this.btnEtudiantRechercher_Click);
            // 
            // btnEtudiantSupprimer
            // 
            this.btnEtudiantSupprimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEtudiantSupprimer.Location = new System.Drawing.Point(653, 98);
            this.btnEtudiantSupprimer.Name = "btnEtudiantSupprimer";
            this.btnEtudiantSupprimer.Size = new System.Drawing.Size(97, 36);
            this.btnEtudiantSupprimer.TabIndex = 11;
            this.btnEtudiantSupprimer.Text = "Supprimer";
            this.btnEtudiantSupprimer.UseVisualStyleBackColor = true;
            this.btnEtudiantSupprimer.Click += new System.EventHandler(this.btnEtudiantSupprimer_Click);
            // 
            // btnEtudiantAjouter
            // 
            this.btnEtudiantAjouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEtudiantAjouter.Location = new System.Drawing.Point(653, 15);
            this.btnEtudiantAjouter.Name = "btnEtudiantAjouter";
            this.btnEtudiantAjouter.Size = new System.Drawing.Size(97, 36);
            this.btnEtudiantAjouter.TabIndex = 9;
            this.btnEtudiantAjouter.Text = "Ajouter";
            this.btnEtudiantAjouter.UseVisualStyleBackColor = true;
            this.btnEtudiantAjouter.Click += new System.EventHandler(this.btnEtudiantAjouter_Click);
            // 
            // dgEtudiant
            // 
            this.dgEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEtudiant.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgEtudiant.Location = new System.Drawing.Point(3, 245);
            this.dgEtudiant.Name = "dgEtudiant";
            this.dgEtudiant.RowTemplate.Height = 25;
            this.dgEtudiant.Size = new System.Drawing.Size(762, 150);
            this.dgEtudiant.TabIndex = 6;
            // 
            // cmbEtudiantProg
            // 
            this.cmbEtudiantProg.FormattingEnabled = true;
            this.cmbEtudiantProg.Location = new System.Drawing.Point(198, 213);
            this.cmbEtudiantProg.Name = "cmbEtudiantProg";
            this.cmbEtudiantProg.Size = new System.Drawing.Size(172, 29);
            this.cmbEtudiantProg.TabIndex = 8;
            // 
            // rdAutre
            // 
            this.rdAutre.AutoSize = true;
            this.rdAutre.Location = new System.Drawing.Point(397, 182);
            this.rdAutre.Name = "rdAutre";
            this.rdAutre.Size = new System.Drawing.Size(70, 25);
            this.rdAutre.TabIndex = 7;
            this.rdAutre.TabStop = true;
            this.rdAutre.Text = "Autre";
            this.rdAutre.UseVisualStyleBackColor = true;
            // 
            // rdFeminin
            // 
            this.rdFeminin.AutoSize = true;
            this.rdFeminin.Location = new System.Drawing.Point(301, 182);
            this.rdFeminin.Name = "rdFeminin";
            this.rdFeminin.Size = new System.Drawing.Size(90, 25);
            this.rdFeminin.TabIndex = 6;
            this.rdFeminin.TabStop = true;
            this.rdFeminin.Text = "Féminin";
            this.rdFeminin.UseVisualStyleBackColor = true;
            // 
            // rdMasculin
            // 
            this.rdMasculin.AutoSize = true;
            this.rdMasculin.Location = new System.Drawing.Point(198, 182);
            this.rdMasculin.Name = "rdMasculin";
            this.rdMasculin.Size = new System.Drawing.Size(97, 25);
            this.rdMasculin.TabIndex = 5;
            this.rdMasculin.TabStop = true;
            this.rdMasculin.Text = "Masculin";
            this.rdMasculin.UseVisualStyleBackColor = true;
            // 
            // dtBirthdayEtudiant
            // 
            this.dtBirthdayEtudiant.Location = new System.Drawing.Point(198, 147);
            this.dtBirthdayEtudiant.Name = "dtBirthdayEtudiant";
            this.dtBirthdayEtudiant.Size = new System.Drawing.Size(172, 29);
            this.dtBirthdayEtudiant.TabIndex = 4;
            // 
            // txtAdresseEtudiant
            // 
            this.txtAdresseEtudiant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAdresseEtudiant.Location = new System.Drawing.Point(198, 112);
            this.txtAdresseEtudiant.Name = "txtAdresseEtudiant";
            this.txtAdresseEtudiant.Size = new System.Drawing.Size(172, 29);
            this.txtAdresseEtudiant.TabIndex = 3;
            // 
            // txtLastNameEtudiant
            // 
            this.txtLastNameEtudiant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLastNameEtudiant.Location = new System.Drawing.Point(198, 77);
            this.txtLastNameEtudiant.Name = "txtLastNameEtudiant";
            this.txtLastNameEtudiant.Size = new System.Drawing.Size(172, 29);
            this.txtLastNameEtudiant.TabIndex = 2;
            // 
            // txtFirstNameEtudiant
            // 
            this.txtFirstNameEtudiant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFirstNameEtudiant.Location = new System.Drawing.Point(198, 42);
            this.txtFirstNameEtudiant.Name = "txtFirstNameEtudiant";
            this.txtFirstNameEtudiant.Size = new System.Drawing.Size(172, 29);
            this.txtFirstNameEtudiant.TabIndex = 1;
            // 
            // txtNumEtudiant
            // 
            this.txtNumEtudiant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumEtudiant.Location = new System.Drawing.Point(198, 7);
            this.txtNumEtudiant.Name = "txtNumEtudiant";
            this.txtNumEtudiant.Size = new System.Drawing.Size(172, 29);
            this.txtNumEtudiant.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Genre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Date de Naissance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Programme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Numéro";
            // 
            // tabProgramme
            // 
            this.tabProgramme.Controls.Add(this.dgProg);
            this.tabProgramme.Controls.Add(this.btnProgrammesAfficher);
            this.tabProgramme.Controls.Add(this.btnProgrammesModifier);
            this.tabProgramme.Controls.Add(this.btnProgrammesSupprimer);
            this.tabProgramme.Controls.Add(this.btnProgrammesAjouter);
            this.tabProgramme.Controls.Add(this.txtProgDesc);
            this.tabProgramme.Controls.Add(this.txtProgNumero);
            this.tabProgramme.Controls.Add(this.label2);
            this.tabProgramme.Controls.Add(this.label1);
            this.tabProgramme.Location = new System.Drawing.Point(4, 24);
            this.tabProgramme.Name = "tabProgramme";
            this.tabProgramme.Padding = new System.Windows.Forms.Padding(3);
            this.tabProgramme.Size = new System.Drawing.Size(768, 398);
            this.tabProgramme.TabIndex = 1;
            this.tabProgramme.Text = "Programmes";
            this.tabProgramme.UseVisualStyleBackColor = true;
            // 
            // dgProg
            // 
            this.dgProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgProg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgProg.Location = new System.Drawing.Point(3, 183);
            this.dgProg.Name = "dgProg";
            this.dgProg.RowTemplate.Height = 25;
            this.dgProg.Size = new System.Drawing.Size(762, 212);
            this.dgProg.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProgrammesId";
            this.Column1.HeaderText = "Numéro Programme";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProgrammeName";
            this.Column2.HeaderText = "Nom du Programme";
            this.Column2.Name = "Column2";
            // 
            // btnProgrammesAfficher
            // 
            this.btnProgrammesAfficher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProgrammesAfficher.Location = new System.Drawing.Point(504, 104);
            this.btnProgrammesAfficher.Name = "btnProgrammesAfficher";
            this.btnProgrammesAfficher.Size = new System.Drawing.Size(97, 36);
            this.btnProgrammesAfficher.TabIndex = 5;
            this.btnProgrammesAfficher.Text = "Afficher";
            this.btnProgrammesAfficher.UseVisualStyleBackColor = true;
            this.btnProgrammesAfficher.Click += new System.EventHandler(this.btnProgrammesAfficher_Click);
            // 
            // btnProgrammesModifier
            // 
            this.btnProgrammesModifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProgrammesModifier.Location = new System.Drawing.Point(392, 104);
            this.btnProgrammesModifier.Name = "btnProgrammesModifier";
            this.btnProgrammesModifier.Size = new System.Drawing.Size(97, 36);
            this.btnProgrammesModifier.TabIndex = 4;
            this.btnProgrammesModifier.Text = "Modifier";
            this.btnProgrammesModifier.UseVisualStyleBackColor = true;
            this.btnProgrammesModifier.Click += new System.EventHandler(this.btnProgrammesModifier_Click);
            // 
            // btnProgrammesSupprimer
            // 
            this.btnProgrammesSupprimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProgrammesSupprimer.Location = new System.Drawing.Point(280, 104);
            this.btnProgrammesSupprimer.Name = "btnProgrammesSupprimer";
            this.btnProgrammesSupprimer.Size = new System.Drawing.Size(97, 36);
            this.btnProgrammesSupprimer.TabIndex = 3;
            this.btnProgrammesSupprimer.Text = "Supprimer";
            this.btnProgrammesSupprimer.UseVisualStyleBackColor = true;
            this.btnProgrammesSupprimer.Click += new System.EventHandler(this.btnProgrammesSupprimer_Click);
            // 
            // btnProgrammesAjouter
            // 
            this.btnProgrammesAjouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProgrammesAjouter.Location = new System.Drawing.Point(168, 104);
            this.btnProgrammesAjouter.Name = "btnProgrammesAjouter";
            this.btnProgrammesAjouter.Size = new System.Drawing.Size(97, 36);
            this.btnProgrammesAjouter.TabIndex = 2;
            this.btnProgrammesAjouter.Text = "Ajouter";
            this.btnProgrammesAjouter.UseVisualStyleBackColor = true;
            this.btnProgrammesAjouter.Click += new System.EventHandler(this.btnProgrammesAjouter_Click);
            // 
            // txtProgDesc
            // 
            this.txtProgDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProgDesc.Location = new System.Drawing.Point(301, 54);
            this.txtProgDesc.Name = "txtProgDesc";
            this.txtProgDesc.Size = new System.Drawing.Size(172, 29);
            this.txtProgDesc.TabIndex = 1;
            // 
            // txtProgNumero
            // 
            this.txtProgNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProgNumero.Location = new System.Drawing.Point(301, 14);
            this.txtProgNumero.Name = "txtProgNumero";
            this.txtProgNumero.Size = new System.Drawing.Size(172, 29);
            this.txtProgNumero.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(167, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEtudiant.ResumeLayout(false);
            this.tabEtudiant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEtudiant)).EndInit();
            this.tabProgramme.ResumeLayout(false);
            this.tabProgramme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabEtudiant;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TabPage tabProgramme;
        private DataGridView dgProg;
        private Button btnProgrammesAfficher;
        private Button btnProgrammesModifier;
        private Button btnProgrammesSupprimer;
        private Button btnProgrammesAjouter;
        private TextBox txtProgDesc;
        private TextBox txtProgNumero;
        private Label label2;
        private Label label1;
        private Button btnEtudiantAfficher;
        private Button btnEtudiantModifier;
        private Button btnEtudiantRechercher;
        private Button btnEtudiantSupprimer;
        private Button btnEtudiantAjouter;
        private DataGridView dgEtudiant;
        private ComboBox cmbEtudiantProg;
        private RadioButton rdAutre;
        private RadioButton rdFeminin;
        private RadioButton rdMasculin;
        private DateTimePicker dtBirthdayEtudiant;
        private TextBox txtAdresseEtudiant;
        private TextBox txtLastNameEtudiant;
        private TextBox txtFirstNameEtudiant;
        private TextBox txtNumEtudiant;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}