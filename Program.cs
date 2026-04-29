
Clinic clinic = new();

Console.WriteLine("Доступные записи: ");
clinic.ShowAvailableAppointments();

Console.WriteLine("Пациент бронирует запись ID 1");
clinic.BookAppointment(1);

Console.WriteLine("Доступные записи после бронирования: ");
clinic.ShowAvailableAppointments();

Console.WriteLine("Попытка забронировать уже занятую запись ID 1");
clinic.BookAppointment(1);

Console.WriteLine("Попытка забронировать несуществующую запись ID 55");
clinic.BookAppointment(55);

