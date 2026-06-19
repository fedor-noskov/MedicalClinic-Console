namespace Med_App.Tests;

public class ClinicTests
{
    [Fact]
    public void GetAvailableAppointments_Initially_ReturnsTwoAppointments()
    {
        var clinic = new Clinic();

        var availableAppointments = clinic.GetAvailableAppointments().ToList();

        Assert.Equal(2, availableAppointments.Count);
    }

    [Fact]
    public void BookAppointment_WithValidId_AppointmentBecomeBooked()
    {
        var clinic = new Clinic();

        clinic.BookAppointment(1, new Patient(1, "Иван Иванов", "1234567890"));

        var availableAppointments = clinic.GetAvailableAppointments().ToList();

        Assert.Equal(1, availableAppointments.Count);
        
    }

    [Fact]
    public void BookAppointment_WithInvalidId_ThrowsKeyNotFoundException()
    {
        var clinic = new Clinic();
        int invalidId = 999;
        
        Assert.Throws<KeyNotFoundException>(() => clinic.BookAppointment(invalidId, new Patient(1, "Иван Иванов", "1234567890")));
    }

    [Fact]
    public void CancelAppointment_WithValidId_AppointmentBecomeAvailable()
    {
        var clinic = new Clinic();

        clinic.BookAppointment(1, new Patient(1, "Иван Иванов", "1234567890"));
        clinic.CancelAppointment(1);

        var availableAppointments = clinic.GetAvailableAppointments().ToList();

        Assert.Equal(2, availableAppointments.Count);
    }

    [Fact]
    public void CancelAppointment_WithInvalidId_ThrowsKeyNotFoundException()
    {
        var clinic = new Clinic();
        int invalidId = 999;

        Assert.Throws<KeyNotFoundException>(() => clinic.CancelAppointment(invalidId));
    }
}