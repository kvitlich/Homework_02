using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectedLevel
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    static public DbAccess DbAccess;
    static public string LastDbName;
    static public string LastServerName;

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        DbAccess = new DbAccess(LastDbName, LastServerName);
        textBox3.Text = $"Connected! To {LastDbName}";
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        textBox3.Text = $"Exception!";
      }
     
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
      LastDbName = textBox2.Text;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      LastDbName = textBox1.Text;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        DbAccess.Dispose();
        textBox3.Text = "Disconected!";
      }
      catch (Exception ex)
      {
        textBox3.Text = $"Exception!";
        Console.WriteLine(ex);
      }
      textBox3.Update();
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
      textBox3.Text = "";
      textBox3.Update();

    }
  }
}
