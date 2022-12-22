namespace Interface
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.NameOfTransl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // inputSearch
            // 
            this.inputSearch.Font = new System.Drawing.Font("Courier New", 9F);
            this.inputSearch.Location = new System.Drawing.Point(45, 55);
            this.inputSearch.Multiline = true;
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(398, 35);
            this.inputSearch.TabIndex = 0;
            // 
            // NameOfTransl
            // 
            this.NameOfTransl.Font = new System.Drawing.Font("Courier New", 9F);
            this.NameOfTransl.Location = new System.Drawing.Point(-14, 29);
            this.NameOfTransl.Name = "NameOfTransl";
            this.NameOfTransl.Size = new System.Drawing.Size(390, 23);
            this.NameOfTransl.TabIndex = 2;
            this.NameOfTransl.Text = "Введите слово для поиска";
            this.NameOfTransl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameOfTransl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NameOfTransl_MouseDown);
            this.NameOfTransl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NameOfTransl_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(487, 168);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NameOfTransl);
            this.Controls.Add(this.inputSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.Text = "Search";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Search_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Search_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Label NameOfTransl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}