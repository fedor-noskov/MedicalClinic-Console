class Appointment
{
    private int _id;
    private Doctor _doctor;
    private DateTime _dateTime;
    private bool _isBooked;

    public DateTime DateTime {get => _dateTime; set => _dateTime = value;}
    
    public int ID {get => _id; private set => _id = value > 0 ? value : 0;}

    public Doctor Doctor {get => _doctor; set => _doctor = value ?? null; }

    public bool IsBooked {get => _isBooked; set => _isBooked = value;}

    public Appointment(int id, Doctor doctor, DateTime dateTime, bool isBooked)
    {
        ID = id;
        Doctor = doctor;
        DateTime = dateTime;
        this.IsBooked = isBooked;
    }



}