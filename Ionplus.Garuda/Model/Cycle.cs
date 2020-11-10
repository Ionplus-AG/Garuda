// -----------------------------------------------------------------------
// <copyright file="Cycle.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Ionplus.Garuda.Model
{
    /// <summary>
    /// The cycle model.
    /// </summary>
    public sealed class Cycle
    {
        /// <summary>
        /// Gets or sets the cycle number.
        /// </summary>
        public int CycleNumber { get; set; }

        /// <summary>
        /// Gets or sets the subcycle number.
        /// </summary>
        public int SubcycleNumber { get; set; }

        /// <summary>
        /// Gets or sets the definition.
        /// </summary>
        public CycleDefinition Definition { get; set; } = new CycleDefinition();

        /// <summary>
        /// Gets or sets the runtime.
        /// </summary>
        public double Runtime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the ANA current.
        /// </summary>
        public Current? Ana { get; set; }

        /// <summary>
        /// Gets or sets a current.
        /// </summary>
        public Current? A { get; set; }

        /// <summary>
        /// Gets or sets the b current.
        /// </summary>
        public Current? B { get; set; }

        /// <summary>
        /// Gets or sets the c current.
        /// </summary>
        public Current? C { get; set; }

        /// <summary>
        /// Gets or sets the r.
        /// </summary>
        public long? R { get; set; }

        /// <summary>
        /// Gets or sets the g1.
        /// </summary>
        public long? G1 { get; set; }

        /// <summary>
        /// Gets or sets the g2.
        /// </summary>
        public long? G2 { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is burn in.
        /// </summary>
        public bool IsBurnIn { get; set; }
    }
}
