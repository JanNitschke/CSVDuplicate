namespace DataCleaner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNew = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonOrg = new System.Windows.Forms.Button();
            this.comboBoxOrg1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxNew1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNew2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxOrg2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(764, 39);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(80, 29);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "select";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(104, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(655, 29);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bestehende Daten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Neue Daten";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(104, 39);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(655, 29);
            this.textBox2.TabIndex = 4;
            // 
            // buttonOrg
            // 
            this.buttonOrg.Location = new System.Drawing.Point(764, 6);
            this.buttonOrg.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrg.Name = "buttonOrg";
            this.buttonOrg.Size = new System.Drawing.Size(80, 29);
            this.buttonOrg.TabIndex = 3;
            this.buttonOrg.Text = "select";
            this.buttonOrg.UseVisualStyleBackColor = true;
            this.buttonOrg.Click += new System.EventHandler(this.ButtonOrg_Click);
            // 
            // comboBoxOrg1
            // 
            this.comboBoxOrg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrg1.FormattingEnabled = true;
            this.comboBoxOrg1.Location = new System.Drawing.Point(104, 91);
            this.comboBoxOrg1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOrg1.Name = "comboBoxOrg1";
            this.comboBoxOrg1.Size = new System.Drawing.Size(352, 32);
            this.comboBoxOrg1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Comparison1";
            // 
            // comboBoxNew1
            // 
            this.comboBoxNew1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNew1.FormattingEnabled = true;
            this.comboBoxNew1.Location = new System.Drawing.Point(491, 91);
            this.comboBoxNew1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNew1.Name = "comboBoxNew1";
            this.comboBoxNew1.Size = new System.Drawing.Size(352, 32);
            this.comboBoxNew1.TabIndex = 8;
            this.comboBoxNew1.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNew1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "VS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "VS";
            // 
            // comboBoxNew2
            // 
            this.comboBoxNew2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNew2.FormattingEnabled = true;
            this.comboBoxNew2.Location = new System.Drawing.Point(491, 127);
            this.comboBoxNew2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNew2.Name = "comboBoxNew2";
            this.comboBoxNew2.Size = new System.Drawing.Size(352, 32);
            this.comboBoxNew2.TabIndex = 12;
            this.comboBoxNew2.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNew2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Comparison2";
            // 
            // comboBoxOrg2
            // 
            this.comboBoxOrg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOrg2.FormattingEnabled = true;
            this.comboBoxOrg2.Location = new System.Drawing.Point(104, 127);
            this.comboBoxOrg2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOrg2.Name = "comboBoxOrg2";
            this.comboBoxOrg2.Size = new System.Drawing.Size(352, 32);
            this.comboBoxOrg2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Output";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(104, 163);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(655, 29);
            this.textBox3.TabIndex = 15;
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(763, 163);
            this.buttonOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(80, 29);
            this.buttonOut.TabIndex = 14;
            this.buttonOut.Text = "select";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.ButtonOut_Click);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(9, 265);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(835, 29);
            this.buttonGo.TabIndex = 17;
            this.buttonGo.Text = "start";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 299);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(834, 28);
            this.progressBar1.TabIndex = 18;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(104, 215);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(739, 45);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.Value = 80;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Threshold";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "80%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 712);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 345);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxNew2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxOrg2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxNew1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxOrg1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonOrg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonNew);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Duplicate Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonOrg;
        private System.Windows.Forms.ComboBox comboBoxOrg1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxNew1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxNew2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxOrg2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

