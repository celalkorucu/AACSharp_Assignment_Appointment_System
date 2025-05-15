namespace AACSharp_Assignment_Appointment_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cb_branchs = new ComboBox();
            lbl_selected_doctor = new Label();
            date_time_apoointment = new DateTimePicker();
            cb_time_apoointment = new ComboBox();
            text__patient_name = new TextBox();
            text_patient_surname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_create_appointment = new Button();
            SuspendLayout();
            // 
            // cb_branchs
            // 
            cb_branchs.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cb_branchs.FormattingEnabled = true;
            cb_branchs.Items.AddRange(new object[] { "Bölüm Seçiniz " });
            cb_branchs.Location = new Point(91, 192);
            cb_branchs.Name = "cb_branchs";
            cb_branchs.Size = new Size(327, 29);
            cb_branchs.TabIndex = 0;
            cb_branchs.SelectedIndexChanged += cb_branchs_SelectedIndexChanged;
            // 
            // lbl_selected_doctor
            // 
            lbl_selected_doctor.AutoSize = true;
            lbl_selected_doctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_selected_doctor.Location = new Point(108, 240);
            lbl_selected_doctor.Name = "lbl_selected_doctor";
            lbl_selected_doctor.Size = new Size(134, 21);
            lbl_selected_doctor.TabIndex = 1;
            lbl_selected_doctor.Text = "Seçilen Doktor : ";
            // 
            // date_time_apoointment
            // 
            date_time_apoointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            date_time_apoointment.Location = new Point(91, 307);
            date_time_apoointment.Name = "date_time_apoointment";
            date_time_apoointment.Size = new Size(327, 29);
            date_time_apoointment.TabIndex = 2;
            date_time_apoointment.ValueChanged += date_time_apoointment_ValueChanged;
            // 
            // cb_time_apoointment
            // 
            cb_time_apoointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cb_time_apoointment.FormattingEnabled = true;
            cb_time_apoointment.Location = new Point(91, 380);
            cb_time_apoointment.Name = "cb_time_apoointment";
            cb_time_apoointment.Size = new Size(327, 29);
            cb_time_apoointment.TabIndex = 3;
            cb_time_apoointment.SelectedIndexChanged += cb_time_apoointment_SelectedIndexChanged;
            // 
            // text__patient_name
            // 
            text__patient_name.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            text__patient_name.Location = new Point(218, 45);
            text__patient_name.Name = "text__patient_name";
            text__patient_name.Size = new Size(200, 29);
            text__patient_name.TabIndex = 4;
            text__patient_name.TextChanged += text_name_TextChanged;
            // 
            // text_patient_surname
            // 
            text_patient_surname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            text_patient_surname.Location = new Point(218, 91);
            text_patient_surname.Name = "text_patient_surname";
            text_patient_surname.Size = new Size(200, 29);
            text_patient_surname.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(91, 48);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 6;
            label1.Text = "Adınız : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(91, 94);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 7;
            label2.Text = "Soyadınız : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(91, 279);
            label3.Name = "label3";
            label3.Size = new Size(227, 21);
            label3.TabIndex = 8;
            label3.Text = "Lütfen randevu tarihi seçiniz";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(91, 164);
            label4.Name = "label4";
            label4.Size = new Size(336, 21);
            label4.TabIndex = 9;
            label4.Text = "Randevu almak istediğiniz bölümü seçiniz ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(91, 352);
            label5.Name = "label5";
            label5.Size = new Size(237, 21);
            label5.TabIndex = 10;
            label5.Text = "Lütfen randevu saatini seçiniz";
            // 
            // btn_create_appointment
            // 
            btn_create_appointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_create_appointment.Location = new Point(526, 371);
            btn_create_appointment.Name = "btn_create_appointment";
            btn_create_appointment.Size = new Size(188, 44);
            btn_create_appointment.TabIndex = 11;
            btn_create_appointment.Text = "Randevu oluştur";
            btn_create_appointment.UseVisualStyleBackColor = true;
            btn_create_appointment.Click += btn_create_appointment_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_create_appointment);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_patient_surname);
            Controls.Add(text__patient_name);
            Controls.Add(cb_time_apoointment);
            Controls.Add(date_time_apoointment);
            Controls.Add(lbl_selected_doctor);
            Controls.Add(cb_branchs);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_branchs;
        private Label lbl_selected_doctor;
        private DateTimePicker date_time_apoointment;
        private ComboBox cb_time_apoointment;
        private TextBox text__patient_name;
        private TextBox text_patient_surname;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_create_appointment;
    }
}
