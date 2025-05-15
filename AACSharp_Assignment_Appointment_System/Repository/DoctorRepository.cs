using AACSharp_Assignment_Appointment_System.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Appointment_System.Repository
{
    public class DoctorRepository
    {

        private DatabaseManager _db;

        public DoctorRepository(DatabaseManager db)
        {
            _db = db;
        }

        public Doctor? GetDoctorsByBranchId(int branchId)
        {
            string query = $"SELECT * FROM Doctors WHERE branch_id = {branchId}";
            DataTable dt = _db.ExecuteSelect(query);


            foreach (DataRow row in dt.Rows)
            {
                Doctor doctor = new Doctor
                {
                    DoctorID = Convert.ToInt32(row["id"]),
                    DoctorName = (string) row["name"],
                    DoctorSurname = (string) row["surname"],
                    BranchID = Convert.ToInt32(row["branch_id"])
                };

                return doctor;
            }

            return null;

        }
    }
}
