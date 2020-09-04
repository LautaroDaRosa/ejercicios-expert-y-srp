namespace Crc_appointment
{
    public class AppointmentService
    {
        public string name;

        public string id;

        public string phoneNumber;

        public string date;

        public string appointmentPlace;

        public string doctorName;

        public AppointmentService(string name, string id, string phoneNumber, string date, string appointmentPlace, string doctorName)
        {
            this.name=name;

            this.id=id;

            this.phoneNumber=phoneNumber;

            this.date=date;

            this.appointmentPlace=appointmentPlace;

            this.doctorName=doctorName;
        }
    }
}

       