using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AnyRate2CSV
{
  public partial class Login : Form
  {
    public Login()
    {
      InitializeComponent();
      txtPassword.KeyDown += (sender, args) =>
      {
        if (args.KeyCode == Keys.Return)
        {
          btnLogin.PerformClick();
        }
      };
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      var username = txtUserName.Text;
      var password = txtPassword.Text;

      String connectionAttempt = string.Format("Data Source=216.37.67.51\\ARETHA;Persist Security Info=True;User ID={0}; Password={1}; Initial Catalog=trendfxrates", username,password);
      SqlConnection conn = new SqlConnection(connectionAttempt);

      try
      {
        conn.Open();
        this.Hide();        
        new AnyRate2CSV().ShowDialog();
      }
      catch (SqlException ex) { MessageBox.Show("Invalid Login"); }            
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {

    }
  }
}
