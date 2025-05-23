namespace Presentatie_Bibliotheek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLogIn = new Button();
            tbNaam = new TextBox();
            tbWachtwoord = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(147, 257);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(523, 29);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += button1_Click;
            // 
            // tbNaam
            // 
            tbNaam.Location = new Point(233, 132);
            tbNaam.Name = "tbNaam";
            tbNaam.Size = new Size(437, 27);
            tbNaam.TabIndex = 1;
            // 
            // tbWachtwoord
            // 
            tbWachtwoord.Location = new Point(233, 197);
            tbWachtwoord.Name = "tbWachtwoord";
            tbWachtwoord.Size = new Size(437, 27);
            tbWachtwoord.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 132);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 3;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 197);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbWachtwoord);
            Controls.Add(tbNaam);
            Controls.Add(btnLogIn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogIn;
        private TextBox tbNaam;
        private TextBox tbWachtwoord;
        private Label label1;
        private Label label2;
    }
}
