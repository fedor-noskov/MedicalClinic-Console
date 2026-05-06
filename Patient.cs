class Patient
{
    private int _id;
    private string _fullName;
    private string _phoneNumber;

    public int ID {get; private set;}
    public string FullName {get => _fullName; set => _fullName = string.IsNullOrEmpty(value) ? "Unknown" : value; }
    public string PhoneNumber {get => _phoneNumber; set => _phoneNumber = string.IsNullOrEmpty(value) ? "Unknown" : value;}

    public Patient(int id, string fullName, string phoneNumber)
    {
        ID = id > 0 ? id : throw new ArgumentException("ID должен быть положительным");
        FullName = fullName;
        PhoneNumber = phoneNumber;
        
    }

}