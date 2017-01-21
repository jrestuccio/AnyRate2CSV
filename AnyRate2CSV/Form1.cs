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
using System.Configuration;

namespace AnyRate2CSV
{
  public partial class AnyRate2CSV : Form
  {

    SqlDataAdapter sda;
    SqlCommandBuilder sb;
    DataTable dt;    

    public AnyRate2CSV()
    {
      InitializeComponent();
    }
    
    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void AnyRate2CSV_Load(object sender, EventArgs e)
    {

    }

    private void groupBox3_Enter(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click_1(object sender, EventArgs e)
    {

    }

    private void button7_Click(object sender, EventArgs e)
    {

    }

    private void txtPYRCreateQSpreeNum_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

      var connectionString = ConfigurationManager.ConnectionStrings["AnyRate2CSV.Properties.Settings.ARETHA"].ConnectionString;
      SqlConnection con = new SqlConnection(connectionString);
      var spreeNumber = txtPYRCreateQSpreeNum.Text;
      var daysBack = numUpDnPYRCreateQDaysBack.Value;
      var retries = txtPYRCreateQRetries.Text;
      var freshFactor = txtPYRCreateQFreshFactor.Text;

      try
      {                      
        string usp_PYRCreateQueue = string.Format("usp_PYRCreateQueue {0}, {1}, {2}, {3} ", spreeNumber, daysBack, retries, freshFactor);        

        SqlCommand command = new SqlCommand(usp_PYRCreateQueue, con);
        command.Connection.Open();
        command.ExecuteNonQuery();        
      }
      catch (SqlException ex) { txtStatusWindow.AppendText("Error:\n\n\n" + ex); }
      finally
      {
        con.Close();
        txtStatusWindow.AppendText(string.Format("Spree {0} has been started.....\n", spreeNumber));
      }

    }

    private void btnClearV2Queue_Click(object sender, EventArgs e)
    {
      var connectionString = ConfigurationManager.ConnectionStrings["AnyRate2CSV.Properties.Settings.ARETHA"].ConnectionString;
      
      SqlConnection con = new SqlConnection(connectionString);
      con.Open();

      try
      {
        SqlCommand command = new SqlCommand("DELETE TFX_V2_Queue;", con);
        command.Connection.Open();
        command.ExecuteNonQuery();        
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        con.Close();
        txtStatusWindow.AppendText("TFX_V2_QUEUE cleared. \n");
      }

      
    }

  }
}
