public interface IClinic
{
    IEnumerable<Appointment> GetAvailableAppointments();
    void BookAppointment(int appointmentId, Patient patient);
    void CancelAppointment(int appointmentId);
}