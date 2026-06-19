namespace Med_App.Tests;

public class DoctorTests
{
    [Fact]
    public void Constructor_WithValidData_CreatesDoctor()
    {
        int id = 1;
        string name = "Доктор Сергей";
        string specialization = "Стоматолог";

        Doctor doctor = new Doctor(id, name, specialization);

        Assert.Equal(1, doctor.ID);
        Assert.Equal("Доктор Сергей", doctor.Name);
        Assert.Equal("Стоматолог", doctor.Specialization);
    }

    [Fact]
    public void Constructor_WithInvalidId_ThrowsArgumentException()
    {
        int invalidId = -1;
        string name = "Доктор Сергей";
        string specialization = "Стоматолог";

        Assert.Throws<ArgumentException>(() => new Doctor(invalidId, name, specialization));
    }
    
    [Fact]
    public void Constructor_WithEmptyName_ThrowsArgumentException()
    {
        int id = 1;
        string emptyName = "";
        string specialization = "Стоматолог";

        Assert.Throws<ArgumentException>(() => new Doctor(id, emptyName, specialization));
    }

    [Fact]
    public void Constructor_WithEmptySpecialization_ThrowsArgumentException()
    {
        int id = 1;
        string name = "Доктор Сергей";
        string emptySpecialization = "";

        Assert.Throws<ArgumentException>(() => new Doctor(id, name, emptySpecialization));
    }
}
