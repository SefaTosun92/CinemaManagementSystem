namespace UserInterface
{
    partial class frmAddSaloon
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
            this.lblSaloon = new System.Windows.Forms.Label();
            this.txtAddMovieSaloon = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddMovieSaloon = new System.Windows.Forms.Button();
            this.textBoxSeatNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaloon
            // 
            this.lblSaloon.AutoSize = true;
            this.lblSaloon.Location = new System.Drawing.Point(93, 80);
            this.lblSaloon.Name = "lblSaloon";
            this.lblSaloon.Size = new System.Drawing.Size(40, 13);
            this.lblSaloon.TabIndex = 0;
            this.lblSaloon.Text = "Saloon";
            // 
            // txtAddMovieSaloon
            // 
            this.txtAddMovieSaloon.Location = new System.Drawing.Point(146, 77);
            this.txtAddMovieSaloon.Name = "txtAddMovieSaloon";
            this.txtAddMovieSaloon.Size = new System.Drawing.Size(134, 20);
            this.txtAddMovieSaloon.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 151);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnAddMovieSaloon
            // 
            this.btnAddMovieSaloon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMovieSaloon.Location = new System.Drawing.Point(330, 80);
            this.btnAddMovieSaloon.Name = "btnAddMovieSaloon";
            this.btnAddMovieSaloon.Size = new System.Drawing.Size(132, 49);
            this.btnAddMovieSaloon.TabIndex = 3;
            this.btnAddMovieSaloon.Text = "Add Saloon";
            this.btnAddMovieSaloon.UseVisualStyleBackColor = false;
            this.btnAddMovieSaloon.Click += new System.EventHandler(this.btnAddMovieSaloon_Click);
            // 
            // textBoxSeatNo
            // 
            this.textBoxSeatNo.Location = new System.Drawing.Point(146, 112);
            this.textBoxSeatNo.Name = "textBoxSeatNo";
            this.textBoxSeatNo.Size = new System.Drawing.Size(134, 20);
            this.textBoxSeatNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SeatNo";
            // 
            // frmAddSaloon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(534, 316);
            this.Controls.Add(this.textBoxSeatNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddMovieSaloon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAddMovieSaloon);
            this.Controls.Add(this.lblSaloon);
            this.Name = "frmAddSaloon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSaloon";
            this.Load += new System.EventHandler(this.frmAddSaloon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaloon;
        private System.Windows.Forms.TextBox txtAddMovieSaloon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddMovieSaloon;
        private System.Windows.Forms.TextBox textBoxSeatNo;
        private System.Windows.Forms.Label label1;
    }
}