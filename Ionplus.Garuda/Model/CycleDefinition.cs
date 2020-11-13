// -----------------------------------------------------------------------
// <copyright file="CycleDefinition.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Ionplus.Garuda.Model
{
    /// <summary>
    /// The definition of a cycle.
    /// </summary>
    public sealed class CycleDefinition
    {
        /// <summary>
        /// Gets or sets the isotope number.
        /// </summary>
        public int IsotopeNumber { get; set; }

        /// <summary>
        /// Gets or sets the sequence.
        /// </summary>
        public int Sequence { get; set; }

        /// <summary>
        /// Gets or sets the electrical charge.
        /// </summary>
        public double ElectricalCharge { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the R count.
        /// </summary>
        public string? RName { get; set; }

        /// <summary>
        /// Gets or sets the name of the gate 1 count.
        /// </summary>
        public string? G1Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the gate 2 count.
        /// </summary>
        public string? G2Name { get; set; }

        /// <summary>
        /// Gets or sets the name of the ANA current.
        /// </summary>
        public string? AnaName { get; set; }

        /// <summary>
        /// Gets or sets the name of the A current.
        /// </summary>
        public string? AName { get; set; }

        /// <summary>
        /// Gets or sets the name of the B current.
        /// </summary>
        public string? BName { get; set; }

        /// <summary>
        /// Gets or sets the name of the C current.
        /// </summary>
        public string? CName { get; set; }
    }
}
