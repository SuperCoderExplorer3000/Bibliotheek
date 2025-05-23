namespace Presentatie_Bibliotheek
{
    partial class frmVoegToe
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
            label7 = new Label();
            label8 = new Label();
            tbISBN = new TextBox();
            tbPaginas = new TextBox();
            tbTitel = new TextBox();
            tbGenreID = new TextBox();
            tbUitgever = new TextBox();
            tbAuteur = new TextBox();
            tbTaal = new TextBox();
            tbGraad = new TextBox();
            btnAddBoek = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 81);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 111);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Pagina's";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 149);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Titel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 182);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "GenreID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 215);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Uitgever";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 255);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 5;
            label6.Text = "Auteur";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(112, 291);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 6;
            label7.Text = "Taal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(98, 330);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 7;
            label8.Text = "Graad";
            // 
            // tbISBN
            // 
            tbISBN.Location = new Point(168, 75);
            tbISBN.Name = "tbISBN";
            tbISBN.Size = new Size(483, 27);
            tbISBN.TabIndex = 8;
            // 
            // tbPaginas
            // 
            tbPaginas.Location = new Point(168, 108);
            tbPaginas.Name = "tbPaginas";
            tbPaginas.Size = new Size(483, 27);
            tbPaginas.TabIndex = 9;
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(168, 146);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(483, 27);
            tbTitel.TabIndex = 10;
            // 
            // tbGenreID
            // 
            tbGenreID.Location = new Point(168, 179);
            tbGenreID.Name = "tbGenreID";
            tbGenreID.Size = new Size(483, 27);
            tbGenreID.TabIndex = 11;
            // 
            // tbUitgever
            // 
            tbUitgever.Location = new Point(168, 212);
            tbUitgever.Name = "tbUitgever";
            tbUitgever.Size = new Size(483, 27);
            tbUitgever.TabIndex = 12;
            // 
            // tbAuteur
            // 
            tbAuteur.Location = new Point(168, 252);
            tbAuteur.Name = "tbAuteur";
            tbAuteur.Size = new Size(483, 27);
            tbAuteur.TabIndex = 13;
            // 
            // tbTaal
            // 
            tbTaal.Location = new Point(168, 288);
            tbTaal.Name = "tbTaal";
            tbTaal.Size = new Size(483, 27);
            tbTaal.TabIndex = 14;
            // 
            // tbGraad
            // 
            tbGraad.Location = new Point(168, 327);
            tbGraad.Name = "tbGraad";
            tbGraad.Size = new Size(486, 27);
            tbGraad.TabIndex = 15;
            // 
            // btnAddBoek
            // 
            btnAddBoek.Location = new Point(168, 374);
            btnAddBoek.Name = "btnAddBoek";
            btnAddBoek.Size = new Size(483, 29);
            btnAddBoek.TabIndex = 16;
            btnAddBoek.Text = "Voeg Toe";
            btnAddBoek.UseVisualStyleBackColor = true;
            btnAddBoek.Click += btnAddBoek_Click;
            // 
            // frmVoegToe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddBoek);
            Controls.Add(tbGraad);
            Controls.Add(tbTaal);
            Controls.Add(tbAuteur);
            Controls.Add(tbUitgever);
            Controls.Add(tbGenreID);
            Controls.Add(tbTitel);
            Controls.Add(tbPaginas);
            Controls.Add(tbISBN);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmVoegToe";
            Text = "frmVoegToe";
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
        private Label label7;
        private Label label8;
        private TextBox tbISBN;
        private TextBox tbPaginas;
        private TextBox tbTitel;
        private TextBox tbGenreID;
        private TextBox tbUitgever;
        private TextBox tbAuteur;
        private TextBox tbTaal;
        private TextBox tbGraad;
        private Button btnAddBoek;
    }
}