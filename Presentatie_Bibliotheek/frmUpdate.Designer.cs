namespace Presentatie_Bibliotheek
{
    partial class frmUpdate
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
            tbUitgever = new TextBox();
            tbTaal = new TextBox();
            tbTitel = new TextBox();
            tbPaginas = new TextBox();
            tbGraad = new TextBox();
            tbGenreID = new TextBox();
            tbAuteur = new TextBox();
            btnUpdate = new Button();
            label9 = new Label();
            tbBoekID = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 99);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 132);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Pagina's";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 165);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Titel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 198);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "GenreID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(106, 231);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Uitgever";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(106, 264);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 5;
            label6.Text = "Auteur";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 297);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 6;
            label7.Text = "Taal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(106, 331);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 7;
            label8.Text = "Graad";
            // 
            // tbISBN
            // 
            tbISBN.Location = new Point(227, 96);
            tbISBN.Name = "tbISBN";
            tbISBN.Size = new Size(464, 27);
            tbISBN.TabIndex = 9;
            // 
            // tbUitgever
            // 
            tbUitgever.Location = new Point(227, 228);
            tbUitgever.Name = "tbUitgever";
            tbUitgever.Size = new Size(464, 27);
            tbUitgever.TabIndex = 10;
            // 
            // tbTaal
            // 
            tbTaal.Location = new Point(227, 294);
            tbTaal.Name = "tbTaal";
            tbTaal.Size = new Size(464, 27);
            tbTaal.TabIndex = 11;
            // 
            // tbTitel
            // 
            tbTitel.Location = new Point(227, 162);
            tbTitel.Name = "tbTitel";
            tbTitel.Size = new Size(464, 27);
            tbTitel.TabIndex = 12;
            // 
            // tbPaginas
            // 
            tbPaginas.Location = new Point(227, 129);
            tbPaginas.Name = "tbPaginas";
            tbPaginas.Size = new Size(464, 27);
            tbPaginas.TabIndex = 13;
            // 
            // tbGraad
            // 
            tbGraad.Location = new Point(227, 328);
            tbGraad.Name = "tbGraad";
            tbGraad.Size = new Size(464, 27);
            tbGraad.TabIndex = 14;
            // 
            // tbGenreID
            // 
            tbGenreID.Location = new Point(227, 195);
            tbGenreID.Name = "tbGenreID";
            tbGenreID.Size = new Size(464, 27);
            tbGenreID.TabIndex = 15;
            // 
            // tbAuteur
            // 
            tbAuteur.Location = new Point(227, 261);
            tbAuteur.Name = "tbAuteur";
            tbAuteur.Size = new Size(464, 27);
            tbAuteur.TabIndex = 16;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(227, 378);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(464, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(105, 37);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 19;
            label9.Text = "boekID";
            // 
            // tbBoekID
            // 
            tbBoekID.Location = new Point(227, 34);
            tbBoekID.Name = "tbBoekID";
            tbBoekID.Size = new Size(104, 27);
            tbBoekID.TabIndex = 20;
            // 
            // frmUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbBoekID);
            Controls.Add(label9);
            Controls.Add(btnUpdate);
            Controls.Add(tbAuteur);
            Controls.Add(tbGenreID);
            Controls.Add(tbGraad);
            Controls.Add(tbPaginas);
            Controls.Add(tbTitel);
            Controls.Add(tbTaal);
            Controls.Add(tbUitgever);
            Controls.Add(tbISBN);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUpdate";
            Text = "frmUpdate";
            Load += frmUpdate_Load;
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
        private TextBox tbUitgever;
        private TextBox tbTaal;
        private TextBox tbTitel;
        private TextBox tbPaginas;
        private TextBox tbGraad;
        private TextBox tbGenreID;
        private TextBox tbAuteur;
        private Button btnUpdate;
        private Label label9;
        private TextBox tbBoekID;
    }
}