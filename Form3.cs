// Decompiled with JetBrains decompiler
// Type: States.Form3
// Assembly: States, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5C74381C-CBF5-4AC0-8AA2-5CE9B24B8599
// Assembly location: C:\Users\ltrya\Documents\GitHub\States.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace States
{
  public class Form3 : Form
  {
    public string[] statenames = new string[50]
    {
      "Alabama",
      "Alaska",
      "Arizona",
      "Arkansas",
      "California",
      "Colorado",
      "Commecticut",
      "Delaware",
      "Florida",
      "Georgia",
      "Hawaii",
      "Idaho",
      "Illinos",
      "Indiana",
      "Iowa",
      "Kansas",
      "Kentucky",
      "Louisiana",
      "Maine",
      "Maryland",
      "Massachusetts",
      "Michigan",
      "Minnesota",
      "Mississipi",
      "Missouri",
      "Montana",
      "Nebraska",
      "Nevada",
      "New Hampshire",
      "New Jersey",
      "New Mexico",
      "New York",
      "North Carolina",
      "North Dakota",
      "Ohio",
      "Oklahoma",
      "Oregon",
      "Pennsylvania",
      "Rhode Island",
      "South Carolina",
      "South Dakota",
      "Tennessee",
      "Texas",
      "Utah",
      "Vermont",
      "Virginia",
      "Washington",
      "West Virginia",
      "Wisconsin",
      "Wyoming"
    };
    public string[] capitolnames = new string[50]
    {
      "Montgomery",
      "Juneau",
      "Phoenix",
      "Little Rock",
      "Sacramento",
      "Denver",
      "Hartford",
      "Dover",
      "Tallahassee",
      "Atlanta",
      "Honolulu",
      "Boise",
      "Springfield",
      "Indianapolis",
      "Des Moines",
      "Topeka",
      "Frankfort",
      "Botan Rouge",
      "Augusta",
      "Annapolis",
      "Boston",
      "Lancing",
      "Saint Paul",
      "Jackson",
      "Jefferson City",
      "Helena",
      "Lincoln",
      "Carson City",
      "Concord",
      "Trenton",
      "Santa Fe",
      "Albany",
      "Raleigh",
      "Bismarck",
      "Columbus",
      "Oklahoma City",
      "Salem",
      "Harrisburg",
      "Providence",
      "Columbia",
      "Pierre",
      "Nashville",
      "Austin",
      "Salt Lake City",
      "Montpelier",
      "Richmond",
      "Olympia",
      "Charleston",
      "Madison",
      "Cheyenne"
    };
    public int[] usednames = new int[55];
    private student s = new student();
    private Count c = new Count();
    private IContainer components;
    private Button button3;
    private Button button4;
    private Label label1;
    private TextBox textBox1;
    private Button button2;
    private Button button1;

    public Form3()
    {
      this.InitializeComponent();
    }

    public void reset()
    {
      this.c.counting = 0;
      this.restate();
    }

    private void restate()
    {
      this.rndstate();
      this.label1.Text = this.statenames[this.s.number] + " is the capitol of?";
      this.textBox1.Text = "";
    }

    public void rndstate()
    {
      this.s.number = new Random().Next(0, 49);
      if (this.usednames[this.s.number] == 0)
      {
        this.usednames[this.s.number] = 1;
      }
      else
      {
        if (this.usednames[this.s.number] != 1)
          return;
        this.rndstate();
      }
    }

    public void skip()
    {
      this.s.number = new Random().Next(0, 49);
      if (this.usednames[this.s.number] == 0)
      {
        this.label1.Text = this.statenames[this.s.number] + " is the capitol of?";
        this.textBox1.Text = "";
      }
      else
      {
        if (this.usednames[this.s.number] != 1)
          return;
        this.skip();
      }
    }

    public void check(string checking)
    {
      if (checking == "")
      {
        int num1 = (int) MessageBox.Show("No Answer Given", "State Quiz");
      }
      else
      {
        if (!(checking != ""))
          return;
        if (checking == this.capitolnames[this.s.number])
        {
          int num2 = (int) MessageBox.Show("Correct", "State Quiz");
          this.restate();
          this.count();
        }
        else
        {
          if (!(checking != this.capitolnames[this.s.number]))
            return;
          int num2 = (int) MessageBox.Show("That is Incorrect", "State Quiz");
        }
      }
    }

    public void count()
    {
      ++this.c.counting;
      if (this.c.counting != 50)
        return;
      int num = (int) MessageBox.Show("You Have Answered Everything Correctly!", "State Quiz");
      this.quit();
    }

    public void quit()
    {
      if (this.c.counting == 50)
      {
        this.reset();
        this.Close();
      }
      else if (MessageBox.Show("Would you like to quit?", "State Quiz", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        this.reset();
        this.Close();
      }
    }

    public void givingup()
    {
      int num = (int) MessageBox.Show("You got " + this.c.counting.ToString() + " out of 50", "State Quiz");
      switch (MessageBox.Show("Would you like to try again?", "State Quiz", MessageBoxButtons.YesNo))
      {
        case DialogResult.Yes:
          this.reset();
          break;
        case DialogResult.No:
          this.Close();
          break;
      }
    }

    private void Form3_Load(object sender, EventArgs e)
    {
      this.restate();
      this.reset();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.check(this.textBox1.Text);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.skip();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Are you Sure you want to give up?", "State Quiz", MessageBoxButtons.YesNo) == DialogResult.Yes)
        this.givingup();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.quit();
    }

    private void Form3_FormClosing(object sender, FormClosingEventArgs e)
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
      this.button3 = new Button();
      this.button4 = new Button();
      this.label1 = new Label();
      this.textBox1 = new TextBox();
      this.button2 = new Button();
      this.button1 = new Button();
      this.SuspendLayout();
      this.button3.Location = new Point(83, 80);
      this.button3.Name = "button3";
      this.button3.Size = new Size(66, 23);
      this.button3.TabIndex = 11;
      this.button3.Text = "Quit";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.Location = new Point(12, 80);
      this.button4.Name = "button4";
      this.button4.Size = new Size(65, 23);
      this.button4.TabIndex = 10;
      this.button4.Text = "Give Up";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(9, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(35, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "label1";
      this.textBox1.Location = new Point(12, 25);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(137, 20);
      this.textBox1.TabIndex = 8;
      this.button2.Location = new Point(83, 51);
      this.button2.Name = "button2";
      this.button2.Size = new Size(66, 23);
      this.button2.TabIndex = 7;
      this.button2.Text = "Guess";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button1.Location = new Point(12, 51);
      this.button1.Name = "button1";
      this.button1.Size = new Size(65, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "Skip";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(166, 114);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form3";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Capitals Quiz";
      this.Load += new EventHandler(this.Form3_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
