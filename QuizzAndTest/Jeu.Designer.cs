﻿namespace QuizzAndTest
{
    partial class Jeu
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
            this.label1 = new System.Windows.Forms.Label();
            this.gd_reponse = new System.Windows.Forms.GroupBox();
            this.ckb_reponse5 = new System.Windows.Forms.CheckBox();
            this.ckb_reponse4 = new System.Windows.Forms.CheckBox();
            this.ckb_reponse3 = new System.Windows.Forms.CheckBox();
            this.ckb_reponse2 = new System.Windows.Forms.CheckBox();
            this.ckb_reponse1 = new System.Windows.Forms.CheckBox();
            this.txt_timer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.txt_affichage = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_joueur = new System.Windows.Forms.TextBox();
            this.txt_diff = new System.Windows.Forms.TextBox();
            this.lbl_joueur = new System.Windows.Forms.Label();
            this.lbl_difficulte = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pgb_tpsQuestion = new System.Windows.Forms.ProgressBar();
            this.pb_question = new System.Windows.Forms.PictureBox();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.gd_reponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quizz And Test";
            // 
            // gd_reponse
            // 
            this.gd_reponse.Controls.Add(this.ckb_reponse5);
            this.gd_reponse.Controls.Add(this.ckb_reponse4);
            this.gd_reponse.Controls.Add(this.ckb_reponse3);
            this.gd_reponse.Controls.Add(this.ckb_reponse2);
            this.gd_reponse.Controls.Add(this.ckb_reponse1);
            this.gd_reponse.Location = new System.Drawing.Point(22, 183);
            this.gd_reponse.Name = "gd_reponse";
            this.gd_reponse.Size = new System.Drawing.Size(488, 197);
            this.gd_reponse.TabIndex = 1;
            this.gd_reponse.TabStop = false;
            this.gd_reponse.Text = "Réponses possibles";
            // 
            // ckb_reponse5
            // 
            this.ckb_reponse5.AutoSize = true;
            this.ckb_reponse5.Location = new System.Drawing.Point(7, 168);
            this.ckb_reponse5.Name = "ckb_reponse5";
            this.ckb_reponse5.Size = new System.Drawing.Size(78, 17);
            this.ckb_reponse5.TabIndex = 4;
            this.ckb_reponse5.Text = "Réponse 5";
            this.ckb_reponse5.UseVisualStyleBackColor = true;
            this.ckb_reponse5.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // ckb_reponse4
            // 
            this.ckb_reponse4.AutoSize = true;
            this.ckb_reponse4.Location = new System.Drawing.Point(7, 129);
            this.ckb_reponse4.Name = "ckb_reponse4";
            this.ckb_reponse4.Size = new System.Drawing.Size(78, 17);
            this.ckb_reponse4.TabIndex = 3;
            this.ckb_reponse4.Text = "Réponse 4";
            this.ckb_reponse4.UseVisualStyleBackColor = true;
            this.ckb_reponse4.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // ckb_reponse3
            // 
            this.ckb_reponse3.AutoSize = true;
            this.ckb_reponse3.Location = new System.Drawing.Point(6, 95);
            this.ckb_reponse3.Name = "ckb_reponse3";
            this.ckb_reponse3.Size = new System.Drawing.Size(78, 17);
            this.ckb_reponse3.TabIndex = 2;
            this.ckb_reponse3.Text = "Réponse 3";
            this.ckb_reponse3.UseVisualStyleBackColor = true;
            this.ckb_reponse3.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // ckb_reponse2
            // 
            this.ckb_reponse2.AutoSize = true;
            this.ckb_reponse2.Location = new System.Drawing.Point(7, 60);
            this.ckb_reponse2.Name = "ckb_reponse2";
            this.ckb_reponse2.Size = new System.Drawing.Size(78, 17);
            this.ckb_reponse2.TabIndex = 1;
            this.ckb_reponse2.Text = "Réponse 2";
            this.ckb_reponse2.UseVisualStyleBackColor = true;
            this.ckb_reponse2.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // ckb_reponse1
            // 
            this.ckb_reponse1.AutoSize = true;
            this.ckb_reponse1.Location = new System.Drawing.Point(7, 20);
            this.ckb_reponse1.Name = "ckb_reponse1";
            this.ckb_reponse1.Size = new System.Drawing.Size(78, 17);
            this.ckb_reponse1.TabIndex = 0;
            this.ckb_reponse1.Text = "Réponse 1";
            this.ckb_reponse1.UseVisualStyleBackColor = true;
            this.ckb_reponse1.Click += new System.EventHandler(this.ckb_reponse1_Click);
            // 
            // txt_timer
            // 
            this.txt_timer.Location = new System.Drawing.Point(660, 27);
            this.txt_timer.Name = "txt_timer";
            this.txt_timer.Size = new System.Drawing.Size(174, 20);
            this.txt_timer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temps total";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(387, 395);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(100, 23);
            this.btn_valider.TabIndex = 5;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // txt_affichage
            // 
            this.txt_affichage.Location = new System.Drawing.Point(22, 125);
            this.txt_affichage.Multiline = true;
            this.txt_affichage.Name = "txt_affichage";
            this.txt_affichage.Size = new System.Drawing.Size(488, 52);
            this.txt_affichage.TabIndex = 6;
            this.txt_affichage.Text = " ";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(36, 100);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(54, 13);
            this.lbl_numero.TabIndex = 7;
            this.lbl_numero.Text = "Questions";
            // 
            // txt_joueur
            // 
            this.txt_joueur.Location = new System.Drawing.Point(660, 333);
            this.txt_joueur.Name = "txt_joueur";
            this.txt_joueur.Size = new System.Drawing.Size(162, 20);
            this.txt_joueur.TabIndex = 8;
            // 
            // txt_diff
            // 
            this.txt_diff.Location = new System.Drawing.Point(660, 395);
            this.txt_diff.Name = "txt_diff";
            this.txt_diff.Size = new System.Drawing.Size(162, 20);
            this.txt_diff.TabIndex = 9;
            // 
            // lbl_joueur
            // 
            this.lbl_joueur.AutoSize = true;
            this.lbl_joueur.Location = new System.Drawing.Point(657, 312);
            this.lbl_joueur.Name = "lbl_joueur";
            this.lbl_joueur.Size = new System.Drawing.Size(39, 13);
            this.lbl_joueur.TabIndex = 10;
            this.lbl_joueur.Text = "Joueur";
            this.lbl_joueur.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_difficulte
            // 
            this.lbl_difficulte.AutoSize = true;
            this.lbl_difficulte.Location = new System.Drawing.Point(657, 367);
            this.lbl_difficulte.Name = "lbl_difficulte";
            this.lbl_difficulte.Size = new System.Drawing.Size(48, 13);
            this.lbl_difficulte.TabIndex = 11;
            this.lbl_difficulte.Text = "Difficulté";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Temps de réponse à la question ";
            // 
            // pgb_tpsQuestion
            // 
            this.pgb_tpsQuestion.Location = new System.Drawing.Point(660, 268);
            this.pgb_tpsQuestion.Maximum = 15;
            this.pgb_tpsQuestion.Name = "pgb_tpsQuestion";
            this.pgb_tpsQuestion.Size = new System.Drawing.Size(158, 23);
            this.pgb_tpsQuestion.TabIndex = 13;
            // 
            // pb_question
            // 
            this.pb_question.Image = global::QuizzAndTest.Properties.Resources.Interrogation;
            this.pb_question.Location = new System.Drawing.Point(660, 53);
            this.pb_question.Name = "pb_question";
            this.pb_question.Size = new System.Drawing.Size(174, 195);
            this.pb_question.TabIndex = 4;
            this.pb_question.TabStop = false;
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(863, 27);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(28, 28);
            this.btn_fermer.TabIndex = 14;
            this.btn_fermer.Text = "X";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(940, 475);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.pgb_tpsQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_difficulte);
            this.Controls.Add(this.lbl_joueur);
            this.Controls.Add(this.txt_diff);
            this.Controls.Add(this.txt_joueur);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.txt_affichage);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.pb_question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_timer);
            this.Controls.Add(this.gd_reponse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.Load += new System.EventHandler(this.Jeu_Load);
            this.gd_reponse.ResumeLayout(false);
            this.gd_reponse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_question)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gd_reponse;
        private System.Windows.Forms.CheckBox ckb_reponse5;
        private System.Windows.Forms.CheckBox ckb_reponse4;
        private System.Windows.Forms.CheckBox ckb_reponse3;
        private System.Windows.Forms.CheckBox ckb_reponse2;
        private System.Windows.Forms.CheckBox ckb_reponse1;
        private System.Windows.Forms.TextBox txt_timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_question;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.TextBox txt_affichage;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_joueur;
        private System.Windows.Forms.TextBox txt_diff;
        private System.Windows.Forms.Label lbl_joueur;
        private System.Windows.Forms.Label lbl_difficulte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pgb_tpsQuestion;
        private System.Windows.Forms.Button btn_fermer;
    }
}