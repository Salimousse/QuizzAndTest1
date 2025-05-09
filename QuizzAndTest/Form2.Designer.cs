namespace QuizzAndTest
{
    partial class Form2
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
            this.pnl_bdd = new System.Windows.Forms.Panel();
            this.gb_recherche = new System.Windows.Forms.GroupBox();
            this.lbl_difficulte = new System.Windows.Forms.Label();
            this.lbl_recherche = new System.Windows.Forms.Label();
            this.txt_recherche = new System.Windows.Forms.TextBox();
            this.cb_difficulte = new System.Windows.Forms.ComboBox();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.dgv_questions = new System.Windows.Forms.DataGridView();
            this.pnl_bdd.SuspendLayout();
            this.gb_recherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_bdd
            // 
            this.pnl_bdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_bdd.Controls.Add(this.gb_recherche);
            this.pnl_bdd.Controls.Add(this.btn_fermer);
            this.pnl_bdd.Controls.Add(this.dgv_questions);
            this.pnl_bdd.Location = new System.Drawing.Point(-1, -2);
            this.pnl_bdd.Name = "pnl_bdd";
            this.pnl_bdd.Size = new System.Drawing.Size(1079, 584);
            this.pnl_bdd.TabIndex = 0;
            this.pnl_bdd.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_bdd_Paint);
            // 
            // gb_recherche
            // 
            this.gb_recherche.Controls.Add(this.lbl_difficulte);
            this.gb_recherche.Controls.Add(this.lbl_recherche);
            this.gb_recherche.Controls.Add(this.txt_recherche);
            this.gb_recherche.Controls.Add(this.cb_difficulte);
            this.gb_recherche.Location = new System.Drawing.Point(336, 14);
            this.gb_recherche.Name = "gb_recherche";
            this.gb_recherche.Size = new System.Drawing.Size(435, 100);
            this.gb_recherche.TabIndex = 2;
            this.gb_recherche.TabStop = false;
            this.gb_recherche.Text = "Recherche";
            // 
            // lbl_difficulte
            // 
            this.lbl_difficulte.AutoSize = true;
            this.lbl_difficulte.Location = new System.Drawing.Point(43, 61);
            this.lbl_difficulte.Name = "lbl_difficulte";
            this.lbl_difficulte.Size = new System.Drawing.Size(48, 13);
            this.lbl_difficulte.TabIndex = 3;
            this.lbl_difficulte.Text = "Difficulte";
            // 
            // lbl_recherche
            // 
            this.lbl_recherche.AutoSize = true;
            this.lbl_recherche.Location = new System.Drawing.Point(23, 22);
            this.lbl_recherche.Name = "lbl_recherche";
            this.lbl_recherche.Size = new System.Drawing.Size(100, 13);
            this.lbl_recherche.TabIndex = 2;
            this.lbl_recherche.Text = "Recherche de mots";
            // 
            // txt_recherche
            // 
            this.txt_recherche.Location = new System.Drawing.Point(167, 19);
            this.txt_recherche.Name = "txt_recherche";
            this.txt_recherche.Size = new System.Drawing.Size(218, 20);
            this.txt_recherche.TabIndex = 1;
            this.txt_recherche.TextChanged += new System.EventHandler(this.txt_recherche_TextChanged);
            // 
            // cb_difficulte
            // 
            this.cb_difficulte.FormattingEnabled = true;
            this.cb_difficulte.Items.AddRange(new object[] {
            ""});
            this.cb_difficulte.Location = new System.Drawing.Point(167, 61);
            this.cb_difficulte.Name = "cb_difficulte";
            this.cb_difficulte.Size = new System.Drawing.Size(218, 21);
            this.cb_difficulte.TabIndex = 0;
            this.cb_difficulte.SelectionChangeCommitted += new System.EventHandler(this.cb_difficulte_SelectionChangeCommitted);
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(823, 94);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(28, 28);
            this.btn_fermer.TabIndex = 1;
            this.btn_fermer.Text = "X";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // dgv_questions
            // 
            this.dgv_questions.AllowUserToAddRows = false;
            this.dgv_questions.AllowUserToDeleteRows = false;
            this.dgv_questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_questions.Location = new System.Drawing.Point(13, 150);
            this.dgv_questions.Name = "dgv_questions";
            this.dgv_questions.ReadOnly = true;
            this.dgv_questions.Size = new System.Drawing.Size(732, 292);
            this.dgv_questions.TabIndex = 0;
            this.dgv_questions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 483);
            this.Controls.Add(this.pnl_bdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.pnl_bdd.ResumeLayout(false);
            this.gb_recherche.ResumeLayout(false);
            this.gb_recherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_bdd;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.DataGridView dgv_questions;
        private System.Windows.Forms.GroupBox gb_recherche;
        private System.Windows.Forms.Label lbl_difficulte;
        private System.Windows.Forms.Label lbl_recherche;
        private System.Windows.Forms.TextBox txt_recherche;
        private System.Windows.Forms.ComboBox cb_difficulte;
    }
}