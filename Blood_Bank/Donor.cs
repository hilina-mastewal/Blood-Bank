using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank
{
    public class Donor
    {
        public string firstName, lastName,  phoneNumber, address, fkBloodId;
        public decimal qty;
        public char gender;
        public int age, fkReceptionistId, donorId;

        public int saveDonor()
        {
            DbDonor dd = new DbDonor();
           return dd.insertDonor(this);
        }

        public DataTable getDonor(string text)
        {
                var db1 = new DbDonor();
                DataTable dt = db1.getDonor(text);
                return dt;
        }

        public int updateDonor()
        {
            DbDonor db = new DbDonor();
            return  db.updateDonor(this);
        }
        public int deleteDonor()
        {
            DbDonor db = new DbDonor();
            return db.deleteDonor(this.donorId);
        }



    }
}
