using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank
{
   public class DbDonor
    {
        public string con = "server = KALAB\\SSQLSERVER; database = project2; Integrated Security = True";
        public int insertDonor(Donor don)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert_donor", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@f_name", don.firstName);
                    cmd.Parameters.AddWithValue("@l_name", don.lastName);
                    cmd.Parameters.AddWithValue("@age", don.age);
                    cmd.Parameters.AddWithValue("@gender", don.gender);
                    cmd.Parameters.AddWithValue("@phno", don.phoneNumber);
                    cmd.Parameters.AddWithValue("@address", don.address);
                    cmd.Parameters.AddWithValue("@qty", don.qty);
                    cmd.Parameters.AddWithValue("@fk_b", don.fkBloodId);
                    cmd.Parameters.AddWithValue("@fk_r", don.fkReceptionistId);

                    int row = cmd.ExecuteNonQuery();
                    conn.Close();
                    return row;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

       
        public DataTable getDonor(string text)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("select_by_name", conn);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@name", text);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        

                        return dt;
                    }
                }
            }
           catch(SqlException E)
            {
                MessageBox.Show(E.Message);
                return null;
            }

        }

        public int updateDonor(Donor don)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update_donor", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", don.donorId);
                    cmd.Parameters.AddWithValue("@fname", don.firstName);
                    cmd.Parameters.AddWithValue("@lname", don.lastName);
                    cmd.Parameters.AddWithValue("@age", don.age);
                    cmd.Parameters.AddWithValue("@gender", don.gender);
                    cmd.Parameters.AddWithValue("@phno", don.phoneNumber);
                    cmd.Parameters.AddWithValue("@address", don.address);
                    cmd.Parameters.AddWithValue("@qty", don.qty);
                    cmd.Parameters.AddWithValue("@blood", don.fkBloodId);

                    int row = cmd.ExecuteNonQuery();
                    conn.Close();
                    return row;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public int deleteDonor(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete_donor", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@d_id", id);
                   
                    int row = cmd.ExecuteNonQuery();
                    conn.Close();
                    return row;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
