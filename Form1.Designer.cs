namespace milk
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sno = new System.Windows.Forms.TextBox();
            this.milk = new System.Windows.Forms.TextBox();
            this.fat = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.rs = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ap = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalPrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milkDataSet = new milk.milkDataSet();
            this.milkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sno_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milk_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fat_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rs_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maindataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkDataSet3 = new milk.milkDataSet3();
            this.maindataTableAdapter = new milk.milkDataSet3TableAdapters.maindataTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.save = new System.Windows.Forms.Button();
            this.tm = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.mixset = new System.Windows.Forms.TextBox();
            this.milkmix = new System.Windows.Forms.TextBox();
            this.fatmix = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mix = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.totmilk = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.totrs = new System.Windows.Forms.Label();
            this.totfat = new System.Windows.Forms.Label();
            this.cm1 = new System.Windows.Forms.TextBox();
            this.cf1 = new System.Windows.Forms.TextBox();
            this.cm2 = new System.Windows.Forms.TextBox();
            this.cf2 = new System.Windows.Forms.TextBox();
            this.cm3 = new System.Windows.Forms.TextBox();
            this.cf3 = new System.Windows.Forms.TextBox();
            this.crs1 = new System.Windows.Forms.Label();
            this.crs2 = new System.Windows.Forms.Label();
            this.crs3 = new System.Windows.Forms.Label();
            this.sm = new System.Windows.Forms.Label();
            this.srs = new System.Windows.Forms.TextBox();
            this.pl = new System.Windows.Forms.Label();
            this.mixx = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument3 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog3 = new System.Windows.Forms.PrintPreviewDialog();
            this.verticalProgressBar1 = new milk.verticalProgressBar();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "S NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "FAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "MILK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "RS";
            // 
            // sno
            // 
            this.sno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sno.Location = new System.Drawing.Point(191, 94);
            this.sno.Name = "sno";
            this.sno.Size = new System.Drawing.Size(101, 28);
            this.sno.TabIndex = 5;
            this.sno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // milk
            // 
            this.milk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milk.Location = new System.Drawing.Point(191, 189);
            this.milk.Name = "milk";
            this.milk.Size = new System.Drawing.Size(101, 28);
            this.milk.TabIndex = 6;
            this.milk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // fat
            // 
            this.fat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fat.Location = new System.Drawing.Point(191, 234);
            this.fat.Name = "fat";
            this.fat.Size = new System.Drawing.Size(101, 28);
            this.fat.TabIndex = 7;
            this.fat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // name
            // 
            this.name.AccessibleName = "";
            this.name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(186, 133);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(197, 41);
            this.name.TabIndex = 8;
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rs
            // 
            this.rs.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rs.Location = new System.Drawing.Point(186, 277);
            this.rs.Name = "rs";
            this.rs.Size = new System.Drawing.Size(97, 34);
            this.rs.TabIndex = 9;
            this.rs.Text = "          ";
            this.rs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(172, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ap
            // 
            this.ap.FormattingEnabled = true;
            this.ap.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.ap.Location = new System.Drawing.Point(305, 50);
            this.ap.Name = "ap";
            this.ap.Size = new System.Drawing.Size(121, 24);
            this.ap.TabIndex = 12;
            this.ap.Text = "-SELECT-";
            this.ap.SelectedIndexChanged += new System.EventHandler(this.ap_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNumberToolStripMenuItem,
            this.finalPrintToolStripMenuItem,
            this.advancesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.resultsToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1920, 31);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNumberToolStripMenuItem
            // 
            this.addNumberToolStripMenuItem.Name = "addNumberToolStripMenuItem";
            this.addNumberToolStripMenuItem.Size = new System.Drawing.Size(160, 27);
            this.addNumberToolStripMenuItem.Text = "    Add number    ";
            this.addNumberToolStripMenuItem.Click += new System.EventHandler(this.addNumberToolStripMenuItem_Click);
            // 
            // finalPrintToolStripMenuItem
            // 
            this.finalPrintToolStripMenuItem.Name = "finalPrintToolStripMenuItem";
            this.finalPrintToolStripMenuItem.Size = new System.Drawing.Size(136, 27);
            this.finalPrintToolStripMenuItem.Text = "    Final Print   ";
            this.finalPrintToolStripMenuItem.Click += new System.EventHandler(this.finalPrintToolStripMenuItem_Click);
            // 
            // advancesToolStripMenuItem
            // 
            this.advancesToolStripMenuItem.Name = "advancesToolStripMenuItem";
            this.advancesToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.advancesToolStripMenuItem.Text = "  Advances  ";
            this.advancesToolStripMenuItem.Click += new System.EventHandler(this.advancesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(135, 27);
            this.settingsToolStripMenuItem.Text = "     Settings     ";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(96, 27);
            this.viewToolStripMenuItem.Text = "    View   ";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(123, 27);
            this.resultsToolStripMenuItem.Text = "      Results   ";
            this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
            // 
            // milkDataSet
            // 
            this.milkDataSet.DataSetName = "milkDataSet";
            this.milkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // milkDataSetBindingSource
            // 
            this.milkDataSetBindingSource.DataSource = this.milkDataSet;
            this.milkDataSetBindingSource.Position = 0;
            // 
            // view
            // 
            this.view.BackgroundColor = System.Drawing.SystemColors.Control;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.view.ColumnHeadersHeight = 32;
            this.view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.name_,
            this.sno_,
            this.milk_,
            this.fat_,
            this.rs_});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.view.DefaultCellStyle = dataGridViewCellStyle4;
            this.view.Location = new System.Drawing.Point(39, 392);
            this.view.Name = "view";
            this.view.RowHeadersWidth = 51;
            this.view.RowTemplate.Height = 30;
            this.view.RowTemplate.ReadOnly = true;
            this.view.Size = new System.Drawing.Size(1094, 411);
            this.view.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 95;
            // 
            // name_
            // 
            this.name_.HeaderText = "NAME";
            this.name_.MinimumWidth = 6;
            this.name_.Name = "name_";
            this.name_.ReadOnly = true;
            this.name_.Width = 150;
            // 
            // sno_
            // 
            this.sno_.HeaderText = "SNO";
            this.sno_.MinimumWidth = 6;
            this.sno_.Name = "sno_";
            this.sno_.ReadOnly = true;
            this.sno_.Width = 95;
            // 
            // milk_
            // 
            this.milk_.HeaderText = "MILK";
            this.milk_.MinimumWidth = 6;
            this.milk_.Name = "milk_";
            this.milk_.ReadOnly = true;
            this.milk_.Width = 125;
            // 
            // fat_
            // 
            this.fat_.HeaderText = "FAT";
            this.fat_.MinimumWidth = 6;
            this.fat_.Name = "fat_";
            this.fat_.ReadOnly = true;
            this.fat_.Width = 125;
            // 
            // rs_
            // 
            this.rs_.HeaderText = "RS     PS";
            this.rs_.MinimumWidth = 6;
            this.rs_.Name = "rs_";
            this.rs_.ReadOnly = true;
            this.rs_.Width = 130;
            // 
            // maindataBindingSource
            // 
            this.maindataBindingSource.DataMember = "maindata";
            this.maindataBindingSource.DataSource = this.milkDataSet3;
            // 
            // milkDataSet3
            // 
            this.milkDataSet3.DataSetName = "milkDataSet3";
            this.milkDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maindataTableAdapter
            // 
            this.maindataTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(316, 333);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(92, 35);
            this.save.TabIndex = 16;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // tm
            // 
            this.tm.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tm.Location = new System.Drawing.Point(469, 52);
            this.tm.Name = "tm";
            this.tm.Size = new System.Drawing.Size(105, 37);
            this.tm.TabIndex = 18;
            this.tm.Text = "0.0";
            this.tm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(952, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(394, 273);
            this.label6.TabIndex = 20;
            // 
            // mixset
            // 
            this.mixset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mixset.Location = new System.Drawing.Point(656, 82);
            this.mixset.Name = "mixset";
            this.mixset.Size = new System.Drawing.Size(101, 28);
            this.mixset.TabIndex = 21;
            this.mixset.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mixfatset_KeyDown);
            // 
            // milkmix
            // 
            this.milkmix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milkmix.Location = new System.Drawing.Point(747, 139);
            this.milkmix.Name = "milkmix";
            this.milkmix.Size = new System.Drawing.Size(101, 28);
            this.milkmix.TabIndex = 22;
            this.milkmix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.milkmix_KeyDown);
            // 
            // fatmix
            // 
            this.fatmix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatmix.Location = new System.Drawing.Point(747, 216);
            this.fatmix.Name = "fatmix";
            this.fatmix.Size = new System.Drawing.Size(101, 28);
            this.fatmix.TabIndex = 23;
            this.fatmix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fatmix_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(623, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "MILK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(629, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "FAT";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(623, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "MIX";
            // 
            // mix
            // 
            this.mix.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mix.Location = new System.Drawing.Point(742, 307);
            this.mix.Name = "mix";
            this.mix.Size = new System.Drawing.Size(97, 34);
            this.mix.TabIndex = 28;
            this.mix.Text = "          ";
            this.mix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1312, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 24);
            this.label10.TabIndex = 29;
            this.label10.Text = "MILK";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1567, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 24);
            this.label11.TabIndex = 30;
            this.label11.Text = "RS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1441, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 24);
            this.label12.TabIndex = 31;
            this.label12.Text = "FAT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1158, 444);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 24);
            this.label13.TabIndex = 32;
            this.label13.Text = "Customers";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1152, 499);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 24);
            this.label14.TabIndex = 33;
            this.label14.Text = "Company 1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1152, 552);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 24);
            this.label15.TabIndex = 34;
            this.label15.Text = "Company 2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1152, 619);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 24);
            this.label16.TabIndex = 35;
            this.label16.Text = "Company 3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1188, 673);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 24);
            this.label17.TabIndex = 36;
            this.label17.Text = "Sales";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1188, 728);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 24);
            this.label18.TabIndex = 37;
            this.label18.Text = "P / L";
            // 
            // totmilk
            // 
            this.totmilk.AutoSize = true;
            this.totmilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totmilk.ForeColor = System.Drawing.Color.MediumBlue;
            this.totmilk.Location = new System.Drawing.Point(1319, 444);
            this.totmilk.Name = "totmilk";
            this.totmilk.Size = new System.Drawing.Size(27, 29);
            this.totmilk.TabIndex = 38;
            this.totmilk.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1153, 416);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(520, 17);
            this.label20.TabIndex = 39;
            this.label20.Text = "________________________________________________________________";
            // 
            // totrs
            // 
            this.totrs.AutoSize = true;
            this.totrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totrs.ForeColor = System.Drawing.Color.MediumBlue;
            this.totrs.Location = new System.Drawing.Point(1566, 444);
            this.totrs.Name = "totrs";
            this.totrs.Size = new System.Drawing.Size(27, 29);
            this.totrs.TabIndex = 40;
            this.totrs.Text = "0";
            // 
            // totfat
            // 
            this.totfat.AutoSize = true;
            this.totfat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totfat.ForeColor = System.Drawing.Color.MediumBlue;
            this.totfat.Location = new System.Drawing.Point(1449, 444);
            this.totfat.Name = "totfat";
            this.totfat.Size = new System.Drawing.Size(27, 29);
            this.totfat.TabIndex = 41;
            this.totfat.Text = "0";
            // 
            // cm1
            // 
            this.cm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm1.Location = new System.Drawing.Point(1316, 496);
            this.cm1.Name = "cm1";
            this.cm1.Size = new System.Drawing.Size(78, 28);
            this.cm1.TabIndex = 42;
            this.cm1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cm1_KeyDown);
            // 
            // cf1
            // 
            this.cf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cf1.Location = new System.Drawing.Point(1432, 495);
            this.cf1.Name = "cf1";
            this.cf1.Size = new System.Drawing.Size(78, 28);
            this.cf1.TabIndex = 43;
            this.cf1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cf1_KeyDown);
            // 
            // cm2
            // 
            this.cm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm2.Location = new System.Drawing.Point(1316, 552);
            this.cm2.Name = "cm2";
            this.cm2.Size = new System.Drawing.Size(78, 28);
            this.cm2.TabIndex = 44;
            this.cm2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cm2_KeyDown);
            // 
            // cf2
            // 
            this.cf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cf2.Location = new System.Drawing.Point(1432, 552);
            this.cf2.Name = "cf2";
            this.cf2.Size = new System.Drawing.Size(78, 28);
            this.cf2.TabIndex = 45;
            this.cf2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cf2_KeyDown);
            // 
            // cm3
            // 
            this.cm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cm3.Location = new System.Drawing.Point(1316, 619);
            this.cm3.Name = "cm3";
            this.cm3.Size = new System.Drawing.Size(78, 28);
            this.cm3.TabIndex = 46;
            this.cm3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cm3_KeyDown);
            // 
            // cf3
            // 
            this.cf3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cf3.Location = new System.Drawing.Point(1432, 619);
            this.cf3.Name = "cf3";
            this.cf3.Size = new System.Drawing.Size(78, 28);
            this.cf3.TabIndex = 47;
            this.cf3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cf3_KeyDown);
            // 
            // crs1
            // 
            this.crs1.AutoSize = true;
            this.crs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crs1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.crs1.Location = new System.Drawing.Point(1566, 495);
            this.crs1.Name = "crs1";
            this.crs1.Size = new System.Drawing.Size(27, 29);
            this.crs1.TabIndex = 48;
            this.crs1.Text = "0";
            // 
            // crs2
            // 
            this.crs2.AutoSize = true;
            this.crs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crs2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.crs2.Location = new System.Drawing.Point(1566, 552);
            this.crs2.Name = "crs2";
            this.crs2.Size = new System.Drawing.Size(27, 29);
            this.crs2.TabIndex = 49;
            this.crs2.Text = "0";
            // 
            // crs3
            // 
            this.crs3.AutoSize = true;
            this.crs3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crs3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.crs3.Location = new System.Drawing.Point(1566, 619);
            this.crs3.Name = "crs3";
            this.crs3.Size = new System.Drawing.Size(27, 29);
            this.crs3.TabIndex = 50;
            this.crs3.Text = "0";
            // 
            // sm
            // 
            this.sm.AutoSize = true;
            this.sm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sm.Location = new System.Drawing.Point(1329, 673);
            this.sm.Name = "sm";
            this.sm.Size = new System.Drawing.Size(27, 29);
            this.sm.TabIndex = 51;
            this.sm.Text = "0";
            // 
            // srs
            // 
            this.srs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srs.Location = new System.Drawing.Point(1524, 675);
            this.srs.Name = "srs";
            this.srs.Size = new System.Drawing.Size(93, 28);
            this.srs.TabIndex = 52;
            this.srs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.srs_KeyDown);
            // 
            // pl
            // 
            this.pl.AutoSize = true;
            this.pl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pl.ForeColor = System.Drawing.Color.Red;
            this.pl.Location = new System.Drawing.Point(1394, 723);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(27, 29);
            this.pl.TabIndex = 53;
            this.pl.Text = "0";
            // 
            // mixx
            // 
            this.mixx.AutoSize = true;
            this.mixx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mixx.Location = new System.Drawing.Point(378, 261);
            this.mixx.Name = "mixx";
            this.mixx.Size = new System.Drawing.Size(16, 24);
            this.mixx.TabIndex = 54;
            this.mixx.Text = ".";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1399, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 35);
            this.button2.TabIndex = 55;
            this.button2.Text = "OUT +";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.printDocument2;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // printDocument3
            // 
            this.printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument3_PrintPage);
            // 
            // printPreviewDialog3
            // 
            this.printPreviewDialog3.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog3.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog3.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog3.Document = this.printDocument3;
            this.printPreviewDialog3.Enabled = true;
            this.printPreviewDialog3.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog3.Icon")));
            this.printPreviewDialog3.Name = "printPreviewDialog3";
            this.printPreviewDialog3.Visible = false;
            // 
            // verticalProgressBar1
            // 
            this.verticalProgressBar1.Location = new System.Drawing.Point(475, 92);
            this.verticalProgressBar1.Maximum = 300;
            this.verticalProgressBar1.Name = "verticalProgressBar1";
            this.verticalProgressBar1.Size = new System.Drawing.Size(90, 276);
            this.verticalProgressBar1.TabIndex = 17;
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(115, 27);
            this.colourToolStripMenuItem.Text = "    Colour    ";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mixx);
            this.Controls.Add(this.pl);
            this.Controls.Add(this.srs);
            this.Controls.Add(this.sm);
            this.Controls.Add(this.crs3);
            this.Controls.Add(this.crs2);
            this.Controls.Add(this.crs1);
            this.Controls.Add(this.cf3);
            this.Controls.Add(this.cm3);
            this.Controls.Add(this.cf2);
            this.Controls.Add(this.cm2);
            this.Controls.Add(this.cf1);
            this.Controls.Add(this.cm1);
            this.Controls.Add(this.totfat);
            this.Controls.Add(this.totrs);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.totmilk);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mix);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fatmix);
            this.Controls.Add(this.milkmix);
            this.Controls.Add(this.mixset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tm);
            this.Controls.Add(this.verticalProgressBar1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.view);
            this.Controls.Add(this.ap);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rs);
            this.Controls.Add(this.name);
            this.Controls.Add(this.fat);
            this.Controls.Add(this.milk);
            this.Controls.Add(this.sno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "                  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sno;
        private System.Windows.Forms.TextBox milk;
        private System.Windows.Forms.TextBox fat;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label rs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox ap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNumberToolStripMenuItem;
        private milkDataSet milkDataSet;
        private System.Windows.Forms.BindingSource milkDataSetBindingSource;
        private System.Windows.Forms.DataGridView view;
        private milkDataSet3 milkDataSet3;
        private System.Windows.Forms.BindingSource maindataBindingSource;
        private milkDataSet3TableAdapters.maindataTableAdapter maindataTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem finalPrintToolStripMenuItem;
        private System.Windows.Forms.Button save;
        private verticalProgressBar verticalProgressBar1;
        private System.Windows.Forms.Label tm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mixset;
        private System.Windows.Forms.TextBox milkmix;
        private System.Windows.Forms.TextBox fatmix;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label mix;
        private System.Windows.Forms.ToolStripMenuItem advancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label totmilk;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label totrs;
        private System.Windows.Forms.Label totfat;
        private System.Windows.Forms.TextBox cm1;
        private System.Windows.Forms.TextBox cf1;
        private System.Windows.Forms.TextBox cm2;
        private System.Windows.Forms.TextBox cf2;
        private System.Windows.Forms.TextBox cm3;
        private System.Windows.Forms.TextBox cf3;
        private System.Windows.Forms.Label crs1;
        private System.Windows.Forms.Label crs2;
        private System.Windows.Forms.Label crs3;
        private System.Windows.Forms.Label sm;
        private System.Windows.Forms.TextBox srs;
        private System.Windows.Forms.Label pl;
        private System.Windows.Forms.Label mixx;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Drawing.Printing.PrintDocument printDocument3;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog3;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno_;
        private System.Windows.Forms.DataGridViewTextBoxColumn milk_;
        private System.Windows.Forms.DataGridViewTextBoxColumn fat_;
        private System.Windows.Forms.DataGridViewTextBoxColumn rs_;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

