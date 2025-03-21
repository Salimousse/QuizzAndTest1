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
            this.dgv_questions = new System.Windows.Forms.DataGridView();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.pnl_bdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_bdd
            // 
            this.pnl_bdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_bdd.Controls.Add(this.btn_fermer);
            this.pnl_bdd.Controls.Add(this.dgv_questions);
            this.pnl_bdd.Location = new System.Drawing.Point(-1, -2);
            this.pnl_bdd.Name = "pnl_bdd";
            this.pnl_bdd.Size = new System.Drawing.Size(940, 475);
            this.pnl_bdd.TabIndex = 0;
            this.pnl_bdd.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_bdd_Paint);
            // 
            // dgv_questions
            // 
            this.dgv_questions.AllowUserToAddRows = false;
            this.dgv_questions.AllowUserToDeleteRows = false;
            this.dgv_questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_questions.Location = new System.Drawing.Point(13, 94);
            this.dgv_questions.Name = "dgv_questions";
            this.dgv_questions.ReadOnly = true;
            this.dgv_questions.Size = new System.Drawing.Size(629, 285);
            this.dgv_questions.TabIndex = 0;
            this.dgv_questions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(823, 94);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(28, 28);
            this.btn_fermer.TabIndex = 1;
            this.btn_fermer.Text = "X";
            this.btn_fermer.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_bdd;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.DataGridView dgv_questions;
    }
}