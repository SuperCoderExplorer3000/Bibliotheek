namespace Presentatie_Bibliotheek
{
    partial class Leeraar
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
            lbOverzicht = new ListBox();
            btnBoekToevoegen = new Button();
            btnRefresh = new Button();
            btnUpdate = new Button();
            btnVerwijderen = new Button();
            btnGebruikers = new Button();
            btnLogUit = new Button();
            tbSearch = new TextBox();
            SuspendLayout();
            // 
            // lbOverzicht
            // 
            lbOverzicht.FormattingEnabled = true;
            lbOverzicht.Location = new Point(12, 12);
            lbOverzicht.Name = "lbOverzicht";
            lbOverzicht.Size = new Size(525, 404);
            lbOverzicht.TabIndex = 0;
            // 
            // btnBoekToevoegen
            // 
            btnBoekToevoegen.Location = new Point(555, 12);
            btnBoekToevoegen.Name = "btnBoekToevoegen";
            btnBoekToevoegen.Size = new Size(233, 40);
            btnBoekToevoegen.TabIndex = 1;
            btnBoekToevoegen.Text = "Voeg Boek Toe";
            btnBoekToevoegen.UseVisualStyleBackColor = true;
            btnBoekToevoegen.Click += btnBoekToevoegen_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(555, 362);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(96, 54);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(555, 58);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(233, 39);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnVerwijderen
            // 
            btnVerwijderen.Location = new Point(555, 103);
            btnVerwijderen.Name = "btnVerwijderen";
            btnVerwijderen.Size = new Size(233, 43);
            btnVerwijderen.TabIndex = 4;
            btnVerwijderen.Text = "Boek Verwijderen";
            btnVerwijderen.UseVisualStyleBackColor = true;
            btnVerwijderen.Click += btnVerwijderen_Click;
            // 
            // btnGebruikers
            // 
            btnGebruikers.Location = new Point(555, 152);
            btnGebruikers.Name = "btnGebruikers";
            btnGebruikers.Size = new Size(233, 41);
            btnGebruikers.TabIndex = 5;
            btnGebruikers.Text = "gebruikers";
            btnGebruikers.UseVisualStyleBackColor = true;
            btnGebruikers.Click += btnGebruikers_Click;
            // 
            // btnLogUit
            // 
            btnLogUit.Location = new Point(667, 362);
            btnLogUit.Name = "btnLogUit";
            btnLogUit.Size = new Size(95, 54);
            btnLogUit.TabIndex = 6;
            btnLogUit.Text = "Log Uit";
            btnLogUit.UseVisualStyleBackColor = true;
            btnLogUit.Click += btnLogUit_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(555, 242);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(233, 27);
            tbSearch.TabIndex = 7;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // Leeraar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbSearch);
            Controls.Add(btnLogUit);
            Controls.Add(btnGebruikers);
            Controls.Add(btnVerwijderen);
            Controls.Add(btnUpdate);
            Controls.Add(btnRefresh);
            Controls.Add(btnBoekToevoegen);
            Controls.Add(lbOverzicht);
            Name = "Leeraar";
            Text = "Leeraar";
            Load += Leeraar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbOverzicht;
        private Button btnBoekToevoegen;
        private Button btnRefresh;
        private Button btnUpdate;
        private Button btnVerwijderen;
        private Button btnGebruikers;
        private Button btnLogUit;
        private TextBox tbSearch;
    }
}