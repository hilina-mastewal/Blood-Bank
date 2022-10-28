using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Blood_Bank
{
   public class DbOrdor
    {
        public string con = "server = KALAB\\SSQLSERVER; database = project2; Integrated Security = True";

        public DataTable getOrder(string text)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("select_order", conn);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@word", text);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        return dt;
                    }
                }
            }
            catch (SqlException E)
            {
                MessageBox.Show(E.Message);
                return null;
            }
        }

        public int updateOrder(Orders or)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update_orders", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", or.id);
                    cmd.Parameters.AddWithValue("@bloodtype",or.bloodType);
                    cmd.Parameters.AddWithValue("@qty", or.qty);
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

        public int deleteOrder(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("delete_order", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@o_id", id);

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
