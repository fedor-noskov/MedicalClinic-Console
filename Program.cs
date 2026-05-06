Clinic clinic = new();
Patient patient = new Patient(1, "Иван Петров", "+7 999 123-45-67");

Console.WriteLine("Доступные записи: ");
clinic.ShowAvailableAppointments();

Console.WriteLine("\nПациент бронирует запись ID 1");
clinic.BookAppointment(1, patient);

Console.WriteLine("\nДоступные записи после бронирования: ");
clinic.ShowAvailableAppointments();

Console.WriteLine("\nПопытка забронировать уже занятую запись ID 1");
clinic.BookAppointment(1, patient);

Console.WriteLine("\nПопытка забронировать несуществующую запись ID 55");
clinic.BookAppointment(55, patient);

Console.WriteLine("\nПациент отменяет запись ID 1");
clinic.CancelAppointment(1);

Console.WriteLine("\nДоступные записи после отмены: ");
clinic.ShowAvailableAppointments();