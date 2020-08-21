// -----------------------------------------------------------------------
// <copyright file="Run.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;

namespace Ionplus.Garuda.Model
{
    /// <summary>
    /// The run model.
    /// </summary>
    public sealed class Run
    {
        /// <summary>
        /// Gets or sets the run identifier.
        /// </summary>
        public string RunId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the cycles.
        /// </summary>
        public IEnumerable<Cycle> Cycles { get; set; } = new List<Cycle>();

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        public Target Target { get; set; } = null!;

        /// <summary>
        /// Gets or sets the spectra id.
        /// </summary>
        public int? SpectraId { get; set; }

        /// <summary>
        /// Gets or sets the spectra path.
        /// </summary>
        public string? SpectraPath { get; set; }
    }
}
