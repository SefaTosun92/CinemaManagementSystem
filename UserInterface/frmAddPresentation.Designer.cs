
namespace UserInterface
{
    partial class frmAddPresentation
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxSaloon = new System.Windows.Forms.ComboBox();
            this.comboBoxSession = new System.Windows.Forms.ComboBox();
            this.comboBoxMovie = new System.Windows.Forms.ComboBox();
            this.btnAddPresentation = new System.Windows.Forms.Button();
            this.lblSaloon = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.endPresentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSaloon
            // 
            this.comboBoxSaloon.FormattingEnabled = true;
            this.comboBoxSaloon.Location = new System.Drawing.Point(226, 336);
            this.comboBoxSaloon.Name = "comboBoxSaloon";
            this.comboBoxSaloon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSaloon.TabIndex = 17;
            // 
            // comboBoxSession
            // 
            this.comboBoxSession.FormattingEnabled = true;
            this.comboBoxSession.Location = new System.Drawing.Point(226, 293);
            this.comboBoxSession.Name = "comboBoxSession";
            this.comboBoxSession.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSession.TabIndex = 16;
            // 
            // comboBoxMovie
            // 
            this.comboBoxMovie.FormattingEnabled = true;
            this.comboBoxMovie.Location = new System.Drawing.Point(226, 251);
            this.comboBoxMovie.Name = "comboBoxMovie";
            this.comboBoxMovie.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMovie.TabIndex = 15;
            // 
            // btnAddPresentation
            // 
            this.btnAddPresentation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPresentation.Location = new System.Drawing.Point(472, 277);
            this.btnAddPresentation.Name = "btnAddPresentation";
            this.btnAddPresentation.Size = new System.Drawing.Size(183, 51);
            this.btnAddPresentation.TabIndex = 14;
            this.btnAddPresentation.Text = "Add Presentation";
            this.btnAddPresentation.UseVisualStyleBackColor = false;
            this.btnAddPresentation.Click += new System.EventHandler(this.btnAddPresentation_Click);
            // 
            // lblSaloon
            // 
            this.lblSaloon.AutoSize = true;
            this.lblSaloon.Location = new System.Drawing.Point(144, 336);
            this.lblSaloon.Name = "lblSaloon";
            this.lblSaloon.Size = new System.Drawing.Size(40, 13);
            this.lblSaloon.TabIndex = 9;
            this.lblSaloon.Text = "Saloon";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Location = new System.Drawing.Point(144, 293);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(44, 13);
            this.lblSession.TabIndex = 11;
            this.lblSession.Text = "Session";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(144, 251);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Movie";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endPresentationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 26);
            // 
            // endPresentationToolStripMenuItem
            // 
            this.endPresentationToolStripMenuItem.Name = "endPresentationToolStripMenuItem";
            this.endPresentationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.endPresentationToolStripMenuItem.Text = "End Presentation";
            // 
            // frmAddPresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxSaloon);
            this.Controls.Add(this.comboBoxSession);
            this.Controls.Add(this.comboBoxMovie);
            this.Controls.Add(this.btnAddPresentation);
            this.Controls.Add(this.lblSaloon);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAddPresentation";
            this.Text = "frmAddPresentation";
            this.Load += new System.EventHandler(this.frmAddPresentation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSaloon;
        private System.Windows.Forms.ComboBox comboBoxSession;
        private System.Windows.Forms.ComboBox comboBoxMovie;
        private System.Windows.Forms.Button btnAddPresentation;
        private System.Windows.Forms.Label lblSaloon;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem endPresentationToolStripMenuItem;
    }
}