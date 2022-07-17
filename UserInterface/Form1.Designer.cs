namespace UserInterface
{
    partial class Form1
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
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.btnSellTickets = new System.Windows.Forms.Button();
            this.btnAddSaloon = new System.Windows.Forms.Button();
            this.buttonPresentation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFilm.Location = new System.Drawing.Point(45, 93);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(140, 64);
            this.btnAddFilm.TabIndex = 0;
            this.btnAddFilm.Text = "Add Film";
            this.btnAddFilm.UseVisualStyleBackColor = false;
            this.btnAddFilm.Click += new System.EventHandler(this.btnAddFilm_Click);
            // 
            // btnAddSession
            // 
            this.btnAddSession.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSession.Location = new System.Drawing.Point(212, 93);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(140, 64);
            this.btnAddSession.TabIndex = 0;
            this.btnAddSession.Text = "Add Session";
            this.btnAddSession.UseVisualStyleBackColor = false;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // btnSellTickets
            // 
            this.btnSellTickets.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSellTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellTickets.Location = new System.Drawing.Point(45, 191);
            this.btnSellTickets.Name = "btnSellTickets";
            this.btnSellTickets.Size = new System.Drawing.Size(471, 64);
            this.btnSellTickets.TabIndex = 0;
            this.btnSellTickets.Text = "Sell Tickets";
            this.btnSellTickets.UseVisualStyleBackColor = false;
            this.btnSellTickets.Click += new System.EventHandler(this.btnSellTickets_Click);
            // 
            // btnAddSaloon
            // 
            this.btnAddSaloon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSaloon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSaloon.Location = new System.Drawing.Point(376, 93);
            this.btnAddSaloon.Name = "btnAddSaloon";
            this.btnAddSaloon.Size = new System.Drawing.Size(140, 64);
            this.btnAddSaloon.TabIndex = 1;
            this.btnAddSaloon.Text = "Add Saloon";
            this.btnAddSaloon.UseVisualStyleBackColor = false;
            this.btnAddSaloon.Click += new System.EventHandler(this.btnAddSaloon_Click);
            // 
            // buttonPresentation
            // 
            this.buttonPresentation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPresentation.Location = new System.Drawing.Point(212, 12);
            this.buttonPresentation.Name = "buttonPresentation";
            this.buttonPresentation.Size = new System.Drawing.Size(140, 64);
            this.buttonPresentation.TabIndex = 2;
            this.buttonPresentation.Text = "Presentation";
            this.buttonPresentation.UseVisualStyleBackColor = false;
            this.buttonPresentation.Click += new System.EventHandler(this.buttonPresentation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(565, 334);
            this.Controls.Add(this.buttonPresentation);
            this.Controls.Add(this.btnAddSaloon);
            this.Controls.Add(this.btnSellTickets);
            this.Controls.Add(this.btnAddSession);
            this.Controls.Add(this.btnAddFilm);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Button btnSellTickets;
        private System.Windows.Forms.Button btnAddSaloon;
        private System.Windows.Forms.Button buttonPresentation;
    }
}

