public class Patient 
{
    private string _fullName;
    private string _phoneNumber;

    public int ID {get; private set;}
    public string FullName {get => _fullName; set => _fullName = string.IsNullOrEmpty(value) ? throw new ArgumentException("Имя не может быть пустым!") : value; }
    public string PhoneNumber {get => _phoneNumber; set => _phoneNumber = string.IsNullOrEmpty(value) ? throw new ArgumentException("Номер телефона не может быть пустым!") : value;}

    public Patient(int id, string fullName, string phoneNumber)
    {
        ID = id > 0 ? id : throw new ArgumentException("ID должен быть положительным!");
        FullName = fullName;
        PhoneNumber = phoneNumber;
        
    }

}