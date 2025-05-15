using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Appointment_System.Repository
{
    public class AppointmentRepository
    {
        private DatabaseManager _db;

        public AppointmentRepository(DatabaseManager db)
        {
            _db = db;
        }


        public List<string> GetOccupiedHoursByDoctor(DateTime selectedDate, int doctorId)
        {
            string query = $"SELECT CONVERT(varchar(5), date, 108) AS hour " +
                           $"FROM Appointments " +
                           $"WHERE CAST(date AS DATE) = '{selectedDate:yyyy-MM-dd}' " +
                           $"AND doctor_id = {doctorId}";

            DataTable dt = _db.ExecuteSelect(query);
            List<string> occupied = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                occupied.Add((string)row["hour"]);
            }

            return occupied;
        }

        public bool AddAppointment(string name, string surname, int doctorId, int branchId, DateTime date)
        {
            string query = "INSERT INTO Appointments (patient_name, patient_surname, doctor_id, branch_id, date) " +
                           "VALUES (@name, @surname, @doctorId, @branchId, @date)";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@name", name),
                new SqlParameter("@surname", surname),
                new SqlParameter("@doctorId", doctorId),
                new SqlParameter("@branchId", branchId),
                new SqlParameter("@date", date)
            };

            int affectedRows = _db.ExecuteNonQuery(query, parameters);
            return affectedRows > 0;
        }
    }
}
