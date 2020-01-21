namespace Ionplus.Garuda
{
    using System;
    using System.Threading.Tasks;

    public interface IConnection : IDisposable
    {
        string DatabaseConnectionString { get; }
        int MachineNumber { get; }
        string Prefix { get; }

        Task<bool> EvaluateIsConnected();
        ISession CreateSession();
    }
}
