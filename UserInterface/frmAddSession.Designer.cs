namespace UserInterface
{
    partial class frmAddSession
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
            this.lblAddMovieSession = new System.Windows.Forms.Label();
            this.txtAddMovieSession = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddMovieSession = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddMovieSession
            // 
            this.lblAddMovieSession.AutoSize = true;
            this.lblAddMovieSession.Location = new System.Drawing.Point(79, 81);
            this.lblAddMovieSession.Name = "lblAddMovieSession";
            this.lblAddMovieSession.Size = new System.Drawing.Size(76, 13);
            this.lblAddMovieSession.TabIndex = 0;
            this.lblAddMovieSession.Text = "Movie Session";
            // 
            // txtAddMovieSession
            // 
            this.txtAddMovieSession.Location = new System.Drawing.Point(172, 78);
            this.txtAddMovieSession.Name = "txtAddMovieSession";
            this.txtAddMovieSession.Size = new System.Drawing.Size(135, 20);
            this.txtAddMovieSession.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 149);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnAddMovieSession
            // 
            this.btnAddMovieSession.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMovieSession.Location = new System.Drawing.Point(351, 60);
            this.btnAddMovieSession.Name = "btnAddMovieSession";
            this.btnAddMovieSession.Size = new System.Drawing.Size(135, 55);
            this.btnAddMovieSession.TabIndex = 3;
            this.btnAddMovieSession.Text = "Add Session";
            this.btnAddMovieSession.UseVisualStyleBackColor = false;
            this.btnAddMovieSession.Click += new System.EventHandler(this.btnAddMovieSession_Click);
            // 
            // frmAddSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(550, 321);
            this.Controls.Add(this.btnAddMovieSession);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAddMovieSession);
            this.Controls.Add(this.lblAddMovieSession);
            this.Name = "frmAddSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Session";
            this.Load += new System.EventHandler(this.frmAddSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddMovieSession;
        private System.Windows.Forms.TextBox txtAddMovieSession;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddMovieSession;
    }
}