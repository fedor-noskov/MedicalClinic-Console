class Appointment
{
    private int _id;
    private Doctor _doctor;
    private DateTime _dateTime;
    private bool _isBooked;

    public DateTime DateTime {get => _dateTime; set => _dateTime = value;}
    
    public int ID {get => _id; private set => _id = value > 0 ? value : throw new ArgumentException("ID должен быть положительным!");}

    public Doctor Doctor {get => _doctor; set => _doctor = value ?? throw new ArgumentNullException(nameof(value)); }

    public bool IsBooked {get => _isBooked; private set => _isBooked = value;}

    public Patient? Patient {get; private set;}

    public Appointment(int id, Doctor doctor, DateTime dateTime)
    {
        ID = id;
        Doctor = doctor;
        DateTime = dateTime;
        IsBooked = false;
    }

    public void Book(Patient patient)
    {
        if(IsBooked) throw new InvalidOperationException("Запись уже занята");
        Patient = patient;
        IsBooked = true;
    }

    public void Cancel()
    {
        if (!IsBooked) throw new InvalidOperationException("Запись уже отменена");
        Patient = null;
        IsBooked = false;
    }




}