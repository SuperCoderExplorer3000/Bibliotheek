namespace Presentatie_Bibliotheek
{
    partial class frmGebruikers
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
            btnVoegToe = new Button();
            btnVerwijder = new Button();
            btnUpdate = new Button();
            lbGebruikers = new ListBox();
            btnRefresh = new Button();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // btnVoegToe
            // 
            btnVoegToe.Location = new Point(570, 22);
            btnVoegToe.Name = "btnVoegToe";
            btnVoegToe.Size = new Size(218, 53);
            btnVoegToe.TabIndex = 0;
            btnVoegToe.Text = "Voeg Gebruiker Toe";
            btnVoegToe.UseVisualStyleBackColor = true;
            btnVoegToe.Click += btnVoegToe_Click;
            // 
            // btnVerwijder
            // 
            btnVerwijder.Location = new Point(570, 81);
            btnVerwijder.Name = "btnVerwijder";
            btnVerwijder.Size = new Size(218, 54);
            btnVerwijder.TabIndex = 1;
            btnVerwijder.Text = "Verwijder Gebruiker";
            btnVerwijder.UseVisualStyleBackColor = true;
            btnVerwijder.Click += btnVerwijder_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(570, 141);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(218, 57);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update Gebruiker";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lbGebruikers
            // 
            lbGebruikers.FormattingEnabled = true;
            lbGebruikers.Location = new Point(28, 22);
            lbGebruikers.Name = "lbGebruikers";
            lbGebruikers.Size = new Size(524, 384);
            lbGebruikers.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(570, 365);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(108, 41);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(684, 365);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(104, 41);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // frmGebruikers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReturn);
            Controls.Add(btnRefresh);
            Controls.Add(lbGebruikers);
            Controls.Add(btnUpdate);
            Controls.Add(btnVerwijder);
            Controls.Add(btnVoegToe);
            Name = "frmGebruikers";
            Text = "frmGebruikers";
            Load += frmGebruikers_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoegToe;
        private Button btnVerwijder;
        private Button btnUpdate;
        private ListBox lbGebruikers;
        private Button btnRefresh;
        private Button btnReturn;
    }
}