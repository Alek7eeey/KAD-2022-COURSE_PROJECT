namespace Interface
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.NameOfTransl = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.iconGitHub = new System.Windows.Forms.PictureBox();
            this.iconVK = new System.Windows.Forms.PictureBox();
            this.iconInst = new System.Windows.Forms.PictureBox();
            this.compile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dfdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTXTMain = new System.Windows.Forms.MenuStrip();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.stroke = new System.Windows.Forms.Label();
            this.Symbol = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.autocompleteMenu2 = new AutocompleteMenuNS.AutocompleteMenu();
            ((System.ComponentModel.ISupportInitialize)(this.iconGitHub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconVK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconInst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTextBox)).BeginInit();
            this.menuTXTMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfTransl
            // 
            this.NameOfTransl.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfTransl.Location = new System.Drawing.Point(-16, 9);
            this.NameOfTransl.Name = "NameOfTransl";
            this.NameOfTransl.Size = new System.Drawing.Size(409, 71);
            this.NameOfTransl.TabIndex = 1;
            this.NameOfTransl.Text = "KAD 2022 - POIT_5";
            this.NameOfTransl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameOfTransl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NameOfTransl_MouseDown);
            this.NameOfTransl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NameOfTransl_MouseMove);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.labelExit.Location = new System.Drawing.Point(879, 1);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(41, 40);
            this.labelExit.TabIndex = 4;
            this.labelExit.Text = "x";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseEnter += new System.EventHandler(this.labelExit_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            // 
            // iconGitHub
            // 
            this.iconGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconGitHub.Image = ((System.Drawing.Image)(resources.GetObject("iconGitHub.Image")));
            this.iconGitHub.Location = new System.Drawing.Point(846, 628);
            this.iconGitHub.Name = "iconGitHub";
            this.iconGitHub.Size = new System.Drawing.Size(65, 64);
            this.iconGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconGitHub.TabIndex = 7;
            this.iconGitHub.TabStop = false;
            this.iconGitHub.Click += new System.EventHandler(this.iconGitHub_Click);
            // 
            // iconVK
            // 
            this.iconVK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconVK.Image = ((System.Drawing.Image)(resources.GetObject("iconVK.Image")));
            this.iconVK.Location = new System.Drawing.Point(763, 628);
            this.iconVK.Name = "iconVK";
            this.iconVK.Size = new System.Drawing.Size(65, 64);
            this.iconVK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconVK.TabIndex = 6;
            this.iconVK.TabStop = false;
            this.iconVK.Click += new System.EventHandler(this.iconVK_Click);
            // 
            // iconInst
            // 
            this.iconInst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconInst.Image = ((System.Drawing.Image)(resources.GetObject("iconInst.Image")));
            this.iconInst.Location = new System.Drawing.Point(679, 628);
            this.iconInst.Name = "iconInst";
            this.iconInst.Size = new System.Drawing.Size(65, 64);
            this.iconInst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconInst.TabIndex = 5;
            this.iconInst.TabStop = false;
            this.iconInst.Click += new System.EventHandler(this.iconInst_Click);
            // 
            // compile
            // 
            this.compile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compile.FlatAppearance.BorderSize = 2;
            this.compile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compile.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compile.Location = new System.Drawing.Point(90, 628);
            this.compile.Name = "compile";
            this.compile.Size = new System.Drawing.Size(262, 64);
            this.compile.TabIndex = 11;
            this.compile.Text = "compile ";
            this.compile.UseVisualStyleBackColor = true;
            this.compile.Click += new System.EventHandler(this.compile_Click_1);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(384, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 64);
            this.button1.TabIndex = 12;
            this.button1.Text = "compile asm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // newTextBox
            // 
            this.newTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.autocompleteMenu2.SetAutocompleteMenu(this.newTextBox, null);
            this.newTextBox.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.newTextBox.AutoScrollMinSize = new System.Drawing.Size(33, 20);
            this.newTextBox.BackBrush = null;
            this.newTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.newTextBox.BookmarkColor = System.Drawing.SystemColors.Highlight;
            this.newTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.newTextBox.CharHeight = 20;
            this.newTextBox.CharWidth = 11;
            this.newTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.newTextBox.Font = new System.Drawing.Font("Courier New", 9F);
            this.newTextBox.IndentBackColor = System.Drawing.Color.DimGray;
            this.newTextBox.IsReplaceMode = false;
            this.newTextBox.LineNumberColor = System.Drawing.Color.SpringGreen;
            this.newTextBox.Location = new System.Drawing.Point(12, 75);
            this.newTextBox.Name = "newTextBox";
            this.newTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.newTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.newTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("newTextBox.ServiceColors")));
            this.newTextBox.Size = new System.Drawing.Size(898, 530);
            this.newTextBox.TabIndex = 14;
            this.newTextBox.Zoom = 100;
            this.newTextBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.newTextBox_TextChanged);
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdfsToolStripMenuItem,
            this.dfdfToolStripMenuItem,
            this.sdToolStripMenuItem,
            this.sdToolStripMenuItem1});
            this.menu.Font = new System.Drawing.Font("Showcard Gothic", 9F);
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(43, 38);
            this.menu.Text = "Work with txt-files";
            // 
            // sdfsToolStripMenuItem
            // 
            this.sdfsToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdfsToolStripMenuItem.Name = "sdfsToolStripMenuItem";
            this.sdfsToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.sdfsToolStripMenuItem.Text = "Open txt-file";
            this.sdfsToolStripMenuItem.Click += new System.EventHandler(this.sdfsToolStripMenuItem_Click);
            // 
            // dfdfToolStripMenuItem
            // 
            this.dfdfToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfdfToolStripMenuItem.Name = "dfdfToolStripMenuItem";
            this.dfdfToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.dfdfToolStripMenuItem.Text = "Open LOG-file";
            this.dfdfToolStripMenuItem.Click += new System.EventHandler(this.dfdfToolStripMenuItem_Click);
            // 
            // sdToolStripMenuItem
            // 
            this.sdToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdToolStripMenuItem.Name = "sdToolStripMenuItem";
            this.sdToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.sdToolStripMenuItem.Text = "Open lexTable";
            this.sdToolStripMenuItem.Click += new System.EventHandler(this.sdToolStripMenuItem_Click);
            // 
            // sdToolStripMenuItem1
            // 
            this.sdToolStripMenuItem1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdToolStripMenuItem1.Name = "sdToolStripMenuItem1";
            this.sdToolStripMenuItem1.Size = new System.Drawing.Size(248, 34);
            this.sdToolStripMenuItem1.Text = "Open idTable";
            this.sdToolStripMenuItem1.Click += new System.EventHandler(this.sdToolStripMenuItem1_Click);
            // 
            // menuTXTMain
            // 
            this.menuTXTMain.BackColor = System.Drawing.Color.Transparent;
            this.menuTXTMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuTXTMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuTXTMain.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTXTMain.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuTXTMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuTXTMain.Location = new System.Drawing.Point(9, 628);
            this.menuTXTMain.Name = "menuTXTMain";
            this.menuTXTMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuTXTMain.Size = new System.Drawing.Size(51, 42);
            this.menuTXTMain.TabIndex = 9;
            this.menuTXTMain.Text = "menuStrip1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(325, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // stroke
            // 
            this.stroke.AutoSize = true;
            this.stroke.Location = new System.Drawing.Point(3, 7);
            this.stroke.Name = "stroke";
            this.stroke.Size = new System.Drawing.Size(59, 20);
            this.stroke.TabIndex = 16;
            this.stroke.Text = "Cтрок:";
            // 
            // Symbol
            // 
            this.Symbol.AutoSize = true;
            this.Symbol.Location = new System.Drawing.Point(3, 33);
            this.Symbol.Name = "Symbol";
            this.Symbol.Size = new System.Drawing.Size(90, 20);
            this.Symbol.TabIndex = 17;
            this.Symbol.Text = "Символов:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Symbol);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.stroke);
            this.panel1.Location = new System.Drawing.Point(476, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 60);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(161, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(215, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // autocompleteMenu2
            // 
            this.autocompleteMenu2.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu2.Colors")));
            this.autocompleteMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu2.ImageList = null;
            this.autocompleteMenu2.Items = new string[0];
            this.autocompleteMenu2.TargetControlWrapper = null;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(930, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.compile);
            this.Controls.Add(this.iconGitHub);
            this.Controls.Add(this.iconVK);
            this.Controls.Add(this.iconInst);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.NameOfTransl);
            this.Controls.Add(this.menuTXTMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTXTMain;
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.iconGitHub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconVK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconInst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTextBox)).EndInit();
            this.menuTXTMain.ResumeLayout(false);
            this.menuTXTMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameOfTransl;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.PictureBox iconGitHub;
        private System.Windows.Forms.PictureBox iconVK;
        private System.Windows.Forms.PictureBox iconInst;
        private System.Windows.Forms.Button compile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public FastColoredTextBoxNS.FastColoredTextBox newTextBox;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem sdfsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dfdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuTXTMain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label stroke;
        private System.Windows.Forms.Label Symbol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu2;
    }
}