using System;
using System.Globalization;

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
        return string.Format("You have an appointment on {0}.", appointmentDate.ToString("G",
            CultureInfo.CreateSpecificCulture("en-US")));
    }

    public static DateTime AnniversaryDate()
    {
        string day = "09/15/2021 00:00:00";
        
        return DateTime.Parse(day);
    }
}
