namespace prjCsWinRevenue
{
    partial class frmRevenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblresultat = new System.Windows.Forms.Label();
            this.chkoui = new System.Windows.Forms.CheckBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculer = new System.Windows.Forms.Button();
            this.txtnbeenfants = new System.Windows.Forms.TextBox();
            this.txtsalaire = new System.Windows.Forms.TextBox();
            this.radfemme = new System.Windows.Forms.RadioButton();
            this.radhomme = new System.Windows.Forms.RadioButton();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lblgenre = new System.Windows.Forms.Label();
            this.lblsalaire = new System.Windows.Forms.Label();
            this.lblmatrimonial = new System.Windows.Forms.Label();
            this.lblenfant = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.lblresultat);
            this.groupBox1.Controls.Add(this.chkoui);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btncalculer);
            this.groupBox1.Controls.Add(this.txtnbeenfants);
            this.groupBox1.Controls.Add(this.txtsalaire);
            this.groupBox1.Controls.Add(this.radfemme);
            this.groupBox1.Controls.Add(this.radhomme);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Controls.Add(this.lblgenre);
            this.groupBox1.Controls.Add(this.lblsalaire);
            this.groupBox1.Controls.Add(this.lblmatrimonial);
            this.groupBox1.Controls.Add(this.lblenfant);
            this.groupBox1.Controls.Add(this.lblnom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 582);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations du citoyen";
            // 
            // lblresultat
            // 
            this.lblresultat.BackColor = System.Drawing.Color.White;
            this.lblresultat.Location = new System.Drawing.Point(24, 404);
            this.lblresultat.Name = "lblresultat";
            this.lblresultat.Size = new System.Drawing.Size(726, 175);
            this.lblresultat.TabIndex = 13;
            // 
            // chkoui
            // 
            this.chkoui.AutoSize = true;
            this.chkoui.Location = new System.Drawing.Point(292, 242);
            this.chkoui.Name = "chkoui";
            this.chkoui.Size = new System.Drawing.Size(70, 30);
            this.chkoui.TabIndex = 12;
            this.chkoui.Text = "oui";
            this.chkoui.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(550, 325);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(171, 58);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalculer
            // 
            this.btncalculer.Location = new System.Drawing.Point(24, 325);
            this.btncalculer.Name = "btncalculer";
            this.btncalculer.Size = new System.Drawing.Size(164, 58);
            this.btncalculer.TabIndex = 10;
            this.btncalculer.Text = "calculer";
            this.btncalculer.UseVisualStyleBackColor = true;
            this.btncalculer.Click += new System.EventHandler(this.btncalculer_Click);
            // 
            // txtnbeenfants
            // 
            this.txtnbeenfants.Location = new System.Drawing.Point(292, 281);
            this.txtnbeenfants.Name = "txtnbeenfants";
            this.txtnbeenfants.Size = new System.Drawing.Size(200, 32);
            this.txtnbeenfants.TabIndex = 9;
            // 
            // txtsalaire
            // 
            this.txtsalaire.Location = new System.Drawing.Point(292, 189);
            this.txtsalaire.Name = "txtsalaire";
            this.txtsalaire.Size = new System.Drawing.Size(182, 32);
            this.txtsalaire.TabIndex = 8;
            // 
            // radfemme
            // 
            this.radfemme.AutoSize = true;
            this.radfemme.Location = new System.Drawing.Point(292, 151);
            this.radfemme.Name = "radfemme";
            this.radfemme.Size = new System.Drawing.Size(110, 30);
            this.radfemme.TabIndex = 7;
            this.radfemme.TabStop = true;
            this.radfemme.Text = "femme";
            this.radfemme.UseVisualStyleBackColor = true;
            // 
            // radhomme
            // 
            this.radhomme.AutoSize = true;
            this.radhomme.Checked = true;
            this.radhomme.Location = new System.Drawing.Point(292, 99);
            this.radhomme.Name = "radhomme";
            this.radhomme.Size = new System.Drawing.Size(116, 30);
            this.radhomme.TabIndex = 6;
            this.radhomme.TabStop = true;
            this.radhomme.Text = "homme";
            this.radhomme.UseVisualStyleBackColor = true;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(292, 54);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(458, 32);
            this.txtnom.TabIndex = 5;
            // 
            // lblgenre
            // 
            this.lblgenre.AutoSize = true;
            this.lblgenre.Location = new System.Drawing.Point(100, 98);
            this.lblgenre.Name = "lblgenre";
            this.lblgenre.Size = new System.Drawing.Size(168, 26);
            this.lblgenre.TabIndex = 4;
            this.lblgenre.Text = "Choisir genre :";
            // 
            // lblsalaire
            // 
            this.lblsalaire.AutoSize = true;
            this.lblsalaire.Location = new System.Drawing.Point(32, 192);
            this.lblsalaire.Name = "lblsalaire";
            this.lblsalaire.Size = new System.Drawing.Size(236, 26);
            this.lblsalaire.TabIndex = 3;
            this.lblsalaire.Text = "Entrer votre salaire  :";
            // 
            // lblmatrimonial
            // 
            this.lblmatrimonial.AutoSize = true;
            this.lblmatrimonial.Location = new System.Drawing.Point(19, 246);
            this.lblmatrimonial.Name = "lblmatrimonial";
            this.lblmatrimonial.Size = new System.Drawing.Size(249, 26);
            this.lblmatrimonial.TabIndex = 2;
            this.lblmatrimonial.Text = "Etes-vous marrie(e)  ?";
            // 
            // lblenfant
            // 
            this.lblenfant.AutoSize = true;
            this.lblenfant.Location = new System.Drawing.Point(42, 287);
            this.lblenfant.Name = "lblenfant";
            this.lblenfant.Size = new System.Drawing.Size(226, 26);
            this.lblenfant.TabIndex = 1;
            this.lblenfant.Text = "Combien d enfants :";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(64, 54);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(204, 26);
            this.lblnom.TabIndex = 0;
            this.lblnom.Text = "Entrer votre nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "REVENU-QUEBEC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(617, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deductions Benefits Calculation";
            // 
            // frmRevenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 699);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRevenu";
            this.Text = "frmRevenu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblgenre;
        private System.Windows.Forms.Label lblsalaire;
        private System.Windows.Forms.Label lblmatrimonial;
        private System.Windows.Forms.Label lblenfant;
        private System.Windows.Forms.RadioButton radfemme;
        private System.Windows.Forms.RadioButton radhomme;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtnbeenfants;
        private System.Windows.Forms.TextBox txtsalaire;
        private System.Windows.Forms.Button btncalculer;
        private System.Windows.Forms.Label lblresultat;
        private System.Windows.Forms.CheckBox chkoui;
        private System.Windows.Forms.Button btnclear;
    }
}