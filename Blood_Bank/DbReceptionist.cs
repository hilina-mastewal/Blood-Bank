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
    public class DbReceptionist
    {

        public string con = "server = KALAB\\SSQLSERVER; database = project2; Integrated Security = True";

        public DataTable signIn(Receptionist re)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spCompare", conn);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@userName", re.userName);
                        da.SelectCommand.Parameters.AddWithValue("@password", re.password);
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

        public void signUp(Receptionist re)
        {
                try
                {
                    using (SqlConnection conn = new SqlConnection(con))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("insert_receptionist", conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username",re.userName);
                        cmd.Parameters.AddWithValue("@password", re.password );
                        cmd.Parameters.AddWithValue("@f_name", re.firstName);
                        cmd.Parameters.AddWithValue("@l_name", re.lastName);
                        cmd.Parameters.AddWithValue("@phno", re.phoneNumber);
                        cmd.Parameters.AddWithValue("@address", re.address);
                        cmd.Parameters.AddWithValue("@fk_bb", re.fkBloodBank);



                    int row = cmd.ExecuteNonQuery();
                        conn.Close();
                        if (row > 0)
                            MessageBox.Show("succesfull created!");
                        else
                            MessageBox.Show("Not succesfull!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
    }
}
