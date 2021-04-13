namespace milk
{
    partial class Form4
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.milkrate = new System.Windows.Forms.TextBox();
            this.mixfat = new System.Windows.Forms.TextBox();
            this.tarmilk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cr1 = new System.Windows.Forms.TextBox();
            this.cr2 = new System.Windows.Forms.TextBox();
            this.cr3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Target milk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mixing Fat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "MILK rate";
            // 
            // milkrate
            // 
            this.milkrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milkrate.Location = new System.Drawing.Point(239, 53);
            this.milkrate.Name = "milkrate";
            this.milkrate.Size = new System.Drawing.Size(101, 28);
            this.milkrate.TabIndex = 7;
            this.milkrate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.milk_KeyDown);
            // 
            // mixfat
            // 
            this.mixfat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mixfat.Location = new System.Drawing.Point(239, 126);
            this.mixfat.Name = "mixfat";
            this.mixfat.Size = new System.Drawing.Size(101, 28);
            this.mixfat.TabIndex = 8;
            this.mixfat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // tarmilk
            // 
            this.tarmilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarmilk.Location = new System.Drawing.Point(239, 200);
            this.tarmilk.Name = "tarmilk";
            this.tarmilk.Size = new System.Drawing.Size(101, 28);
            this.tarmilk.TabIndex = 9;
            this.tarmilk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(470, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "C1 rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(470, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "C2 rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "C3 rate";
            // 
            // cr1
            // 
            this.cr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cr1.Location = new System.Drawing.Point(610, 54);
            this.cr1.Name = "cr1";
            this.cr1.Size = new System.Drawing.Size(101, 28);
            this.cr1.TabIndex = 13;
            this.cr1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // cr2
            // 
            this.cr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cr2.Location = new System.Drawing.Point(610, 122);
            this.cr2.Name = "cr2";
            this.cr2.Size = new System.Drawing.Size(101, 28);
            this.cr2.TabIndex = 14;
            this.cr2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // cr3
            // 
            this.cr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cr3.Location = new System.Drawing.Point(610, 203);
            this.cr3.Name = "cr3";
            this.cr3.Size = new System.Drawing.Size(101, 28);
            this.cr3.TabIndex = 15;
            this.cr3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(382, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(975, 493);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cr3);
            this.Controls.Add(this.cr2);
            this.Controls.Add(this.cr1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tarmilk);
            this.Controls.Add(this.mixfat);
            this.Controls.Add(this.milkrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox milkrate;
        private System.Windows.Forms.TextBox mixfat;
        private System.Windows.Forms.TextBox tarmilk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cr1;
        private System.Windows.Forms.TextBox cr2;
        private System.Windows.Forms.TextBox cr3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}