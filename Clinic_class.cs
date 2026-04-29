using System.Linq;

class Clinic
{
    private List<Doctor> _doctors;
    private List<Appointment> _appointments;

    public Clinic()
    {
        _doctors = new List<Doctor>();
        _appointments = new List<Appointment>();

        Doctor doctor1 = new Doctor(1, "Доктор Сергей", "Стоматолог");
        Doctor doctor2 = new Doctor(2, "Доктор Анна", "Хирург");

        _doctors.Add(doctor1);
        _doctors.Add(doctor2);

        _appointments.Add(new Appointment(1, doctor1, "29.04.2026 12:00", false));
        _appointments.Add(new Appointment(2, doctor2, "29.04.2026 13:00", false));

    }

    public void ShowAvailableAppointments()
    {
        foreach (var appointment in _appointments)
        {
            if (appointment.IsBooked == false) Console.WriteLine($"{appointment.Doctor.Name}, свободен в {appointment.Date}");
        }
        
    }

    public void BookAppointment(int appointmentId)
    {
        foreach (var appointment in _appointments)
        {
            if (appointment.ID == appointmentId)
            {
                if (appointment.IsBooked == false)
                {
                    appointment.IsBooked = true;
                    Console.WriteLine("Успешная запись");
                    return;
                }
                else 
                {
                    Console.WriteLine("Запись уже занята");
                    return;
                }
            }
        }

        Console.WriteLine("Нет такой записи");
    }

    public void CancelAppointment(int appointmentId)
    {
        var appointment = _appointments.FirstOrDefault(a => a.ID == appointmentId);

        if (appointment == null)
        {
            Console.WriteLine("Такой записи не существует.");
            return;
        }
        if (appointment.IsBooked == false)
        {
            Console.WriteLine("Это окно уже свободно");
            return;
        }

        appointment.IsBooked = false;
        Console.WriteLine($"Запись {appointmentId} отменена");
    }

    
}