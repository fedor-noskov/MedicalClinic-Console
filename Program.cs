IClinic clinic = new Clinic();
Patient patient = new Patient(1, "Иван Петров", "+7 999 123-45-67");

Console.WriteLine("Доступные записи: ");
PrintAppointments(clinic.GetAvailableAppointments());

Console.WriteLine("\nПациент бронирует запись ID 1");
try {clinic.BookAppointment(1, patient);}
catch (Exception ex) {Console.WriteLine(ex.Message);}

Console.WriteLine("\nДоступные записи после бронирования: ");
PrintAppointments(clinic.GetAvailableAppointments());

Console.WriteLine("\nПопытка забронировать уже занятую запись ID 1");
try {clinic.BookAppointment(1, patient);}
catch (Exception ex) {Console.WriteLine(ex.Message);}

Console.WriteLine("\nПопытка забронировать несуществующую запись ID 55");
try {clinic.BookAppointment(55, patient);}
catch (Exception ex) {Console.WriteLine(ex.Message);}

Console.WriteLine("\nПациент отменяет запись ID 1");
try {clinic.CancelAppointment(1);}
catch (Exception ex) {Console.WriteLine(ex.Message);}

Console.WriteLine("\nДоступные записи после отмены: ");
PrintAppointments(clinic.GetAvailableAppointments());

void PrintAppointments(IEnumerable<Appointment> appointments)
{
    foreach (var a in appointments)
    {
        Console.WriteLine($"{a.ID}: {a.Doctor.Name} ({a.Doctor.Specialization}) - {a.DateTime:dd.MM.yyyy HH:mm}");
    }
}