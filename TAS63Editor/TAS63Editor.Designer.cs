using System;

namespace TAS63Editor
{
	partial class TAS63Editor
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
			this.InputsBox = new System.Windows.Forms.ListBox();
			this.DCheck = new System.Windows.Forms.CheckBox();
			this.UCheck = new System.Windows.Forms.CheckBox();
			this.LCheck = new System.Windows.Forms.CheckBox();
			this.RCheck = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.CCheck = new System.Windows.Forms.CheckBox();
			this.XCheck = new System.Windows.Forms.CheckBox();
			this.ZCheck = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.PlusLabel = new System.Windows.Forms.Label();
			this.PlusCheck = new System.Windows.Forms.CheckBox();
			this.MinusLabel = new System.Windows.Forms.Label();
			this.MinusCheck = new System.Windows.Forms.CheckBox();
			this.SLabel = new System.Windows.Forms.Label();
			this.SCheck = new System.Windows.Forms.CheckBox();
			this.PLabel = new System.Windows.Forms.Label();
			this.PCheck = new System.Windows.Forms.CheckBox();
			this.SemiLabel = new System.Windows.Forms.Label();
			this.SemiCheck = new System.Windows.Forms.CheckBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToTAS63PlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.discordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddFrame = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.RemoveFrame = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.MouseYTextbox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.MouseXLabel = new System.Windows.Forms.Label();
			this.MouseCheck = new System.Windows.Forms.CheckBox();
			this.MouseXTextbox = new System.Windows.Forms.TextBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.RngBox = new System.Windows.Forms.ListBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.DuplicateFrame = new System.Windows.Forms.Button();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.GenerateCount = new System.Windows.Forms.NumericUpDown();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.RandomButton = new System.Windows.Forms.Button();
			this.RngValue = new System.Windows.Forms.NumericUpDown();
			this.AddEvent = new System.Windows.Forms.Button();
			this.RemoveEvent = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GenerateCount)).BeginInit();
			this.groupBox10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RngValue)).BeginInit();
			this.SuspendLayout();
			// 
			// InputsBox
			// 
			this.InputsBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.InputsBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InputsBox.FormattingEnabled = true;
			this.InputsBox.ItemHeight = 12;
			this.InputsBox.Location = new System.Drawing.Point(3, 16);
			this.InputsBox.Name = "InputsBox";
			this.InputsBox.Size = new System.Drawing.Size(167, 365);
			this.InputsBox.TabIndex = 0;
			this.InputsBox.SelectedIndexChanged += new System.EventHandler(this.InputsBox_SelectedIndexChanged);
			// 
			// DCheck
			// 
			this.DCheck.AutoSize = true;
			this.DCheck.Location = new System.Drawing.Point(27, 39);
			this.DCheck.Name = "DCheck";
			this.DCheck.Size = new System.Drawing.Size(15, 14);
			this.DCheck.TabIndex = 1;
			this.DCheck.UseVisualStyleBackColor = true;
			this.DCheck.CheckedChanged += new System.EventHandler(this.DCheck_CheckedChanged);
			// 
			// UCheck
			// 
			this.UCheck.AutoSize = true;
			this.UCheck.Location = new System.Drawing.Point(27, 19);
			this.UCheck.Name = "UCheck";
			this.UCheck.Size = new System.Drawing.Size(15, 14);
			this.UCheck.TabIndex = 2;
			this.UCheck.UseVisualStyleBackColor = true;
			this.UCheck.CheckedChanged += new System.EventHandler(this.UCheck_CheckedChanged);
			// 
			// LCheck
			// 
			this.LCheck.AutoSize = true;
			this.LCheck.Location = new System.Drawing.Point(6, 39);
			this.LCheck.Name = "LCheck";
			this.LCheck.Size = new System.Drawing.Size(15, 14);
			this.LCheck.TabIndex = 3;
			this.LCheck.UseVisualStyleBackColor = true;
			this.LCheck.CheckedChanged += new System.EventHandler(this.LCheck_CheckedChanged);
			// 
			// RCheck
			// 
			this.RCheck.AutoSize = true;
			this.RCheck.Location = new System.Drawing.Point(48, 39);
			this.RCheck.Name = "RCheck";
			this.RCheck.Size = new System.Drawing.Size(15, 14);
			this.RCheck.TabIndex = 4;
			this.RCheck.UseVisualStyleBackColor = true;
			this.RCheck.CheckedChanged += new System.EventHandler(this.RCheck_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RCheck);
			this.groupBox1.Controls.Add(this.DCheck);
			this.groupBox1.Controls.Add(this.LCheck);
			this.groupBox1.Controls.Add(this.UCheck);
			this.groupBox1.Location = new System.Drawing.Point(6, 19);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(67, 59);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Arrows";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.CCheck);
			this.groupBox2.Controls.Add(this.XCheck);
			this.groupBox2.Controls.Add(this.ZCheck);
			this.groupBox2.Location = new System.Drawing.Point(78, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(67, 59);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "ZXC";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(48, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "C";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "X";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(14, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Z";
			// 
			// CCheck
			// 
			this.CCheck.AutoSize = true;
			this.CCheck.Location = new System.Drawing.Point(48, 19);
			this.CCheck.Name = "CCheck";
			this.CCheck.Size = new System.Drawing.Size(15, 14);
			this.CCheck.TabIndex = 4;
			this.CCheck.UseVisualStyleBackColor = true;
			this.CCheck.CheckedChanged += new System.EventHandler(this.CCheck_CheckedChanged);
			// 
			// XCheck
			// 
			this.XCheck.AutoSize = true;
			this.XCheck.Location = new System.Drawing.Point(27, 19);
			this.XCheck.Name = "XCheck";
			this.XCheck.Size = new System.Drawing.Size(15, 14);
			this.XCheck.TabIndex = 1;
			this.XCheck.UseVisualStyleBackColor = true;
			this.XCheck.CheckedChanged += new System.EventHandler(this.XCheck_CheckedChanged);
			// 
			// ZCheck
			// 
			this.ZCheck.AutoSize = true;
			this.ZCheck.Location = new System.Drawing.Point(6, 19);
			this.ZCheck.Name = "ZCheck";
			this.ZCheck.Size = new System.Drawing.Size(15, 14);
			this.ZCheck.TabIndex = 3;
			this.ZCheck.UseVisualStyleBackColor = true;
			this.ZCheck.CheckedChanged += new System.EventHandler(this.ZCheck_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.PlusLabel);
			this.groupBox3.Controls.Add(this.PlusCheck);
			this.groupBox3.Controls.Add(this.MinusLabel);
			this.groupBox3.Controls.Add(this.MinusCheck);
			this.groupBox3.Controls.Add(this.SLabel);
			this.groupBox3.Controls.Add(this.SCheck);
			this.groupBox3.Controls.Add(this.PLabel);
			this.groupBox3.Controls.Add(this.PCheck);
			this.groupBox3.Controls.Add(this.SemiLabel);
			this.groupBox3.Controls.Add(this.SemiCheck);
			this.groupBox3.Location = new System.Drawing.Point(6, 84);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(114, 59);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Misc";
			// 
			// PlusLabel
			// 
			this.PlusLabel.AutoSize = true;
			this.PlusLabel.Location = new System.Drawing.Point(90, 38);
			this.PlusLabel.Name = "PlusLabel";
			this.PlusLabel.Size = new System.Drawing.Size(13, 13);
			this.PlusLabel.TabIndex = 11;
			this.PlusLabel.Text = "+";
			// 
			// PlusCheck
			// 
			this.PlusCheck.AutoSize = true;
			this.PlusCheck.Location = new System.Drawing.Point(90, 19);
			this.PlusCheck.Name = "PlusCheck";
			this.PlusCheck.Size = new System.Drawing.Size(15, 14);
			this.PlusCheck.TabIndex = 10;
			this.PlusCheck.UseVisualStyleBackColor = true;
			this.PlusCheck.CheckedChanged += new System.EventHandler(this.PlusCheck_CheckedChanged);
			// 
			// MinusLabel
			// 
			this.MinusLabel.AutoSize = true;
			this.MinusLabel.Location = new System.Drawing.Point(71, 39);
			this.MinusLabel.Name = "MinusLabel";
			this.MinusLabel.Size = new System.Drawing.Size(10, 13);
			this.MinusLabel.TabIndex = 9;
			this.MinusLabel.Text = "-";
			// 
			// MinusCheck
			// 
			this.MinusCheck.AutoSize = true;
			this.MinusCheck.Location = new System.Drawing.Point(69, 19);
			this.MinusCheck.Name = "MinusCheck";
			this.MinusCheck.Size = new System.Drawing.Size(15, 14);
			this.MinusCheck.TabIndex = 8;
			this.MinusCheck.UseVisualStyleBackColor = true;
			this.MinusCheck.CheckedChanged += new System.EventHandler(this.MinusCheck_CheckedChanged);
			// 
			// SLabel
			// 
			this.SLabel.AutoSize = true;
			this.SLabel.Location = new System.Drawing.Point(27, 39);
			this.SLabel.Name = "SLabel";
			this.SLabel.Size = new System.Drawing.Size(14, 13);
			this.SLabel.TabIndex = 6;
			this.SLabel.Text = "S";
			// 
			// SCheck
			// 
			this.SCheck.AutoSize = true;
			this.SCheck.Location = new System.Drawing.Point(27, 19);
			this.SCheck.Name = "SCheck";
			this.SCheck.Size = new System.Drawing.Size(15, 14);
			this.SCheck.TabIndex = 1;
			this.SCheck.UseVisualStyleBackColor = true;
			this.SCheck.CheckedChanged += new System.EventHandler(this.SCheck_CheckedChanged);
			// 
			// PLabel
			// 
			this.PLabel.AutoSize = true;
			this.PLabel.Location = new System.Drawing.Point(6, 39);
			this.PLabel.Name = "PLabel";
			this.PLabel.Size = new System.Drawing.Size(14, 13);
			this.PLabel.TabIndex = 5;
			this.PLabel.Text = "P";
			// 
			// PCheck
			// 
			this.PCheck.AutoSize = true;
			this.PCheck.Location = new System.Drawing.Point(6, 19);
			this.PCheck.Name = "PCheck";
			this.PCheck.Size = new System.Drawing.Size(15, 14);
			this.PCheck.TabIndex = 3;
			this.PCheck.UseVisualStyleBackColor = true;
			this.PCheck.CheckedChanged += new System.EventHandler(this.PCheck_CheckedChanged);
			// 
			// SemiLabel
			// 
			this.SemiLabel.AutoSize = true;
			this.SemiLabel.Location = new System.Drawing.Point(50, 37);
			this.SemiLabel.Name = "SemiLabel";
			this.SemiLabel.Size = new System.Drawing.Size(10, 13);
			this.SemiLabel.TabIndex = 7;
			this.SemiLabel.Text = ";";
			// 
			// SemiCheck
			// 
			this.SemiCheck.AutoSize = true;
			this.SemiCheck.Location = new System.Drawing.Point(48, 19);
			this.SemiCheck.Name = "SemiCheck";
			this.SemiCheck.Size = new System.Drawing.Size(15, 14);
			this.SemiCheck.TabIndex = 4;
			this.SemiCheck.UseVisualStyleBackColor = true;
			this.SemiCheck.CheckedChanged += new System.EventHandler(this.SemiCheck_CheckedChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(694, 25);
			this.toolStrip1.TabIndex = 9;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.importToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToTAS63PlayerToolStripMenuItem});
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
			this.toolStripDropDownButton1.Text = "File";
			this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
			this.importToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.importToolStripMenuItem.Text = "Import";
			this.importToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.saveAsToolStripMenuItem.Text = "Save As";
			this.saveAsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// saveToTAS63PlayerToolStripMenuItem
			// 
			this.saveToTAS63PlayerToolStripMenuItem.Name = "saveToTAS63PlayerToolStripMenuItem";
			this.saveToTAS63PlayerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
			this.saveToTAS63PlayerToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.saveToTAS63PlayerToolStripMenuItem.Text = "Save to TAS63 Player";
			this.saveToTAS63PlayerToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.documentationToolStripMenuItem,
            this.githubToolStripMenuItem,
            this.discordToolStripMenuItem});
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(45, 22);
			this.toolStripDropDownButton2.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// documentationToolStripMenuItem
			// 
			this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
			this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.documentationToolStripMenuItem.Text = "Documentation";
			// 
			// githubToolStripMenuItem
			// 
			this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
			this.githubToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.githubToolStripMenuItem.Text = "Github";
			this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
			// 
			// discordToolStripMenuItem
			// 
			this.discordToolStripMenuItem.Name = "discordToolStripMenuItem";
			this.discordToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.discordToolStripMenuItem.Text = "Discord";
			this.discordToolStripMenuItem.Click += new System.EventHandler(this.discordToolStripMenuItem_Click);
			// 
			// AddFrame
			// 
			this.AddFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AddFrame.Location = new System.Drawing.Point(185, 35);
			this.AddFrame.Name = "AddFrame";
			this.AddFrame.Size = new System.Drawing.Size(23, 23);
			this.AddFrame.TabIndex = 10;
			this.AddFrame.Text = "+";
			this.AddFrame.UseVisualStyleBackColor = true;
			this.AddFrame.Click += new System.EventHandler(this.AddFrame_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.groupBox1);
			this.groupBox4.Controls.Add(this.groupBox2);
			this.groupBox4.Controls.Add(this.groupBox3);
			this.groupBox4.Location = new System.Drawing.Point(214, 19);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(151, 149);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Keys";
			// 
			// RemoveFrame
			// 
			this.RemoveFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoveFrame.Location = new System.Drawing.Point(185, 64);
			this.RemoveFrame.Name = "RemoveFrame";
			this.RemoveFrame.Size = new System.Drawing.Size(23, 23);
			this.RemoveFrame.TabIndex = 12;
			this.RemoveFrame.Text = "-";
			this.RemoveFrame.UseVisualStyleBackColor = true;
			this.RemoveFrame.Click += new System.EventHandler(this.RemoveFrame_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.Controls.Add(this.InputsBox);
			this.groupBox5.Location = new System.Drawing.Point(6, 19);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(173, 384);
			this.groupBox5.TabIndex = 13;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Frames";
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox6.Controls.Add(this.MouseYTextbox);
			this.groupBox6.Controls.Add(this.label4);
			this.groupBox6.Controls.Add(this.MouseXLabel);
			this.groupBox6.Controls.Add(this.MouseCheck);
			this.groupBox6.Controls.Add(this.MouseXTextbox);
			this.groupBox6.Location = new System.Drawing.Point(214, 174);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(84, 100);
			this.groupBox6.TabIndex = 14;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Mouse";
			// 
			// MouseYTextbox
			// 
			this.MouseYTextbox.Location = new System.Drawing.Point(32, 68);
			this.MouseYTextbox.Name = "MouseYTextbox";
			this.MouseYTextbox.Size = new System.Drawing.Size(41, 20);
			this.MouseYTextbox.TabIndex = 14;
			this.MouseYTextbox.TextChanged += new System.EventHandler(this.MouseYTextbox_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Y:";
			// 
			// MouseXLabel
			// 
			this.MouseXLabel.AutoSize = true;
			this.MouseXLabel.Location = new System.Drawing.Point(9, 45);
			this.MouseXLabel.Name = "MouseXLabel";
			this.MouseXLabel.Size = new System.Drawing.Size(17, 13);
			this.MouseXLabel.TabIndex = 12;
			this.MouseXLabel.Text = "X:";
			// 
			// MouseCheck
			// 
			this.MouseCheck.AutoSize = true;
			this.MouseCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.MouseCheck.Location = new System.Drawing.Point(6, 19);
			this.MouseCheck.Name = "MouseCheck";
			this.MouseCheck.Size = new System.Drawing.Size(48, 17);
			this.MouseCheck.TabIndex = 2;
			this.MouseCheck.Text = "Held";
			this.MouseCheck.UseVisualStyleBackColor = true;
			this.MouseCheck.CheckedChanged += new System.EventHandler(this.MouseCheck_CheckedChanged);
			// 
			// MouseXTextbox
			// 
			this.MouseXTextbox.Location = new System.Drawing.Point(32, 42);
			this.MouseXTextbox.Name = "MouseXTextbox";
			this.MouseXTextbox.Size = new System.Drawing.Size(41, 20);
			this.MouseXTextbox.TabIndex = 1;
			this.MouseXTextbox.TextChanged += new System.EventHandler(this.MouseXTextbox_TextChanged);
			// 
			// groupBox7
			// 
			this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox7.Controls.Add(this.RngBox);
			this.groupBox7.Location = new System.Drawing.Point(6, 19);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(105, 384);
			this.groupBox7.TabIndex = 14;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Events";
			// 
			// RngBox
			// 
			this.RngBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.RngBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RngBox.FormattingEnabled = true;
			this.RngBox.ItemHeight = 12;
			this.RngBox.Location = new System.Drawing.Point(3, 16);
			this.RngBox.Name = "RngBox";
			this.RngBox.Size = new System.Drawing.Size(99, 365);
			this.RngBox.TabIndex = 0;
			this.RngBox.SelectedIndexChanged += new System.EventHandler(this.RngBox_SelectedIndexChanged);
			// 
			// groupBox8
			// 
			this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox8.Controls.Add(this.DuplicateFrame);
			this.groupBox8.Controls.Add(this.groupBox5);
			this.groupBox8.Controls.Add(this.groupBox4);
			this.groupBox8.Controls.Add(this.groupBox6);
			this.groupBox8.Controls.Add(this.AddFrame);
			this.groupBox8.Controls.Add(this.RemoveFrame);
			this.groupBox8.Location = new System.Drawing.Point(12, 28);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(377, 409);
			this.groupBox8.TabIndex = 15;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Inputs";
			// 
			// DuplicateFrame
			// 
			this.DuplicateFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DuplicateFrame.Location = new System.Drawing.Point(185, 93);
			this.DuplicateFrame.Name = "DuplicateFrame";
			this.DuplicateFrame.Size = new System.Drawing.Size(23, 23);
			this.DuplicateFrame.TabIndex = 15;
			this.DuplicateFrame.Text = "*";
			this.DuplicateFrame.UseVisualStyleBackColor = true;
			this.DuplicateFrame.Click += new System.EventHandler(this.DuplicateFrame_Click);
			// 
			// groupBox9
			// 
			this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox9.Controls.Add(this.groupBox11);
			this.groupBox9.Controls.Add(this.groupBox10);
			this.groupBox9.Controls.Add(this.AddEvent);
			this.groupBox9.Controls.Add(this.RemoveEvent);
			this.groupBox9.Controls.Add(this.groupBox7);
			this.groupBox9.Location = new System.Drawing.Point(395, 28);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(286, 409);
			this.groupBox9.TabIndex = 16;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "RNG";
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.GenerateButton);
			this.groupBox11.Controls.Add(this.label5);
			this.groupBox11.Controls.Add(this.GenerateCount);
			this.groupBox11.Location = new System.Drawing.Point(146, 77);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(101, 76);
			this.groupBox11.TabIndex = 18;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Generate Noise";
			// 
			// GenerateButton
			// 
			this.GenerateButton.Location = new System.Drawing.Point(21, 45);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(59, 24);
			this.GenerateButton.TabIndex = 18;
			this.GenerateButton.Text = "Generate";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 15;
			this.label5.Text = "Count:";
			// 
			// GenerateCount
			// 
			this.GenerateCount.Location = new System.Drawing.Point(50, 19);
			this.GenerateCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.GenerateCount.Name = "GenerateCount";
			this.GenerateCount.Size = new System.Drawing.Size(45, 20);
			this.GenerateCount.TabIndex = 18;
			this.GenerateCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.RandomButton);
			this.groupBox10.Controls.Add(this.RngValue);
			this.groupBox10.Location = new System.Drawing.Point(146, 19);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(132, 52);
			this.groupBox10.TabIndex = 12;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Value";
			// 
			// RandomButton
			// 
			this.RandomButton.Location = new System.Drawing.Point(57, 17);
			this.RandomButton.Name = "RandomButton";
			this.RandomButton.Size = new System.Drawing.Size(69, 24);
			this.RandomButton.TabIndex = 17;
			this.RandomButton.Text = "Randomise";
			this.RandomButton.UseVisualStyleBackColor = true;
			this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
			// 
			// RngValue
			// 
			this.RngValue.Location = new System.Drawing.Point(6, 19);
			this.RngValue.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.RngValue.Name = "RngValue";
			this.RngValue.Size = new System.Drawing.Size(45, 20);
			this.RngValue.TabIndex = 16;
			this.RngValue.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.RngValue.ValueChanged += new System.EventHandler(this.RngValue_ValueChanged);
			// 
			// AddEvent
			// 
			this.AddEvent.Location = new System.Drawing.Point(117, 35);
			this.AddEvent.Name = "AddEvent";
			this.AddEvent.Size = new System.Drawing.Size(23, 23);
			this.AddEvent.TabIndex = 15;
			this.AddEvent.Text = "+";
			this.AddEvent.UseVisualStyleBackColor = true;
			this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
			// 
			// RemoveEvent
			// 
			this.RemoveEvent.Location = new System.Drawing.Point(117, 64);
			this.RemoveEvent.Name = "RemoveEvent";
			this.RemoveEvent.Size = new System.Drawing.Size(23, 23);
			this.RemoveEvent.TabIndex = 16;
			this.RemoveEvent.Text = "-";
			this.RemoveEvent.UseVisualStyleBackColor = true;
			this.RemoveEvent.Click += new System.EventHandler(this.RemoveEvent_Click);
			// 
			// TAS63Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(694, 451);
			this.Controls.Add(this.groupBox9);
			this.Controls.Add(this.groupBox8);
			this.Controls.Add(this.toolStrip1);
			this.Name = "TAS63Editor";
			this.Text = "TAS63 Editor";
			this.Load += new System.EventHandler(this.TAS63Editor_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TAS63Editor_KeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox11.ResumeLayout(false);
			this.groupBox11.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GenerateCount)).EndInit();
			this.groupBox10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.RngValue)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox InputsBox;
		private System.Windows.Forms.CheckBox DCheck;
		private System.Windows.Forms.CheckBox UCheck;
		private System.Windows.Forms.CheckBox LCheck;
		private System.Windows.Forms.CheckBox RCheck;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox CCheck;
		private System.Windows.Forms.CheckBox XCheck;
		private System.Windows.Forms.CheckBox ZCheck;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label PlusLabel;
		private System.Windows.Forms.CheckBox PlusCheck;
		private System.Windows.Forms.Label MinusLabel;
		private System.Windows.Forms.CheckBox MinusCheck;
		private System.Windows.Forms.Label SemiLabel;
		private System.Windows.Forms.Label SLabel;
		private System.Windows.Forms.Label PLabel;
		private System.Windows.Forms.CheckBox SemiCheck;
		private System.Windows.Forms.CheckBox SCheck;
		private System.Windows.Forms.CheckBox PCheck;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem discordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToTAS63PlayerToolStripMenuItem;
		private System.Windows.Forms.Button AddFrame;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button RemoveFrame;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox MouseYTextbox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label MouseXLabel;
		private System.Windows.Forms.CheckBox MouseCheck;
		private System.Windows.Forms.TextBox MouseXTextbox;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.ListBox RngBox;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.Button RandomButton;
		private System.Windows.Forms.NumericUpDown RngValue;
		private System.Windows.Forms.Button AddEvent;
		private System.Windows.Forms.Button RemoveEvent;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.NumericUpDown GenerateCount;
		private System.Windows.Forms.Button GenerateButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button DuplicateFrame;
	}
}

