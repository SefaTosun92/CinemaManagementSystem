namespace UserInterface
{
    partial class frmSellTickets
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblNameSurname = new System.Windows.Forms.Label();
            this.lblSaloon = new System.Windows.Forms.Label();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.btnSellTicket = new System.Windows.Forms.Button();
            this.comboBoxMovie = new System.Windows.Forms.ComboBox();
            this.comboBoxSession = new System.Windows.Forms.ComboBox();
            this.comboBoxSaloon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(65, 224);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Movie";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(65, 266);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(44, 13);
            this.lblSession.TabIndex = 1;
            this.lblSession.Text = "Session";
            // 
            // lblNameSurname
            // 
            this.lblNameSurname.AutoSize = true;
            this.lblNameSurname.Location = new System.Drawing.Point(437, 220);
            this.lblNameSurname.Name = "lblNameSurname";
            this.lblNameSurname.Size = new System.Drawing.Size(80, 13);
            this.lblNameSurname.TabIndex = 1;
            this.lblNameSurname.Text = "Name Surname";
            // 
            // lblSaloon
            // 
            this.lblSaloon.AutoSize = true;
            this.lblSaloon.Location = new System.Drawing.Point(65, 309);
            this.lblSaloon.Name = "lblSaloon";
            this.lblSaloon.Size = new System.Drawing.Size(40, 13);
            this.lblSaloon.TabIndex = 1;
            this.lblSaloon.Text = "Saloon";
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(523, 217);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(100, 20);
            this.txtNameSurname.TabIndex = 3;
            // 
            // btnSellTicket
            // 
            this.btnSellTicket.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSellTicket.Location = new System.Drawing.Point(440, 273);
            this.btnSellTicket.Name = "btnSellTicket";
            this.btnSellTicket.Size = new System.Drawing.Size(183, 51);
            this.btnSellTicket.TabIndex = 4;
            this.btnSellTicket.Text = "Sell Ticket";
            this.btnSellTicket.UseVisualStyleBackColor = false;
            // 
            // comboBoxMovie
            // 
            this.comboBoxMovie.FormattingEnabled = true;
            this.comboBoxMovie.Location = new System.Drawing.Point(147, 224);
            this.comboBoxMovie.Name = "comboBoxMovie";
            this.comboBoxMovie.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMovie.TabIndex = 5;
            // 
            // comboBoxSession
            // 
            this.comboBoxSession.FormattingEnabled = true;
            this.comboBoxSession.Location = new System.Drawing.Point(147, 266);
            this.comboBoxSession.Name = "comboBoxSession";
            this.comboBoxSession.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSession.TabIndex = 6;
            // 
            // comboBoxSaloon
            // 
            this.comboBoxSaloon.FormattingEnabled = true;
            this.comboBoxSaloon.Location = new System.Drawing.Point(147, 309);
            this.comboBoxSaloon.Name = "comboBoxSaloon";
            this.comboBoxSaloon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSaloon.TabIndex = 7;
            // 
            // frmSellTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.comboBoxSaloon);
            this.Controls.Add(this.comboBoxSession);
            this.Controls.Add(this.comboBoxMovie);
            this.Controls.Add(this.btnSellTicket);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.lblSaloon);
            this.Controls.Add(this.lblNameSurname);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSellTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellTickets";
            this.Load += new System.EventHandler(this.frmSellTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label lblNameSurname;
        private System.Windows.Forms.Label lblSaloon;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Button btnSellTicket;
        private System.Windows.Forms.ComboBox comboBoxMovie;
        private System.Windows.Forms.ComboBox comboBoxSession;
        private System.Windows.Forms.ComboBox comboBoxSaloon;
    }
}