// -----------------------------------------------------------------------
// <copyright file="ISession.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Ionplus.Garuda.Model;

namespace Ionplus.Garuda
{
    /// <summary>
    /// The session interface.
    /// </summary>
    /// <seealso cref="IDisposable" />
    public interface ISession : IDisposable
    {
        /// <summary>
        /// Gets the magazine updates since the given time.
        /// </summary>
        /// <param name="time">The time.</param>
        /// <returns>The updated and obsolete magazines since the given time.</returns>
        Task<(IEnumerable<Magazine> Magazines, IEnumerable<string> Obsolete)> GetMagazineUpdates(DateTime time);

        /// <summary>
        /// Gets the isotopes.
        /// </summary>
        /// <returns>The isotopes.</returns>
        Task<IEnumerable<Isotope>> GetIsotopes();

        /// <summary>
        /// Persists the specified run.
        /// </summary>
        /// <param name="run">The run.</param>
        /// <returns>The persisted run.</returns>
        Task<Run> Persist(Run run);

        /// <summary>
        /// Creates a target for the specified sample/preparation, with the next free target number.
        /// </summary>
        /// <param name="magazineName">Name of the magazine.</param>
        /// <param name="isotopeNumber">The isotope number.</param>
        /// <param name="sampleNumber">The sample number.</param>
        /// <param name="preparationNumber">The preparation number.</param>
        /// <returns>
        /// The created target.
        /// </returns>
        Task<Target> CreateTarget(string magazineName, int isotopeNumber, int sampleNumber, int preparationNumber);

        /// <summary>
        /// Creates a target for the specified identifier.
        /// </summary>
        /// <param name="magazineName">Name of the magazine.</param>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// The created target.
        /// </returns>
        Task<Target> CreateTarget(string magazineName, TargetIdentifier id);

        /// <summary>
        /// Gets the target with the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// The target or <c>null</c> if it doesn't exist.
        /// </returns>
        Task<Target?> GetTarget(TargetIdentifier id);

        /// <summary>
        /// Updates the target.
        /// </summary>
        /// <param name="target">The target.</param>
        /// <returns>The updated target.</returns>
        Task<Target?> Update(Target target);
    }
}
