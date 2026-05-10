
public class Doctor
{
    private int _id;
    private string _name;
    private string _specialization;
    
    public int ID { get => _id; private set => _id = value > 0 ? value : throw new ArgumentException("ID должен быть положительным!"); }
    public string Name { get => _name; set => _name = string.IsNullOrEmpty(value) ? throw new ArgumentException("Имя не может быть пустым!") : value; }
    public string Specialization { get => _specialization; set => _specialization = string.IsNullOrEmpty(value) ? throw new ArgumentException("Специализация не может быть пустой!") : value; }

    public Doctor(int id, string name, string specialization)
    {
        ID = id;
        Name = name;
        Specialization = specialization;
    }
}
