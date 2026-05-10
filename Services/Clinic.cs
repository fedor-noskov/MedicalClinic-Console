using System.Linq;

public class Clinic : IClinic
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

        _appointments.Add(new Appointment(1, doctor1, new DateTime(2026, 4, 29, 12, 0, 0)));
        _appointments.Add(new Appointment(2, doctor2, new DateTime(2026, 4, 29, 13, 0, 0)));

    }

    public IEnumerable<Appointment> GetAvailableAppointments()
    {
        return _appointments.Where(a => !a.IsBooked).OrderBy(a => a.DateTime);       
    }

    public void BookAppointment(int appointmentId, Patient patient)
    {
        var appointment = _appointments.FirstOrDefault(a => a.ID == appointmentId);
        
        if (appointment == null)
        {
            Console.WriteLine("Нет такой записи");
            return;
        }

        try
        {
            appointment.Book(patient);
            Console.WriteLine($"Успешная запись: {patient.FullName} к {appointment.Doctor.Name} на {appointment.DateTime:dd.MM.yyyy HH:mm}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void CancelAppointment(int appointmentId)
    {
        var appointment = _appointments.FirstOrDefault(a => a.ID == appointmentId);

        if (appointment == null)
        {
            Console.WriteLine("Такой записи не существует.");
            return;
        }
        
        try
        {
            appointment.Cancel();
            Console.WriteLine($"Запись {appointmentId} отменена");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    
}