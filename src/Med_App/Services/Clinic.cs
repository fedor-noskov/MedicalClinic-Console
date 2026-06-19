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

        _appointments.Add(new Appointment(1, doctor1, new DateTime(2026, 8, 15, 12, 0, 0)));
        _appointments.Add(new Appointment(2, doctor2, new DateTime(2026, 8, 15, 13, 0, 0)));

    }

    public IEnumerable<Appointment> GetAvailableAppointments()
    {
        return _appointments.Where(a => !a.IsBooked).OrderBy(a => a.DateTime);       
    }

    public void BookAppointment(int appointmentId, Patient patient)
    {
        var appointment = _appointments.FirstOrDefault(a => a.ID == appointmentId);
        
        if (appointment == null) throw new KeyNotFoundException($"Запись с ID {appointmentId} не найдена.");
        
        appointment.Book(patient);
    }
           
        

    public void CancelAppointment(int appointmentId)
    {
        var appointment = _appointments.FirstOrDefault(a => a.ID == appointmentId);

        if (appointment == null) throw new KeyNotFoundException($"Запись с ID {appointmentId} не существует.");

        appointment.Cancel();
    }

    
}