namespace minesweeper
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sevenSegment3 = new DmitryBrant.CustomControls.SevenSegment();
            this.sevenSegment2 = new DmitryBrant.CustomControls.SevenSegment();
            this.sevenSegment1 = new DmitryBrant.CustomControls.SevenSegment();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Start.BackgroundImage = global::minesweeper.Properties.Resources.smiley;
            this.btn_Start.Location = new System.Drawing.Point(14, 3);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(57, 57);
            this.btn_Start.TabIndex = 81;
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.Size = new System.Drawing.Size(210, 210);
            this.dataGridView1.TabIndex = 83;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mouse_Down);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mouse_Up);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(234, 24);
            this.menuStrip1.TabIndex = 84;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.difficultyToolStripMenuItem.Text = "difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.easyToolStripMenuItem.Text = "easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.hardToolStripMenuItem.Text = "hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // sevenSegment3
            // 
            this.sevenSegment3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sevenSegment3.BackColor = System.Drawing.Color.Black;
            this.sevenSegment3.ColonOn = false;
            this.sevenSegment3.ColonShow = false;
            this.sevenSegment3.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegment3.ColorDark = System.Drawing.Color.DimGray;
            this.sevenSegment3.ColorLight = System.Drawing.Color.Red;
            this.sevenSegment3.CustomPattern = 0;
            this.sevenSegment3.DecimalOn = false;
            this.sevenSegment3.DecimalShow = true;
            this.sevenSegment3.ElementWidth = 10;
            this.sevenSegment3.ItalicFactor = 0F;
            this.sevenSegment3.Location = new System.Drawing.Point(77, 3);
            this.sevenSegment3.Name = "sevenSegment3";
            this.sevenSegment3.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegment3.Size = new System.Drawing.Size(24, 57);
            this.sevenSegment3.TabIndex = 86;
            this.sevenSegment3.TabStop = false;
            this.sevenSegment3.Value = null;
            // 
            // sevenSegment2
            // 
            this.sevenSegment2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sevenSegment2.BackColor = System.Drawing.Color.Black;
            this.sevenSegment2.ColonOn = false;
            this.sevenSegment2.ColonShow = false;
            this.sevenSegment2.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegment2.ColorDark = System.Drawing.Color.DimGray;
            this.sevenSegment2.ColorLight = System.Drawing.Color.Red;
            this.sevenSegment2.CustomPattern = 0;
            this.sevenSegment2.DecimalOn = false;
            this.sevenSegment2.DecimalShow = true;
            this.sevenSegment2.ElementWidth = 10;
            this.sevenSegment2.ItalicFactor = 0F;
            this.sevenSegment2.Location = new System.Drawing.Point(101, 3);
            this.sevenSegment2.Name = "sevenSegment2";
            this.sevenSegment2.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegment2.Size = new System.Drawing.Size(24, 57);
            this.sevenSegment2.TabIndex = 85;
            this.sevenSegment2.TabStop = false;
            this.sevenSegment2.Value = null;
            // 
            // sevenSegment1
            // 
            this.sevenSegment1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sevenSegment1.BackColor = System.Drawing.Color.Black;
            this.sevenSegment1.ColonOn = false;
            this.sevenSegment1.ColonShow = false;
            this.sevenSegment1.ColorBackground = System.Drawing.Color.DarkGray;
            this.sevenSegment1.ColorDark = System.Drawing.Color.DimGray;
            this.sevenSegment1.ColorLight = System.Drawing.Color.Red;
            this.sevenSegment1.CustomPattern = 0;
            this.sevenSegment1.DecimalOn = false;
            this.sevenSegment1.DecimalShow = true;
            this.sevenSegment1.ElementWidth = 10;
            this.sevenSegment1.ItalicFactor = 0F;
            this.sevenSegment1.Location = new System.Drawing.Point(125, 3);
            this.sevenSegment1.Name = "sevenSegment1";
            this.sevenSegment1.Padding = new System.Windows.Forms.Padding(4);
            this.sevenSegment1.Size = new System.Drawing.Size(24, 57);
            this.sevenSegment1.TabIndex = 82;
            this.sevenSegment1.TabStop = false;
            this.sevenSegment1.Value = null;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_Start);
            this.panel1.Controls.Add(this.sevenSegment2);
            this.panel1.Controls.Add(this.sevenSegment3);
            this.panel1.Controls.Add(this.sevenSegment1);
            this.panel1.Location = new System.Drawing.Point(32, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 61);
            this.panel1.TabIndex = 87;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "mine sweeper";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Start;
        private DmitryBrant.CustomControls.SevenSegment sevenSegment1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private DmitryBrant.CustomControls.SevenSegment sevenSegment2;
        private DmitryBrant.CustomControls.SevenSegment sevenSegment3;
        private System.Windows.Forms.Panel panel1;
    }
}

