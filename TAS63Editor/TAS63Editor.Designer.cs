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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TAS63Editor));
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
			this.label8 = new System.Windows.Forms.Label();
			this.PlusCheck = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.MinusCheck = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SemiCheck = new System.Windows.Forms.CheckBox();
			this.SCheck = new System.Windows.Forms.CheckBox();
			this.PCheck = new System.Windows.Forms.CheckBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.discordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// InputsBox
			// 
			this.InputsBox.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InputsBox.FormattingEnabled = true;
			this.InputsBox.ItemHeight = 12;
			this.InputsBox.Location = new System.Drawing.Point(12, 28);
			this.InputsBox.Name = "InputsBox";
			this.InputsBox.Size = new System.Drawing.Size(241, 412);
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
			this.groupBox1.Location = new System.Drawing.Point(259, 28);
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
			this.groupBox2.Location = new System.Drawing.Point(332, 28);
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
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.PlusCheck);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.MinusCheck);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.SemiCheck);
			this.groupBox3.Controls.Add(this.SCheck);
			this.groupBox3.Controls.Add(this.PCheck);
			this.groupBox3.Location = new System.Drawing.Point(259, 93);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(114, 59);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Misc";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(92, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(13, 13);
			this.label8.TabIndex = 11;
			this.label8.Text = "+";
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
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(71, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(10, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "-";
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(49, 38);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = ";";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(14, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "S";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(14, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "P";
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
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
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
            this.saveToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
			this.toolStripDropDownButton1.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.newToolStripMenuItem.Text = "New";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.importToolStripMenuItem.Text = "Import";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.documentationToolStripMenuItem,
            this.githubToolStripMenuItem,
            this.discordToolStripMenuItem});
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(45, 22);
			this.toolStripDropDownButton2.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// githubToolStripMenuItem
			// 
			this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
			this.githubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.githubToolStripMenuItem.Text = "Github";
			// 
			// discordToolStripMenuItem
			// 
			this.discordToolStripMenuItem.Name = "discordToolStripMenuItem";
			this.discordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.discordToolStripMenuItem.Text = "Discord";
			// 
			// documentationToolStripMenuItem
			// 
			this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
			this.documentationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.documentationToolStripMenuItem.Text = "Documentation";
			// 
			// TAS63Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.InputsBox);
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
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.CheckBox PlusCheck;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox MinusCheck;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
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
	}
}

