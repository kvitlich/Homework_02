﻿namespace ConnectedLevel
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
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(349, 22);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(110, 34);
      this.button1.TabIndex = 0;
      this.button1.Text = "Connect";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 12);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(312, 26);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "Enter name of server...";
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(12, 44);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(312, 22);
      this.textBox2.TabIndex = 2;
      this.textBox2.Text = "Enter name of Data Base...";
      this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(349, 96);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(110, 34);
      this.button2.TabIndex = 3;
      this.button2.Text = "Disconnect";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // textBox3
      // 
      this.textBox3.Enabled = false;
      this.textBox3.Location = new System.Drawing.Point(12, 96);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(312, 34);
      this.textBox3.TabIndex = 4;
      this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(483, 142);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Connect";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox textBox3;
  }
}

