using Med_App;
public class Patient 
{
    private int _id;
    private string _fullName;
    private string _phoneNumber;

    public int ID {get => _id; private set => _id = Guard.Positive(value, "ID");}
    public string FullName {get => _fullName; set => _fullName = Guard.NotEmpty(value, "Имя"); }
    public string PhoneNumber {get => _phoneNumber; set => _phoneNumber = Guard.NotEmpty(value, "Номер телефона"); }

    public Patient(int id, string fullName, string phoneNumber)
    {
        ID = id;
        FullName = fullName;
        PhoneNumber = phoneNumber;
        
    }

}