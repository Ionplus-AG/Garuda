namespace Ionplus.Garuda.Model
{
    public sealed class InitializeData
    {
        string DatabaseConnectionString { get; set; }
        int MachineNumber { get; set; }
        string Prefix { get; set; }
    }
}
