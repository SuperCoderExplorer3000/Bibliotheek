namespace Presentatie_Bibliotheek
{
    partial class frmGebruikersUpdate
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
            label1 = new Label();
            tbWachtwoord = new TextBox();
            tbRechtID = new TextBox();
            tbEmail = new TextBox();
            tbVoornaam = new TextBox();
            tbNaam = new TextBox();
            tbGebruikersnaam = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tbGebruikersID = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 54);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Gebruikers ID";
            // 
            // tbWachtwoord
            // 
            tbWachtwoord.Location = new Point(293, 102);
            tbWachtwoord.Name = "tbWachtwoord";
            tbWachtwoord.Size = new Size(382, 27);
            tbWachtwoord.TabIndex = 23;
            // 
            // tbRechtID
            // 
            tbRechtID.Location = new Point(293, 297);
            tbRechtID.Name = "tbRechtID";
            tbRechtID.Size = new Size(382, 27);
            tbRechtID.TabIndex = 22;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(293, 258);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(382, 27);
            tbEmail.TabIndex = 21;
            // 
            // tbVoornaam
            // 
            tbVoornaam.Location = new Point(293, 221);
            tbVoornaam.Name = "tbVoornaam";
            tbVoornaam.Size = new Size(382, 27);
            tbVoornaam.TabIndex = 20;
            // 
            // tbNaam
            // 
            tbNaam.Location = new Point(293, 182);
            tbNaam.Name = "tbNaam";
            tbNaam.Size = new Size(382, 27);
            tbNaam.TabIndex = 19;
            // 
            // tbGebruikersnaam
            // 
            tbGebruikersnaam.Location = new Point(293, 143);
            tbGebruikersnaam.Name = "tbGebruikersnaam";
            tbGebruikersnaam.Size = new Size(382, 27);
            tbGebruikersnaam.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(149, 300);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 17;
            label8.Text = "RechtID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(149, 261);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 16;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(149, 224);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 15;
            label10.Text = "Voornaam";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(149, 185);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 14;
            label11.Text = "Naam";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(149, 146);
            label12.Name = "label12";
            label12.Size = new Size(116, 20);
            label12.TabIndex = 13;
            label12.Text = "Gebruikersnaam";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(149, 105);
            label13.Name = "label13";
            label13.Size = new Size(93, 20);
            label13.TabIndex = 12;
            label13.Text = "Wachtwoord";
            // 
            // tbGebruikersID
            // 
            tbGebruikersID.Location = new Point(293, 51);
            tbGebruikersID.Name = "tbGebruikersID";
            tbGebruikersID.Size = new Size(73, 27);
            tbGebruikersID.TabIndex = 24;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(149, 344);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(526, 29);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update Gebruiker";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmGebruikersUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(tbGebruikersID);
            Controls.Add(tbWachtwoord);
            Controls.Add(tbRechtID);
            Controls.Add(tbEmail);
            Controls.Add(tbVoornaam);
            Controls.Add(tbNaam);
            Controls.Add(tbGebruikersnaam);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label1);
            Name = "frmGebruikersUpdate";
            Text = "frmGebruikersUpdate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbWachtwoord;
        private TextBox tbRechtID;
        private TextBox tbEmail;
        private TextBox tbVoornaam;
        private TextBox tbNaam;
        private TextBox tbGebruikersnaam;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox tbGebruikersID;
        private Button btnUpdate;
    }
}