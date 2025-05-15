using AACSharp_Assignment_Appointment_System.Model;
using AACSharp_Assignment_Appointment_System.Repository;

namespace AACSharp_Assignment_Appointment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Branch? selectedBranch;
        Doctor? selectedDoctor;
        string? selectedHour;
        DateTime selectedDate;
        private void Form1_Load(object sender, EventArgs e)
        {

            DatabaseManager databaseManager = new DatabaseManager();

            if (databaseManager.TestConnection())
            {

                selectedDate = date_time_apoointment.Value;

                // Repository �zerinden t�m branch'leri al
                BranchRepository repo = new BranchRepository(databaseManager);

                List<Branch> branches = repo.GetAllBranches();

                // �rnek: ComboBox'a yaz
                cb_branchs.DataSource = branches;
                cb_branchs.DisplayMember = "BranchName";   // Branch modelindeki Name property�si
                cb_branchs.ValueMember = "BranchID";       // Id de�erini tutar


                initializeTimes();
            }
            else
            {
                MessageBox.Show("Veritaban�na ba�lant� kurulamad�.");
            }
        }


        private void text_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_appointment_Click(object sender, EventArgs e)
        {

            DatabaseManager dbManager = new DatabaseManager();
            AppointmentRepository appointmentRepository = new AppointmentRepository(dbManager);

            string patientName = text__patient_name.Text;
            string patientSurname = text_patient_surname.Text;

            int doctorID = selectedDoctor!.DoctorID;
            int branchID = selectedBranch!.BranchID;

            DateTime fullDateTime = DateTime.Parse($"{date_time_apoointment.Value.Date:yyyy-MM-dd} {selectedHour}");

            bool control =appointmentRepository.AddAppointment(patientName, patientSurname, doctorID, branchID, fullDateTime);
        
            if(control)
            {
                MessageBox.Show("Randevu ba�ar�l� bir �ekilde kaydedildi");
                initializeTimes();
            }
            else
            {
                MessageBox.Show("Randevu kaydedilemedi");

            }
        }

        private void cb_branchs_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBranch = cb_branchs.SelectedItem as Branch;

            if (selectedBranch != null)
            {
                int id = selectedBranch.BranchID;
                string name = selectedBranch.BranchName;


                // Doktorlar� veritaban�ndan �ek
                DoctorRepository doctorRepo = new DoctorRepository(new DatabaseManager());
                selectedDoctor = doctorRepo.GetDoctorsByBranchId(id);

                if (selectedDoctor != null)
                {
                    // �rnek: doktorlar� ba�ka bir ComboBox'a yazmak
                    lbl_selected_doctor.Text = "Se�ilen Doktor : " + selectedDoctor.DoctorName + " " + selectedDoctor.DoctorSurname;
                }

                initializeTimes();
            }
        }

        private void date_time_apoointment_ValueChanged(object sender, EventArgs e)
        {

            selectedDate = date_time_apoointment.Value;
            initializeTimes();
         
        }

        private void initializeTimes()
        {
            if(selectedDoctor != null)
            {
                // Dolu saatleri �ek
                var appointmentRepo = new AppointmentRepository(new DatabaseManager());
                List<string> occupiedHours = appointmentRepo.GetOccupiedHoursByDoctor(selectedDate, selectedDoctor.DoctorID);

                List<string> allHours = new List<string> { "09:00", "10:00", "11:00", "12:00", "14:00", "15:00", "16:00", "17:00" };

                cb_time_apoointment.Items.Clear();

                foreach (var hour in allHours)
                {
                    if (!occupiedHours.Contains(hour))
                        cb_time_apoointment.Items.Add(hour);
                }


                if (cb_time_apoointment.Items.Count > 0)
                    cb_time_apoointment.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Doktor se�ili de�il");
            }
        }

        private void cb_time_apoointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedHour = cb_time_apoointment.SelectedItem as string;
        }
    }
}
