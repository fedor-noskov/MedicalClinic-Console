public interface IClinic
{
    void ShowAvailableAppointments();
    void BookAppointment(int appointmentId, Patient patient);
    void CancelAppointment(int appointmentId);
    
}