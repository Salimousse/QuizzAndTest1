﻿namespace QuizzAndTest
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
            this.lbl_rep = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.txt_afficher = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_difficulte = new System.Windows.Forms.Label();
            this.difficulte = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_rep
            // 
            this.lbl_rep.AutoSize = true;
            this.lbl_rep.Location = new System.Drawing.Point(76, 57);
            this.lbl_rep.Name = "lbl_rep";
            this.lbl_rep.Size = new System.Drawing.Size(50, 13);
            this.lbl_rep.TabIndex = 0;
            this.lbl_rep.Text = "Réponse";
            this.lbl_rep.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(76, 129);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(29, 13);
            this.lbl_nom.TabIndex = 1;
            this.lbl_nom.Text = "Nom";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(76, 201);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(43, 13);
            this.lbl_prenom.TabIndex = 2;
            this.lbl_prenom.Text = "Prénom";
            // 
            // txt_afficher
            // 
            this.txt_afficher.Enabled = false;
            this.txt_afficher.Location = new System.Drawing.Point(200, 57);
            this.txt_afficher.Name = "txt_afficher";
            this.txt_afficher.Size = new System.Drawing.Size(207, 20);
            this.txt_afficher.TabIndex = 3;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(200, 129);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(207, 20);
            this.txt_nom.TabIndex = 4;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(200, 201);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(207, 20);
            this.txt_prenom.TabIndex = 5;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(230, 305);
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
            this.lbl_difficulte.Location = new System.Drawing.Point(79, 245);
            this.lbl_difficulte.Name = "lbl_difficulte";
            this.lbl_difficulte.Size = new System.Drawing.Size(48, 13);
            this.lbl_difficulte.TabIndex = 7;
            this.lbl_difficulte.Text = "Difficulté";
            this.lbl_difficulte.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // difficulte
            // 
            this.difficulte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficulte.FormattingEnabled = true;
            this.difficulte.Location = new System.Drawing.Point(200, 245);
            this.difficulte.Name = "difficulte";
            this.difficulte.Size = new System.Drawing.Size(207, 21);
            this.difficulte.TabIndex = 8;
            this.difficulte.SelectedIndexChanged += new System.EventHandler(this.difficulte_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.difficulte);
            this.Controls.Add(this.lbl_difficulte);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_afficher);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.lbl_rep);
            this.Name = "Form1";
            this.Text = "Mon 1er formulaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rep;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.TextBox txt_afficher;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lbl_difficulte;
        private System.Windows.Forms.ComboBox difficulte;
    }
}

