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
using System.IO;

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


    private int SQLToCSV(string query, string Filename)
    {

      SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AnyRate2CSV.Properties.Settings.ARETHA"].ConnectionString);
      conn.Open();
      SqlCommand cmd = new SqlCommand(query, conn);
      SqlDataReader dr = cmd.ExecuteReader();
      int rowsAffected = 0;      

      using (System.IO.StreamWriter fs = new System.IO.StreamWriter(Filename))
      {
        // Loop through the fields and add headers
        for (int i = 0; i < dr.FieldCount; i++)
        {
          string name = dr.GetName(i);
          if (name.Contains(","))
            name = "\"" + name + "\"";

          fs.Write(name + ",");
        }
        fs.WriteLine();

        // Loop through the rows and output the data
        while (dr.Read())
        {
          rowsAffected++;
          for (int i = 0; i < dr.FieldCount; i++)
          {
            string value = dr[i].ToString();
            if (value.Contains(","))
              value = "\"" + value + "\"";

            fs.Write(value + ",");
          }
          fs.WriteLine();
        }

        fs.Close();
      }
      return rowsAffected;
    }

    private static string QuoteValue(string value)
    {
      return String.Concat("\"",
      value.Replace("\"", "\"\""), "\"");
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
      DialogResult result = folderCSVOutput.ShowDialog();
      if (result == DialogResult.OK) // Test result.
      {
        string fileText = folderCSVOutput.SelectedPath.ToString();
        txtCSVOutputFile.Text = fileText;
      }
      Console.WriteLine(result); // <-- For debugging use.
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
      int rowsAffected = 0;

      // try to connect to the database and run the query to Create the Queue
      try
      {                      
        string usp_PYRCreateQueue = string.Format("usp_PYRCreateQueue {0}, {1}, {2}, {3} ", spreeNumber, daysBack, retries, freshFactor);        

        SqlCommand command = new SqlCommand(usp_PYRCreateQueue, con);
        command.Connection.Open();
        rowsAffected = command.ExecuteNonQuery();
      }
      catch (SqlException ex) { txtStatusWindow.AppendText("Error:\n\n\n" + ex); }
      finally
      {
        con.Close();
        txtStatusWindow.AppendText(string.Format("Spree {0} has been started.....\n", spreeNumber));
        txtStatusWindow.AppendText(rowsAffected + " searches added to the Queue.\n");
      }

    }

    private void btnClearV2Queue_Click(object sender, EventArgs e)
    {
      var connectionString = ConfigurationManager.ConnectionStrings["AnyRate2CSV.Properties.Settings.ARETHA"].ConnectionString;      
      SqlConnection con = new SqlConnection(connectionString);
      int rowsAffected = 0;

      try
      {
        SqlCommand command = new SqlCommand("DELETE TFX_V2_Queue;", con);
        command.Connection.Open();
        rowsAffected = command.ExecuteNonQuery();        
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        con.Close();
        txtStatusWindow.AppendText("TFX_V2_QUEUE cleared. \n");
        txtStatusWindow.AppendText(rowsAffected + " searches deleted from the Queue.\n");
      }

      
    }

    private void btnPYSnapQueue_Click(object sender, EventArgs e)
    {
      var connectionString = ConfigurationManager.ConnectionStrings["AnyRate2CSV.Properties.Settings.ARETHA"].ConnectionString;
      SqlConnection con = new SqlConnection(connectionString);
      int rowsAffected = 0;

      try
      {
        SqlCommand command = new SqlCommand("usp_PYR_SnapQueue;", con);
        command.Connection.Open();
        rowsAffected = command.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        con.Close();
        txtStatusWindow.AppendText("usp_PYR_SnapQueue completed. \n");
        txtStatusWindow.AppendText(rowsAffected + " searches inserted into TFX_V2_PYRSnapQueue.\n");
      }

    }

    private void btnStartExtractRates_Click(object sender, EventArgs e)
    {
      
      var LoginCode = txtExtractCSVLoginCode.Text;
      var DaysBack = numUpDnExtractCSVDaysBack.Value;
      var connectionString = ConfigurationManager.ConnectionStrings["AnyRate2CSV.Properties.Settings.ARETHA"].ConnectionString;
      var sqlQuery = string.Format("dbo.usp_PYRExtractRATES '{0}', {1}", LoginCode, DaysBack);
      int rowsAffected = 0;      
      var outputFolderPlusFileName = txtCSVOutputFile.Text + "\\" + txtFileNameFormat.Text;      

      try
      {
        rowsAffected = SQLToCSV(sqlQuery, outputFolderPlusFileName);        
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {        
        txtStatusWindow.AppendText(string.Format("Extract Complete for: {0}. \n",LoginCode));
        txtStatusWindow.AppendText(rowsAffected + " searches extracted to CSV.\n");
      }
    }

    private void radbtnPYRFormat_CheckedChanged(object sender, EventArgs e)
    {
      updatetxtFileNameFormat();
    }

    private void radbtnHSDSFormat_CheckedChanged(object sender, EventArgs e)
    {
      updatetxtFileNameFormat();
    }

    private void radbtnOtherFormat_CheckedChanged(object sender, EventArgs e)
    {
      updatetxtFileNameFormat();
    }

    private void txtExtractCSVLoginCode_TextChanged(object sender, EventArgs e)
    {
      updatetxtFileNameFormat();
    }

    private void updatetxtFileNameFormat()
    {
      var csvFileName = txtExtractCSVLoginCode.Text;
      var date = dateTimeExtractCSV.Value;
      
      if (radbtnPYRFormat.Checked)
      {
        var PYRFileNameFormat = string.Format("{0}{1:yyyyMMdd}.csv", csvFileName, date);
        txtFileNameFormat.Text = PYRFileNameFormat;
      }

      if (radbtnHSDSFormat.Checked)
      {
        var HSDSFileNameFormat = string.Format("HSDS{0}{1:yyyyMMdd}.csv", csvFileName, date);
        txtFileNameFormat.Text = HSDSFileNameFormat;
      }

      if (radbtnOtherFormat.Checked)
      {
        var otherFileNameFormat = string.Format("Other{0}{1:yyyyMMdd}.csv", csvFileName, date);
        txtFileNameFormat.Text = otherFileNameFormat;
      }
    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
      updatetxtFileNameFormat();
    }

    private void folderCSVOutput_HelpRequest(object sender, EventArgs e)
    {

    }

  }
}
