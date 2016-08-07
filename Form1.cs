// Decompiled with JetBrains decompiler
// Type: States.Form1
// Assembly: States, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5C74381C-CBF5-4AC0-8AA2-5CE9B24B8599
// Assembly location: C:\Users\ltrya\Documents\GitHub\States.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace States
{
  public class Form1 : Form
  {
    private IContainer components;
    private Button button1;
    private Button button2;
    private Label label1;

    public Form1()
    {
      this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int num = (int) new Form2().ShowDialog((IWin32Window) this);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      int num = (int) new Form3().ShowDialog((IWin32Window) this);
    }

    private void Form2_FormClosed(object sender, FormClosedEventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.button1 = new Button();
      this.button2 = new Button();
      this.label1 = new Label();
      this.SuspendLayout();
      this.button1.Location = new Point(12, 34);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "States";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(93, 34);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "Capitols";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(154, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Which would you like to study?";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(179, 68);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "States Quiz";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
