class Appointment
{
    private int _id;
    private Doctor _doctor;
    private string _date;
    private bool _isBooked;
    public int ID {get => _id; private set => _id = value > 0 ? value : 0;}

    public Doctor Doctor {get => _doctor; set => _doctor = value ?? null; }

    public string Date {get => _date; set => _date = string.IsNullOrEmpty(value) ? "Unknown date" : value;}

    public bool IsBooked {get => _isBooked; set => _isBooked = value;}

    public Appointment(int id, Doctor doctor, string date, bool isBooked)
    {
        ID = id;
        Doctor = doctor;
        Date = date;
        this.IsBooked = isBooked;
    }



}