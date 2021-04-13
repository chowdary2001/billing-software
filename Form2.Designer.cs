namespace milk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sno1 = new System.Windows.Forms.TextBox();
            this.name1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "S No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // sno1
            // 
            this.sno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sno1.Location = new System.Drawing.Point(211, 48);
            this.sno1.Name = "sno1";
            this.sno1.Size = new System.Drawing.Size(100, 30);
            this.sno1.TabIndex = 2;
            this.sno1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sno1_KeyDown);
            // 
            // name1
            // 
            this.name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name1.Location = new System.Drawing.Point(211, 106);
            this.name1.Multiline = true;
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(257, 57);
            this.name1.TabIndex = 3;
            this.name1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.name1_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(187, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comment
            // 
            this.comment.BackColor = System.Drawing.SystemColors.MenuBar;
            this.comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comment.Location = new System.Drawing.Point(157, 259);
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(140, 27);
            this.comment.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 355);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.sno1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sno1;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox comment;
    }
}