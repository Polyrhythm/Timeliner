﻿namespace TimeLinerSA
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
            
            foreach (var t in FWAMPTimeliners)
            	t.Dispose();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.webBrowser1 = new System.Windows.Forms.WebBrowser();
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.panel1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// textBox1
        	// 
        	this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.textBox1.Location = new System.Drawing.Point(0, 475);
        	this.textBox1.Multiline = true;
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(1009, 124);
        	this.textBox1.TabIndex = 2;
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.webBrowser1);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel1.Location = new System.Drawing.Point(0, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(1009, 475);
        	this.panel1.TabIndex = 3;
        	// 
        	// webBrowser1
        	// 
        	this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.webBrowser1.Location = new System.Drawing.Point(0, 0);
        	this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
        	this.webBrowser1.Name = "webBrowser1";
        	this.webBrowser1.ScriptErrorsSuppressed = true;
        	this.webBrowser1.Size = new System.Drawing.Size(1009, 475);
        	this.webBrowser1.TabIndex = 0;
        	// 
        	// timer1
        	// 
        	this.timer1.Interval = 1;
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(1009, 599);
        	this.Controls.Add(this.panel1);
        	this.Controls.Add(this.textBox1);
        	this.Name = "Form1";
        	this.Text = "Form1";
        	this.panel1.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.TextBox textBox1;
    }
}
