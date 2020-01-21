namespace Ionplus.Garuda
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Ionplus.Garuda.Model;

    public interface ISession : IDisposable
    {
        Task<Magazine> GetMagazineUpdates(DateTime? time);
        Task<Target> GetUpdatedTargets(DateTime time);
        Task<Isotope> GetIsotopes();

        Task<Run> Persist(Run run);
        Task Add(IEnumerable<Cycle> cycles);
        Task Update(Magazine magazine);
        Task CreateTarget(string magazineName, Target target);
        Task UpdateTarget(Target target);
    }
}
