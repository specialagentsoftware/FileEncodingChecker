namespace TNTFileEncodeChecker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tNTEncodingCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seriouslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btncheck = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.lblsel = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.lblencoding = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tNTEncodingCheckerToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tNTEncodingCheckerToolStripMenuItem
            // 
            this.tNTEncodingCheckerToolStripMenuItem.Name = "tNTEncodingCheckerToolStripMenuItem";
            this.tNTEncodingCheckerToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tNTEncodingCheckerToolStripMenuItem.Text = "TNT Encoding Checker";
            this.tNTEncodingCheckerToolStripMenuItem.Click += new System.EventHandler(this.tNTEncodingCheckerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seriouslyToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // seriouslyToolStripMenuItem
            // 
            this.seriouslyToolStripMenuItem.Name = "seriouslyToolStripMenuItem";
            this.seriouslyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seriouslyToolStripMenuItem.Text = "Seriously?";
            this.seriouslyToolStripMenuItem.Click += new System.EventHandler(this.seriouslyToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "FileEndodingFileSelection";
            this.openFileDialog1.Title = "Select File To Check Encoding";
            // 
            // btncheck
            // 
            this.btncheck.Location = new System.Drawing.Point(35, 136);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(102, 31);
            this.btncheck.TabIndex = 1;
            this.btncheck.Text = "Check Encoding";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Visible = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(35, 38);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(102, 31);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.Location = new System.Drawing.Point(51, 102);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedFile.TabIndex = 4;
            this.lblSelectedFile.Visible = false;
            // 
            // lblsel
            // 
            this.lblsel.AutoSize = true;
            this.lblsel.Location = new System.Drawing.Point(35, 76);
            this.lblsel.Name = "lblsel";
            this.lblsel.Size = new System.Drawing.Size(71, 13);
            this.lblsel.TabIndex = 5;
            this.lblsel.Text = "Selected File:";
            this.lblsel.Visible = false;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(152, 136);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(101, 31);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Visible = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lblencoding
            // 
            this.lblencoding.AutoSize = true;
            this.lblencoding.Location = new System.Drawing.Point(38, 190);
            this.lblencoding.Name = "lblencoding";
            this.lblencoding.Size = new System.Drawing.Size(0, 13);
            this.lblencoding.TabIndex = 7;
            this.lblencoding.Visible = false;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(152, 136);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(101, 31);
            this.btnreset.TabIndex = 8;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Visible = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(380, 262);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.lblencoding);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.lblsel);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TNT Encoding Checker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tNTEncodingCheckerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seriouslyToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.Label lblsel;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label lblencoding;
        private System.Windows.Forms.Button btnreset;
    }
}

