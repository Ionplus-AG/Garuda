// -----------------------------------------------------------------------
// <copyright file="Magazine.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ionplus.Garuda.Model
{
    /// <summary>
    /// The magazine model.
    /// </summary>
    public sealed class Magazine
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the targets.
        /// </summary>
        public IEnumerable<Target> Targets { get; set; } = new List<Target>();

        /// <summary>
        /// Gets or sets the sequences.
        /// </summary>
        public IEnumerable<MeasurementSequence> Sequences { get; set; } = new List<MeasurementSequence>();

        /// <summary>
        /// Gets or sets the last changed.
        /// </summary>
        public DateTime LastChanged { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is a gas batch.
        /// </summary>
        /// <remarks>
        /// A value of <c>null</c> means, we simply don't know.
        /// </remarks>
        public bool? IsGas { get; set; }
    }
}
