
class Doctor
{
    private int _id;
    private string _name;
    private string _specialization;
    
    public int ID { get => _id; private set => _id = value > 0 ? value : 0; }
    public string Name { get => _name; set => _name = string.IsNullOrEmpty(value) ? "Unknown" : value; }
    public string Specialization { get => _specialization; set => _specialization = string.IsNullOrEmpty(value) ? "Unknown" : value; }

    public Doctor(int id, string name, string specialization)
    {
        ID = id;
        Name = name;
        Specialization = specialization;
    }
}
