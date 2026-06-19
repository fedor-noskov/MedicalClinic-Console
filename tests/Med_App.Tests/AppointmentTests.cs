namespace Med_App.Tests;

public class AppointmentTests
{
    [Fact]
    public void Constructor_WithValidData_CreatesAppointment()
    {
        int id = 1;
        Doctor doctor = new Doctor(1, "Доктор Сергей", "Стоматолог");
        DateTime dateTime = DateTime.Now.AddDays(1);
        
        Appointment appointment = new Appointment(id, doctor, dateTime);

        Assert.Equal(id, appointment.ID);
        Assert.Equal(doctor, appointment.Doctor);
        Assert.Equal(dateTime, appointment.DateTime);
        Assert.False(appointment.IsBooked);
        Assert.Null(appointment.Patient);
    }

    [Fact]
    public void Constructor_WithInvalidId_ThrowsArgumentException()
    {
        int invalidId = -1;
        Doctor doctor = new Doctor(1, "Доктор Сергей", "Стоматолог");
        DateTime dateTime = DateTime.Now.AddDays(1);

        Assert.Throws<ArgumentException>(() => new Appointment(invalidId, doctor, dateTime));
    }

    [Fact]
    public void Constructor_WithNullDoctor_ThrowsArgumentNullException()
    {
        int id = 1;
        DateTime dateTime = DateTime.Now.AddDays(1);

        Assert.Throws<ArgumentNullException>(() => new Appointment(id, null!, dateTime));

    }

    [Fact] 
    public void Constructor_WithPastDateTime_ThrowsArgumentException()
    {
        int id = 1;
        Doctor doctor = new Doctor(1, "Доктор Сергей", "Стоматолог");
        DateTime pastDateTime = DateTime.Now.AddDays(-1);

        Assert.Throws<ArgumentException>(() => new Appointment(id, doctor, pastDateTime));
    }

    [Fact]
    public void Book_WithValidPatient_BooksAppointment()
    {
        int id = 1;
        Doctor doctor = new Doctor(1, "Доктор Сергей", "Стоматолог");
        DateTime dateTime = DateTime.Now.AddDays(1);

        Appointment appointment = new Appointment(id, doctor, dateTime);
        Patient patient = new Patient(1, "Иван Иванов", "1234567890");

        appointment.Book(patient);

        Assert.True(appointment.IsBooked);
        Assert.Equal(patient, appointment.Patient);
    }

    [Fact]
    public void Book_WhenAlreadyBooked_ThrowsInvalidOperationException()
    {
        int id = 1;
        Doctor doctor = new Doctor(1, "Доктор Сергей", "Стоматолог");
        DateTime dateTime = DateTime.Now.AddDays(1);

        Appointment appointment = new Appointment(id, doctor, dateTime);

        Patient patient1 = new Patient(1, "Иван Иванов", "1234567890");
        Patient patient2 = new Patient(2, "Петр Петров", "0923452523");

        appointment.Book(patient1);

        Assert.Throws<InvalidOperationException>(() => appointment.Book(patient2));
    }

    [Fact] 
    public void Cancel_WhenBooked_CancelsAppointment()
    {
        int id = 1;
        Doctor doctor = new Doctor(1, "Доктор Сергей", "Стоматолог");
        DateTime dateTime = DateTime.Now.AddDays(1);

        Appointment appointment = new Appointment(id, doctor, dateTime);
        Patient patient = new Patient(1, "Иван Иванов", "1234567890");

        appointment.Book(patient);
        appointment.Cancel();

        Assert.False(appointment.IsBooked);
        Assert.Null(appointment.Patient);

    }

    [Fact]
    public void Cancel_WhenNotBooked_ThrowsInvalidOperationException()
    {
        int id = 1;
        Doctor doctor = new Doctor(1, "Доктор Сергей", "Стоматолог");
        DateTime dateTime = DateTime.Now.AddDays(1);

        Appointment appointment = new Appointment(id, doctor, dateTime);

        Assert.Throws<InvalidOperationException>(() => appointment.Cancel());
    }
}