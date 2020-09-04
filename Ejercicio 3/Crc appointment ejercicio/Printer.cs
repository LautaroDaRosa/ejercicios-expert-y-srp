using System;

namespace Crc_appointment
{
    public class Printer
    {
        public void PrintTicket(AppointmentService appointment)
        {
            Boolean isValid = true;
            Console.WriteLine("Scheduling appointment...\n");
            if(string.IsNullOrEmpty(appointment.name))
            {
                Console.WriteLine("Unable to schedule appointment, Name is required\n");
            }
            
            if (string.IsNullOrEmpty(appointment.id))
            {
                Console.WriteLine("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointment.phoneNumber))
            {
                Console.WriteLine("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appointment.appointmentPlace))
            {
                Console.WriteLine("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(appointment.doctorName))
            {
                Console.WriteLine("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            } 
            if (isValid)
            {
                Console.WriteLine("Appoinment Scheduled");
            }

        } 
    }
}