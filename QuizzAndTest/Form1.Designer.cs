namespace QuizzAndTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_difficulte = new System.Windows.Forms.Label();
            this.cb_difficulte = new System.Windows.Forms.ComboBox();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(273, 99);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(29, 13);
            this.lbl_nom.TabIndex = 1;
            this.lbl_nom.Text = "Nom";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(273, 158);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(43, 13);
            this.lbl_prenom.TabIndex = 2;
            this.lbl_prenom.Text = "Prénom";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(375, 96);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(207, 20);
            this.txt_nom.TabIndex = 4;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(375, 151);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(207, 20);
            this.txt_prenom.TabIndex = 5;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(441, 274);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 6;
            this.btn_valider.Text = "Push Me";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // lbl_difficulte
            // 
            this.lbl_difficulte.AutoSize = true;
            this.lbl_difficulte.Location = new System.Drawing.Point(273, 223);
            this.lbl_difficulte.Name = "lbl_difficulte";
            this.lbl_difficulte.Size = new System.Drawing.Size(48, 13);
            this.lbl_difficulte.TabIndex = 7;
            this.lbl_difficulte.Text = "Difficulté";
            // 
            // cb_difficulte
            // 
            this.cb_difficulte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_difficulte.FormattingEnabled = true;
            this.cb_difficulte.Location = new System.Drawing.Point(375, 215);
            this.cb_difficulte.Name = "cb_difficulte";
            this.cb_difficulte.Size = new System.Drawing.Size(207, 21);
            this.cb_difficulte.TabIndex = 8;
            this.cb_difficulte.SelectedIndexChanged += new System.EventHandler(this.difficulte_SelectedIndexChanged);
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(774, 92);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(28, 20);
            this.btn_fermer.TabIndex = 9;
            this.btn_fermer.Text = "X";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 475);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.cb_difficulte);
            this.Controls.Add(this.lbl_difficulte);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Mon 1er formulaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lbl_difficulte;
        private System.Windows.Forms.ComboBox cb_difficulte;
        private System.Windows.Forms.Button btn_fermer;
    }
}

