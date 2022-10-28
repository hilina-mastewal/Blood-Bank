using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank
{
    public class Receptionist
    {
        public string empId, userName, password, firstName, lastName, phoneNumber, address;
        public int fkBloodBank;

        public DataTable signIn()
        {
            DbReceptionist dr = new DbReceptionist();
            return  dr.signIn(this);
         
        }

        public void signUp()
        {
            DbReceptionist dr = new DbReceptionist();
            dr.signUp(this);
        }
    }
}
