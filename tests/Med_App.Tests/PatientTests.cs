namespace Med_App.Tests;

public class PatientTests
{
    [Fact]
    public void Constructor_WithValidData_CreatesPatient()
    {
        int id = 1;
        string fullName = "Иван Иванов";
        string phoneNumber = "1234567890";

        Patient patient = new Patient(id, fullName, phoneNumber);

        Assert.Equal(id, patient.ID);
        Assert.Equal(fullName, patient.FullName);
        Assert.Equal(phoneNumber, patient.PhoneNumber);
    }
    
    [Fact]
    public void Constructor_WithInvalidId_ThrowsArgumentException()
    {
        int invalidId = -1;
        string fullName = "Иван Иванов";
        string phoneNumber = "1234567890";

        Assert.Throws<ArgumentException>(() => new Patient(invalidId, fullName, phoneNumber));

    }

    [Fact]
    public void Constructor_WithEmptyFullName_ThrowsArgumentException()
    {
        int id = 1;
        string emptyFullName ="";
        string phoneNumber = "1234567890";

        Assert.Throws<ArgumentException>(() => new Patient(id, emptyFullName, phoneNumber));

    }

    [Fact]
    public void Constructor_WithEmptyPhoneNumber_ThrowsArgumentException()
    {
        int id = 1;
        string fullName = "Иван Иванов";
        string emptyPhoneNumber = "";

        Assert.Throws<ArgumentException>(() => new Patient(id, fullName, emptyPhoneNumber));

    }

}