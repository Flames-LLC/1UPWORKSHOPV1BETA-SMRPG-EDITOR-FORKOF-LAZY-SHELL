﻿
namespace LazyShell
{
    partial class SettingsEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any global::LazyShell.Properties.Resources being used.
        /// </summary>
        /// <param name="disposing">true if managed global::LazyShell.Properties.Resources should be disposed; otherwise, false.</param>
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
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.customDirectoryTextBox = new System.Windows.Forms.TextBox();
			this.buttonDefault = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.visualThemeSystem = new System.Windows.Forms.RadioButton();
			this.visualThemeSimple = new System.Windows.Forms.RadioButton();
			this.patchHTTPServer = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.visualThemeBlue = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.romDirectory = new System.Windows.Forms.RadioButton();
			this.customDirectory = new System.Windows.Forms.RadioButton();
			this.buttonCustomDirectory = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.checkedListBox1.CheckOnClick = true;
			this.checkedListBox1.ColumnWidth = 214;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "Auto-load last used ROM",
            "Auto-create all editor data",
            "Auto-load last used Notes DB",
            "Create back-up ROM on save",
            "Create back-up ROM on load",
            "Verify ROM",
            "Show encryption warnings",
            "Remember last loaded indexes"});
			this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
			this.checkedListBox1.MultiColumn = true;
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(454, 68);
			this.checkedListBox1.TabIndex = 0;
			// 
			// customDirectoryTextBox
			// 
			this.customDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.customDirectoryTextBox.Location = new System.Drawing.Point(123, 35);
			this.customDirectoryTextBox.Name = "customDirectoryTextBox";
			this.customDirectoryTextBox.ReadOnly = true;
			this.customDirectoryTextBox.Size = new System.Drawing.Size(292, 21);
			this.customDirectoryTextBox.TabIndex = 2;
			// 
			// buttonDefault
			// 
			this.buttonDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDefault.Location = new System.Drawing.Point(12, 236);
			this.buttonDefault.Name = "buttonDefault";
			this.buttonDefault.Size = new System.Drawing.Size(75, 23);
			this.buttonDefault.TabIndex = 7;
			this.buttonDefault.Text = "Default...";
			this.buttonDefault.UseVisualStyleBackColor = true;
			this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
			// 
			// buttonApply
			// 
			this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonApply.Location = new System.Drawing.Point(391, 236);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 10;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// visualThemeSystem
			// 
			this.visualThemeSystem.AutoSize = true;
			this.visualThemeSystem.Location = new System.Drawing.Point(6, 20);
			this.visualThemeSystem.Name = "visualThemeSystem";
			this.visualThemeSystem.Size = new System.Drawing.Size(60, 17);
			this.visualThemeSystem.TabIndex = 0;
			this.visualThemeSystem.TabStop = true;
			this.visualThemeSystem.Text = "System";
			this.visualThemeSystem.UseVisualStyleBackColor = true;
			// 
			// visualThemeSimple
			// 
			this.visualThemeSimple.AutoSize = true;
			this.visualThemeSimple.Location = new System.Drawing.Point(6, 37);
			this.visualThemeSimple.Name = "visualThemeSimple";
			this.visualThemeSimple.Size = new System.Drawing.Size(55, 17);
			this.visualThemeSimple.TabIndex = 1;
			this.visualThemeSimple.TabStop = true;
			this.visualThemeSimple.Text = "Simple";
			this.visualThemeSimple.UseVisualStyleBackColor = true;
			// 
			// patchHTTPServer
			// 
			this.patchHTTPServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.patchHTTPServer.Location = new System.Drawing.Point(7, 24);
			this.patchHTTPServer.Name = "patchHTTPServer";
			this.patchHTTPServer.Size = new System.Drawing.Size(325, 21);
			this.patchHTTPServer.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.visualThemeBlue);
			this.groupBox1.Controls.Add(this.visualThemeSystem);
			this.groupBox1.Controls.Add(this.visualThemeSimple);
			this.groupBox1.Location = new System.Drawing.Point(12, 154);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(110, 76);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Visual Theme";
			// 
			// visualThemeBlue
			// 
			this.visualThemeBlue.AutoSize = true;
			this.visualThemeBlue.Location = new System.Drawing.Point(6, 54);
			this.visualThemeBlue.Name = "visualThemeBlue";
			this.visualThemeBlue.Size = new System.Drawing.Size(76, 17);
			this.visualThemeBlue.TabIndex = 2;
			this.visualThemeBlue.TabStop = true;
			this.visualThemeBlue.Text = "Blue (WIP)";
			this.visualThemeBlue.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.romDirectory);
			this.groupBox2.Controls.Add(this.customDirectory);
			this.groupBox2.Controls.Add(this.customDirectoryTextBox);
			this.groupBox2.Controls.Add(this.buttonCustomDirectory);
			this.groupBox2.Location = new System.Drawing.Point(12, 86);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(454, 62);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Back-up ROM location";
			// 
			// romDirectory
			// 
			this.romDirectory.AutoSize = true;
			this.romDirectory.Location = new System.Drawing.Point(6, 20);
			this.romDirectory.Name = "romDirectory";
			this.romDirectory.Size = new System.Drawing.Size(94, 17);
			this.romDirectory.TabIndex = 0;
			this.romDirectory.TabStop = true;
			this.romDirectory.Text = "ROM directory";
			this.romDirectory.UseVisualStyleBackColor = true;
			// 
			// customDirectory
			// 
			this.customDirectory.AutoSize = true;
			this.customDirectory.Location = new System.Drawing.Point(6, 37);
			this.customDirectory.Name = "customDirectory";
			this.customDirectory.Size = new System.Drawing.Size(111, 17);
			this.customDirectory.TabIndex = 1;
			this.customDirectory.TabStop = true;
			this.customDirectory.Text = "Custom directory:";
			this.customDirectory.UseVisualStyleBackColor = true;
			// 
			// buttonCustomDirectory
			// 
			this.buttonCustomDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCustomDirectory.Location = new System.Drawing.Point(421, 35);
			this.buttonCustomDirectory.Name = "buttonCustomDirectory";
			this.buttonCustomDirectory.Size = new System.Drawing.Size(27, 21);
			this.buttonCustomDirectory.TabIndex = 3;
			this.buttonCustomDirectory.Text = "...";
			this.buttonCustomDirectory.UseVisualStyleBackColor = true;
			this.buttonCustomDirectory.Click += new System.EventHandler(this.buttonCustomDirectory_Click);
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(310, 236);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 9;
			this.buttonClose.Text = "Cancel";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.Location = new System.Drawing.Point(229, 236);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 8;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.Controls.Add(this.patchHTTPServer);
			this.groupBox5.Location = new System.Drawing.Point(128, 170);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(338, 60);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Patch HTTP Server";
			// 
			// SettingsEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 271);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.buttonDefault);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "SettingsEditor";
			this.Text = "Preferences - Lazy Shell";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox customDirectoryTextBox;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.RadioButton visualThemeSystem;
        private System.Windows.Forms.RadioButton visualThemeSimple;
        private System.Windows.Forms.TextBox patchHTTPServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton romDirectory;
        private System.Windows.Forms.RadioButton customDirectory;
        private System.Windows.Forms.Button buttonCustomDirectory;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton visualThemeBlue;
	}
}