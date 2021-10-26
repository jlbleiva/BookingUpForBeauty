using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return  DateTime.Parse(appointmentDateDescription);
        
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return (appointmentDate < DateTime.Now);
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18) return true;
        return false;
    }

    public static string Description(DateTime appointmentDate)
    {
        throw new NotImplementedException("Please implement the (static) Appointment.Description() method");
    }

    public static DateTime AnniversaryDate()
    {
        throw new NotImplementedException("Please implement the (static) Appointment.AnniversaryDate() method");
    }
}
