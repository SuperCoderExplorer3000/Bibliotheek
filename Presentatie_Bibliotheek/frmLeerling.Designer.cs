namespace Presentatie_Bibliotheek
{
    partial class frmLeerling
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
            tbSearch = new TextBox();
            btnRefresh = new Button();
            btnUitloggen = new Button();
            btnLenen = new Button();
            SuspendLayout();
            // 
            // lbOverzicht
            // 
            lbOverzicht.FormattingEnabled = true;
            lbOverzicht.ItemHeight = 15;
            lbOverzicht.Location = new Point(10, 9);
            lbOverzicht.Margin = new Padding(3, 2, 3, 2);
            lbOverzicht.Name = "lbOverzicht";
            lbOverzicht.Size = new Size(439, 289);
            lbOverzicht.TabIndex = 0;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(455, 135);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(233, 23);
            tbSearch.TabIndex = 1;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(455, 250);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 48);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnUitloggen
            // 
            btnUitloggen.Location = new Point(578, 250);
            btnUitloggen.Name = "btnUitloggen";
            btnUitloggen.Size = new Size(110, 48);
            btnUitloggen.TabIndex = 3;
            btnUitloggen.Text = "Log Uit";
            btnUitloggen.UseVisualStyleBackColor = true;
            btnUitloggen.Click += btnUitloggen_Click;
            // 
            // btnLenen
            // 
            btnLenen.Location = new Point(455, 9);
            btnLenen.Name = "btnLenen";
            btnLenen.Size = new Size(233, 39);
            btnLenen.TabIndex = 4;
            btnLenen.Text = "Boek Lenen";
            btnLenen.UseVisualStyleBackColor = true;
            btnLenen.Click += btnLenen_Click;
            // 
            // frmLeerling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnLenen);
            Controls.Add(btnUitloggen);
            Controls.Add(btnRefresh);
            Controls.Add(tbSearch);
            Controls.Add(lbOverzicht);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLeerling";
            Text = "frmLeerling";
            Load += frmLeerling_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbOverzicht;
        private TextBox tbSearch;
        private Button btnRefresh;
        private Button btnUitloggen;
        private Button btnLenen;
    }
}