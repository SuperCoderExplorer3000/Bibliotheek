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
            btnBoekToevoegen.Size = new Size(233, 55);
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
            // Leeraar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnBoekToevoegen);
            Controls.Add(lbOverzicht);
            Name = "Leeraar";
            Text = "Leeraar";
            Load += Leeraar_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbOverzicht;
        private Button btnBoekToevoegen;
        private Button btnRefresh;
    }
}