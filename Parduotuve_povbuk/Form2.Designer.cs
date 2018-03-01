namespace Parduotuve_povbuk
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPatvirtinti = new System.Windows.Forms.Button();
            this.comboBoxAtsiskaitymas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdresas = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPatvirtinti);
            this.groupBox1.Controls.Add(this.comboBoxAtsiskaitymas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAdresas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Naujas uzsakymas";
            // 
            // buttonPatvirtinti
            // 
            this.buttonPatvirtinti.Location = new System.Drawing.Point(50, 108);
            this.buttonPatvirtinti.Name = "buttonPatvirtinti";
            this.buttonPatvirtinti.Size = new System.Drawing.Size(145, 37);
            this.buttonPatvirtinti.TabIndex = 7;
            this.buttonPatvirtinti.Text = "Patvirtinti";
            this.buttonPatvirtinti.UseVisualStyleBackColor = true;
            this.buttonPatvirtinti.Click += new System.EventHandler(this.buttonPatvirtinti_Click);
            // 
            // comboBoxAtsiskaitymas
            // 
            this.comboBoxAtsiskaitymas.FormattingEnabled = true;
            this.comboBoxAtsiskaitymas.Items.AddRange(new object[] {
            "Grynais",
            "Kortele"});
            this.comboBoxAtsiskaitymas.Location = new System.Drawing.Point(133, 67);
            this.comboBoxAtsiskaitymas.Name = "comboBoxAtsiskaitymas";
            this.comboBoxAtsiskaitymas.Size = new System.Drawing.Size(100, 24);
            this.comboBoxAtsiskaitymas.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Atsiskaitymo tipas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adresas:";
            // 
            // textBoxAdresas
            // 
            this.textBoxAdresas.Location = new System.Drawing.Point(133, 39);
            this.textBoxAdresas.Name = "textBoxAdresas";
            this.textBoxAdresas.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdresas.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(589, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Location = new System.Drawing.Point(3, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 108);
            this.textBox2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 138);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turimi uzsakymai:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 317);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Uzsakymas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxAdresas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAtsiskaitymas;
        private System.Windows.Forms.Button buttonPatvirtinti;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}