namespace _04___Binary_Files
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
            lblEscriptura = new Label();
            lblSeed = new Label();
            tbSeed = new TextBox();
            btnSeed = new Button();
            lblNif = new Label();
            lblNom = new Label();
            tbNif = new TextBox();
            tbNom = new TextBox();
            lblMaxLenght = new Label();
            btnTest = new Button();
            btnWrite = new Button();
            lblFixSeedFet = new Label();
            lblTest = new Label();
            lblWrite = new Label();
            lblLectura = new Label();
            lblLecNom = new Label();
            lblLecNIF = new Label();
            lblLecSeed = new Label();
            txtReadNom = new TextBox();
            txtReadNif = new TextBox();
            txtReadSeed = new TextBox();
            btnReadFixSeed = new Button();
            btnRead = new Button();
            lblReadFixSeed = new Label();
            lblRead = new Label();
            tvFitxers = new TreeView();
            btnCambiarSeed = new Button();
            SuspendLayout();
            // 
            // lblEscriptura
            // 
            lblEscriptura.AutoSize = true;
            lblEscriptura.Location = new Point(12, 9);
            lblEscriptura.Name = "lblEscriptura";
            lblEscriptura.Size = new Size(73, 15);
            lblEscriptura.TabIndex = 0;
            lblEscriptura.Text = "ESCRIPTURA";
            // 
            // lblSeed
            // 
            lblSeed.AutoSize = true;
            lblSeed.Location = new Point(91, 9);
            lblSeed.Name = "lblSeed";
            lblSeed.Size = new Size(33, 15);
            lblSeed.TabIndex = 1;
            lblSeed.Text = "SEED";
            // 
            // tbSeed
            // 
            tbSeed.Location = new Point(130, 6);
            tbSeed.Name = "tbSeed";
            tbSeed.Size = new Size(100, 23);
            tbSeed.TabIndex = 2;
            // 
            // btnSeed
            // 
            btnSeed.Location = new Point(273, 9);
            btnSeed.Name = "btnSeed";
            btnSeed.Size = new Size(75, 23);
            btnSeed.TabIndex = 3;
            btnSeed.Text = "FIX SEED";
            btnSeed.UseVisualStyleBackColor = true;
            btnSeed.Click += btnSeed_Click;
            // 
            // lblNif
            // 
            lblNif.AutoSize = true;
            lblNif.Location = new Point(91, 42);
            lblNif.Name = "lblNif";
            lblNif.Size = new Size(25, 15);
            lblNif.TabIndex = 4;
            lblNif.Text = "NIF";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(91, 73);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(36, 15);
            lblNom.TabIndex = 5;
            lblNom.Text = "NOM";
            // 
            // tbNif
            // 
            tbNif.Location = new Point(130, 35);
            tbNif.Name = "tbNif";
            tbNif.Size = new Size(100, 23);
            tbNif.TabIndex = 6;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(130, 70);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(448, 23);
            tbNom.TabIndex = 7;
            // 
            // lblMaxLenght
            // 
            lblMaxLenght.AutoSize = true;
            lblMaxLenght.Location = new Point(140, 105);
            lblMaxLenght.Name = "lblMaxLenght";
            lblMaxLenght.Size = new Size(70, 15);
            lblMaxLenght.TabIndex = 8;
            lblMaxLenght.Text = "Max Lenght";
            // 
            // btnTest
            // 
            btnTest.Location = new Point(140, 141);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(75, 23);
            btnTest.TabIndex = 9;
            btnTest.Text = "TEST";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(273, 141);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(75, 23);
            btnWrite.TabIndex = 10;
            btnWrite.Text = "WRITE";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // lblFixSeedFet
            // 
            lblFixSeedFet.AutoSize = true;
            lblFixSeedFet.Location = new Point(397, 13);
            lblFixSeedFet.Name = "lblFixSeedFet";
            lblFixSeedFet.Size = new Size(0, 15);
            lblFixSeedFet.TabIndex = 11;
            // 
            // lblTest
            // 
            lblTest.AutoSize = true;
            lblTest.Location = new Point(96, 145);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(0, 15);
            lblTest.TabIndex = 12;
            // 
            // lblWrite
            // 
            lblWrite.AutoSize = true;
            lblWrite.Location = new Point(229, 145);
            lblWrite.Name = "lblWrite";
            lblWrite.Size = new Size(0, 15);
            lblWrite.TabIndex = 13;
            // 
            // lblLectura
            // 
            lblLectura.AutoSize = true;
            lblLectura.Location = new Point(12, 201);
            lblLectura.Name = "lblLectura";
            lblLectura.Size = new Size(56, 15);
            lblLectura.TabIndex = 14;
            lblLectura.Text = "LECTURA";
            // 
            // lblLecNom
            // 
            lblLecNom.AutoSize = true;
            lblLecNom.Location = new Point(91, 265);
            lblLecNom.Name = "lblLecNom";
            lblLecNom.Size = new Size(36, 15);
            lblLecNom.TabIndex = 18;
            lblLecNom.Text = "NOM";
            // 
            // lblLecNIF
            // 
            lblLecNIF.AutoSize = true;
            lblLecNIF.Location = new Point(91, 234);
            lblLecNIF.Name = "lblLecNIF";
            lblLecNIF.Size = new Size(25, 15);
            lblLecNIF.TabIndex = 17;
            lblLecNIF.Text = "NIF";
            // 
            // lblLecSeed
            // 
            lblLecSeed.AutoSize = true;
            lblLecSeed.Location = new Point(91, 201);
            lblLecSeed.Name = "lblLecSeed";
            lblLecSeed.Size = new Size(33, 15);
            lblLecSeed.TabIndex = 16;
            lblLecSeed.Text = "SEED";
            // 
            // txtReadNom
            // 
            txtReadNom.Location = new Point(140, 262);
            txtReadNom.Name = "txtReadNom";
            txtReadNom.Size = new Size(448, 23);
            txtReadNom.TabIndex = 21;
            // 
            // txtReadNif
            // 
            txtReadNif.Location = new Point(140, 227);
            txtReadNif.Name = "txtReadNif";
            txtReadNif.Size = new Size(100, 23);
            txtReadNif.TabIndex = 20;
            // 
            // txtReadSeed
            // 
            txtReadSeed.Location = new Point(140, 198);
            txtReadSeed.Name = "txtReadSeed";
            txtReadSeed.Size = new Size(100, 23);
            txtReadSeed.TabIndex = 19;
            // 
            // btnReadFixSeed
            // 
            btnReadFixSeed.Location = new Point(273, 227);
            btnReadFixSeed.Name = "btnReadFixSeed";
            btnReadFixSeed.Size = new Size(75, 23);
            btnReadFixSeed.TabIndex = 22;
            btnReadFixSeed.Text = "FIX SEED";
            btnReadFixSeed.UseVisualStyleBackColor = true;
            btnReadFixSeed.Click += btnReadFixSeed_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(424, 226);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 23;
            btnRead.Text = "READ";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // lblReadFixSeed
            // 
            lblReadFixSeed.AutoSize = true;
            lblReadFixSeed.Location = new Point(354, 231);
            lblReadFixSeed.Name = "lblReadFixSeed";
            lblReadFixSeed.Size = new Size(0, 15);
            lblReadFixSeed.TabIndex = 24;
            // 
            // lblRead
            // 
            lblRead.AutoSize = true;
            lblRead.Location = new Point(505, 231);
            lblRead.Name = "lblRead";
            lblRead.Size = new Size(0, 15);
            lblRead.TabIndex = 25;
            // 
            // tvFitxers
            // 
            tvFitxers.Location = new Point(621, 13);
            tvFitxers.Name = "tvFitxers";
            tvFitxers.Size = new Size(167, 425);
            tvFitxers.TabIndex = 26;
            tvFitxers.AfterSelect += tvFitxers_AfterSelect;
            // 
            // btnCambiarSeed
            // 
            btnCambiarSeed.Location = new Point(264, 38);
            btnCambiarSeed.Name = "btnCambiarSeed";
            btnCambiarSeed.Size = new Size(100, 23);
            btnCambiarSeed.TabIndex = 27;
            btnCambiarSeed.Text = "Canviar Seed";
            btnCambiarSeed.UseVisualStyleBackColor = true;
            btnCambiarSeed.Click += btnCambiarSeed_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiarSeed);
            Controls.Add(tvFitxers);
            Controls.Add(lblRead);
            Controls.Add(lblReadFixSeed);
            Controls.Add(btnRead);
            Controls.Add(btnReadFixSeed);
            Controls.Add(txtReadNom);
            Controls.Add(txtReadNif);
            Controls.Add(txtReadSeed);
            Controls.Add(lblLecNom);
            Controls.Add(lblLecNIF);
            Controls.Add(lblLecSeed);
            Controls.Add(lblLectura);
            Controls.Add(lblWrite);
            Controls.Add(lblTest);
            Controls.Add(lblFixSeedFet);
            Controls.Add(btnWrite);
            Controls.Add(btnTest);
            Controls.Add(lblMaxLenght);
            Controls.Add(tbNom);
            Controls.Add(tbNif);
            Controls.Add(lblNom);
            Controls.Add(lblNif);
            Controls.Add(btnSeed);
            Controls.Add(tbSeed);
            Controls.Add(lblSeed);
            Controls.Add(lblEscriptura);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEscriptura;
        private Label lblSeed;
        private TextBox tbSeed;
        private Button btnSeed;
        private Label lblNif;
        private Label lblNom;
        private TextBox tbNif;
        private TextBox tbNom;
        private Label lblMaxLenght;
        private Button btnTest;
        private Button btnWrite;
        private Label lblFixSeedFet;
        private Label lblTest;
        private Label lblWrite;
        private Label lblLectura;
        private Label lblLecNom;
        private Label lblLecNIF;
        private Label lblLecSeed;
        private TextBox txtReadNom;
        private TextBox txtReadNif;
        private TextBox txtReadSeed;
        private Button btnReadFixSeed;
        private Button btnRead;
        private Label lblReadFixSeed;
        private Label lblRead;
        private TreeView tvFitxers;
        private Button btnCambiarSeed;
    }
}
