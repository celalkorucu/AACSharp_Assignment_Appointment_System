using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AACSharp_Assignment_Appointment_System.Model
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public required string DoctorName { get; set; }

        public required string DoctorSurname { get; set; }

        public int BranchID { get; set;}

    }
}
