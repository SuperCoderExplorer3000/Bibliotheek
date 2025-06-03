namespace Presentatie_Bibliotheek
{
    partial class frmGebruikersAdd
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbGebruikersnaam = new TextBox();
            tbNaam = new TextBox();
            tbVoornaam = new TextBox();
            tbEmail = new TextBox();
            tbRechtID = new TextBox();
            tbWachtwoord = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 70);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Wachtwoord";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 111);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Gebruikersnaam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 150);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Naam";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 189);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Voornaam";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 226);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 265);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "RechtID";
            // 
            // tbGebruikersnaam
            // 
            tbGebruikersnaam.Location = new Point(287, 108);
            tbGebruikersnaam.Name = "tbGebruikersnaam";
            tbGebruikersnaam.Size = new Size(382, 27);
            tbGebruikersnaam.TabIndex = 6;
            // 
            // tbNaam
            // 
            tbNaam.Location = new Point(287, 147);
            tbNaam.Name = "tbNaam";
            tbNaam.Size = new Size(382, 27);
            tbNaam.TabIndex = 7;
            // 
            // tbVoornaam
            // 
            tbVoornaam.Location = new Point(287, 186);
            tbVoornaam.Name = "tbVoornaam";
            tbVoornaam.Size = new Size(382, 27);
            tbVoornaam.TabIndex = 8;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(287, 223);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(382, 27);
            tbEmail.TabIndex = 9;
            // 
            // tbRechtID
            // 
            tbRechtID.Location = new Point(287, 262);
            tbRechtID.Name = "tbRechtID";
            tbRechtID.Size = new Size(382, 27);
            tbRechtID.TabIndex = 10;
            // 
            // tbWachtwoord
            // 
            tbWachtwoord.Location = new Point(287, 67);
            tbWachtwoord.Name = "tbWachtwoord";
            tbWachtwoord.Size = new Size(382, 27);
            tbWachtwoord.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(143, 307);
            button1.Name = "button1";
            button1.Size = new Size(526, 29);
            button1.TabIndex = 12;
            button1.Text = "Voeg Gebruiker Toe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmGebruikersAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tbWachtwoord);
            Controls.Add(tbRechtID);
            Controls.Add(tbEmail);
            Controls.Add(tbVoornaam);
            Controls.Add(tbNaam);
            Controls.Add(tbGebruikersnaam);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmGebruikersAdd";
            Text = "frmGebruikersAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbGebruikersnaam;
        private TextBox tbNaam;
        private TextBox tbVoornaam;
        private TextBox tbEmail;
        private TextBox tbRechtID;
        private TextBox tbWachtwoord;
        private Button button1;
    }
}