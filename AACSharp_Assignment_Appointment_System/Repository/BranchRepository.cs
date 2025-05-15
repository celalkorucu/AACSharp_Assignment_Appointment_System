using AACSharp_Assignment_Appointment_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Appointment_System.Repository
{
    public class BranchRepository
    {

        private DatabaseManager _db;

        public BranchRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<Branch> GetAllBranches()
        {
            string query = "SELECT * FROM Branchs";
            DataTable dt = _db.ExecuteSelect(query);

            List<Branch> branches = new List<Branch>();

            foreach (DataRow row in dt.Rows)
            {
                Branch branch = new Branch
                {
                    BranchID = Convert.ToInt32(row["id"]),
                    BranchName = (string) row["name"],
                };

                branches.Add(branch);
            }

            return branches;
        }
    }
}
