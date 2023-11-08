namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.SB = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SS = new System.Windows.Forms.Button();
            this.SI = new System.Windows.Forms.Button();
            this.SM = new System.Windows.Forms.Button();
            this.SQ = new System.Windows.Forms.Button();
            this.NAPISCZAS = new System.Windows.Forms.Label();
            this.CZAS = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.NUD = new System.Windows.Forms.NumericUpDown();
            this.GENERATE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // SB
            // 
            this.SB.Location = new System.Drawing.Point(100, 350);
            this.SB.Name = "SB";
            this.SB.Size = new System.Drawing.Size(75, 30);
            this.SB.TabIndex = 0;
            this.SB.Text = "SB";
            this.SB.UseVisualStyleBackColor = true;
            this.SB.Click += new System.EventHandler(this.SB_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SS
            // 
            this.SS.Location = new System.Drawing.Point(200, 350);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(75, 30);
            this.SS.TabIndex = 3;
            this.SS.Text = "SS";
            this.SS.UseVisualStyleBackColor = true;
            this.SS.Click += new System.EventHandler(this.SS_Click);
            // 
            // SI
            // 
            this.SI.Location = new System.Drawing.Point(300, 350);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(75, 30);
            this.SI.TabIndex = 4;
            this.SI.Text = "SI";
            this.SI.UseVisualStyleBackColor = true;
            this.SI.Click += new System.EventHandler(this.SI_Click);
            // 
            // SM
            // 
            this.SM.Location = new System.Drawing.Point(400, 350);
            this.SM.Name = "SM";
            this.SM.Size = new System.Drawing.Size(75, 30);
            this.SM.TabIndex = 5;
            this.SM.Text = "SM";
            this.SM.UseVisualStyleBackColor = true;
            this.SM.Click += new System.EventHandler(this.SM_Click);
            // 
            // SQ
            // 
            this.SQ.Location = new System.Drawing.Point(500, 350);
            this.SQ.Name = "SQ";
            this.SQ.Size = new System.Drawing.Size(75, 30);
            this.SQ.TabIndex = 6;
            this.SQ.Text = "SQ";
            this.SQ.UseVisualStyleBackColor = true;
            this.SQ.Click += new System.EventHandler(this.SQ_Click);
            // 
            // NAPISCZAS
            // 
            this.NAPISCZAS.AutoSize = true;
            this.NAPISCZAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NAPISCZAS.Location = new System.Drawing.Point(432, 253);
            this.NAPISCZAS.Name = "NAPISCZAS";
            this.NAPISCZAS.Size = new System.Drawing.Size(43, 17);
            this.NAPISCZAS.TabIndex = 7;
            this.NAPISCZAS.Text = "Czas:";
            this.NAPISCZAS.Click += new System.EventHandler(this.label1_Click);
            // 
            // CZAS
            // 
            this.CZAS.AutoSize = true;
            this.CZAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CZAS.Location = new System.Drawing.Point(497, 253);
            this.CZAS.Name = "CZAS";
            this.CZAS.Size = new System.Drawing.Size(68, 17);
            this.CZAS.TabIndex = 8;
            this.CZAS.Text = ". . . . . . . .";
            this.CZAS.TextChanged += new System.EventHandler(this.CZAS_TextChanged);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(500, 103);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(140, 17);
            this.checkBox.TabIndex = 9;
            this.checkBox.Text = "Nacisnij aby aktywować";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // NUD
            // 
            this.NUD.Enabled = false;
            this.NUD.Location = new System.Drawing.Point(500, 126);
            this.NUD.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.NUD.Name = "NUD";
            this.NUD.Size = new System.Drawing.Size(120, 20);
            this.NUD.TabIndex = 10;
            this.NUD.Tag = "";
            // 
            // GENERATE
            // 
            this.GENERATE.Enabled = false;
            this.GENERATE.Location = new System.Drawing.Point(500, 152);
            this.GENERATE.Name = "GENERATE";
            this.GENERATE.Size = new System.Drawing.Size(75, 23);
            this.GENERATE.TabIndex = 11;
            this.GENERATE.Text = "Generuj";
            this.GENERATE.UseVisualStyleBackColor = true;
            this.GENERATE.Click += new System.EventHandler(this.GENERATE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GENERATE);
            this.Controls.Add(this.NUD);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.CZAS);
            this.Controls.Add(this.NAPISCZAS);
            this.Controls.Add(this.SQ);
            this.Controls.Add(this.SM);
            this.Controls.Add(this.SI);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SS;
        private System.Windows.Forms.Button SI;
        private System.Windows.Forms.Button SM;
        private System.Windows.Forms.Button SQ;
        private System.Windows.Forms.Label NAPISCZAS;
        private System.Windows.Forms.Label CZAS;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.NumericUpDown NUD;
        private System.Windows.Forms.Button GENERATE;
    }
}

