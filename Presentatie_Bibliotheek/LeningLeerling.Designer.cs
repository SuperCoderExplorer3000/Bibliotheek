namespace Presentatie_Bibliotheek
{
    partial class LeningLeerling
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
            tbGebruikerID = new TextBox();
            tbBoekID = new TextBox();
            btnLeen = new Button();
            dtpOut = new DateTimePicker();
            dtpIn = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 144);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "datum lening";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 175);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "datum stop lening";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 206);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "gebruikerID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 238);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "boekID";
            // 
            // tbGebruikerID
            // 
            tbGebruikerID.Location = new Point(272, 203);
            tbGebruikerID.Name = "tbGebruikerID";
            tbGebruikerID.Size = new Size(351, 23);
            tbGebruikerID.TabIndex = 6;
            // 
            // tbBoekID
            // 
            tbBoekID.Location = new Point(272, 238);
            tbBoekID.Name = "tbBoekID";
            tbBoekID.Size = new Size(351, 23);
            tbBoekID.TabIndex = 7;
            // 
            // btnLeen
            // 
            btnLeen.Location = new Point(272, 277);
            btnLeen.Name = "btnLeen";
            btnLeen.Size = new Size(351, 23);
            btnLeen.TabIndex = 8;
            btnLeen.Text = "Leen Boek";
            btnLeen.UseVisualStyleBackColor = true;
            btnLeen.Click += btnLeen_Click;
            // 
            // dtpOut
            // 
            dtpOut.Location = new Point(272, 169);
            dtpOut.Name = "dtpOut";
            dtpOut.Size = new Size(351, 23);
            dtpOut.TabIndex = 10;
            // 
            // dtpIn
            // 
            dtpIn.Location = new Point(272, 138);
            dtpIn.Name = "dtpIn";
            dtpIn.Size = new Size(351, 23);
            dtpIn.TabIndex = 9;
            // 
            // LeningLeerling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpOut);
            Controls.Add(dtpIn);
            Controls.Add(btnLeen);
            Controls.Add(tbBoekID);
            Controls.Add(tbGebruikerID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LeningLeerling";
            Text = "LeningLeerling";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbGebruikerID;
        private TextBox tbBoekID;
        private Button btnLeen;
        private DateTimePicker dtpOut;
        private DateTimePicker dtpIn;
    }
}