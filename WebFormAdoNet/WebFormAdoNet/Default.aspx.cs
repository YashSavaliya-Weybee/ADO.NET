using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SqlConnection conn = null;
        try
        {
            conn = new SqlConnection("Data source=DESKTOP-V3CMJBF;initial catalog=Student;integrated security=true");
            string query = "INSERT INTO STUDENT(ID,NAME,EMAIL,JOIN_DATE)VALUES('" + txtID.Text + "', '" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtJoinDate.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            int status = cmd.ExecuteNonQuery();

            lblMessage.Text = "Your record has been saved with the following details!";

            SqlCommand cm = new SqlCommand("SELECT TOP 1 * FROM STUDENT ORDER BY ID DESC", conn);
            SqlDataReader sdr = cm.ExecuteReader();
            sdr.Read();
            lblIDLeft.Text = "ID";
            lblIDRight.Text = sdr["ID"].ToString();

            lblNameLeft.Text = "Name";
            lblNameRight.Text = sdr["Name"].ToString();

            lblEmailLeft.Text = "Email";
            lblEmailRight.Text = sdr["Email"].ToString();

            lblJoinDateLeft.Text = "Join Date";
            lblJoinDateRight.Text = sdr["Join_Date"].ToString();
            sdr.Close();
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
        finally
        {
            conn.Close();
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        SqlConnection conn = null;
        try
        {
            conn = new SqlConnection("Data source=DESKTOP-V3CMJBF;initial catalog=Student;integrated security=true");
            conn.Open();
            lblMessage.Text = "Your record has been Deleted which has following details!";

            SqlCommand cm = new SqlCommand("SELECT * FROM STUDENT WHERE ID=" + txtIDToDelete.Text, conn);
            SqlDataReader sdr = cm.ExecuteReader();
            sdr.Read();
            lblIDLeft.Text = "ID";
            lblIDRight.Text = sdr["ID"].ToString();

            lblNameLeft.Text = "Name";
            lblNameRight.Text = sdr["Name"].ToString();

            lblEmailLeft.Text = "Email";
            lblEmailRight.Text = sdr["Email"].ToString();

            lblJoinDateLeft.Text = "Join Date";
            lblJoinDateRight.Text = sdr["Join_Date"].ToString();
            sdr.Close();
            SqlCommand cmd = new SqlCommand("DELETE FROM STUDENT WHERE ID=" + txtIDToDelete.Text, conn);

            int Status = cmd.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        SqlConnection conn = null;
        try
        {
            conn = new SqlConnection("Data source=DESKTOP-V3CMJBF;initial catalog=Student;integrated security=true");
            conn.Open();
            string query = "UPDATE STUDENT SET ID=" + txtID.Text + ",NAME='" + txtName.Text + "',EMAIL='" + txtEmail.Text + "',JOIN_DATE='" + txtJoinDate.Text + "' WHERE ID=" + txtIDToDelete.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            int status = cmd.ExecuteNonQuery();

            lblMessage.Text = "Your record has been updated with the following details!";

            SqlCommand cm = new SqlCommand("SELECT * FROM STUDENT WHERE ID=" + txtIDToDelete.Text, conn);
            SqlDataReader sdr = cm.ExecuteReader();
            sdr.Read();
            lblIDLeft.Text = "ID";
            lblIDRight.Text = sdr["ID"].ToString();

            lblNameLeft.Text = "Name";
            lblNameRight.Text = sdr["Name"].ToString();

            lblEmailLeft.Text = "Email";
            lblEmailRight.Text = sdr["Email"].ToString();

            lblJoinDateLeft.Text = "Join Date";
            lblJoinDateRight.Text = sdr["Join_Date"].ToString();
            sdr.Close();
        }
        catch (Exception ex)
        {
            Response.Write(ex + "<br><br>" + ex.InnerException);
        }
        finally
        {
            conn.Close();
        }
    }

    protected void btnUpdateID_Click(object sender, EventArgs e)
    {
        SqlConnection conn = null;
        try
        {
            conn = new SqlConnection("Data source=DESKTOP-V3CMJBF;initial catalog=Student;integrated security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT WHERE ID=" + txtIDToDelete.Text, conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            txtID.Text = sdr["ID"].ToString();
            txtName.Text = sdr["Name"].ToString();
            txtEmail.Text = sdr["Email"].ToString();
            txtJoinDate.Text = Convert.ToDateTime(sdr["Join_Date"]).ToString("yyyy-MM-dd");
            sdr.Close();
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
        finally
        {
            conn.Close();
        }
    }

    //protected void datePickerDateChanged(object sender, EventArgs e)
    //{
    //    txtJoinDate.Text = datePicker.SelectedDate.ToString("yyyy-MM-dd");
    //    datePicker.Visible = false;
    //}

    //protected void pickJoningDate(object sender, EventArgs e)
    //{
    //    datePicker.Visible = true;
    //}
}