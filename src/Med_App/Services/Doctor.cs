using Med_App;
public class Doctor
{
    private int _id;
    private string _name;
    private string _specialization;
    
    public int ID { get => _id; private set => _id = Guard.Positive(value, "ID");}
    public string Name { get => _name; set => _name = Guard.NotEmpty(value, "Имя"); }
    public string Specialization { get => _specialization; set => _specialization = Guard.NotEmpty(value, "Специализация"); }

    public Doctor(int id, string name, string specialization)
    {
        ID = id;
        Name = name;
        Specialization = specialization;
    }
}
