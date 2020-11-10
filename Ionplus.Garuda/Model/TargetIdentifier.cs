// -----------------------------------------------------------------------
// <copyright file="TargetIdentifier.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Ionplus.Garuda.Model
{
    /// <summary>
    /// Identifies a target.
    /// </summary>
    public sealed class TargetIdentifier
    {
        /// <summary>
        /// Gets or sets the isotope number.
        /// </summary>
        public int IsotopeNumber { get; set; }

        /// <summary>
        /// Gets or sets the sample number.
        /// </summary>
        public int SampleNumber { get; set; }

        /// <summary>
        /// Gets or sets the preparation number.
        /// </summary>
        public int PreparationNumber { get; set; }

        /// <summary>
        /// Gets or sets the target number.
        /// </summary>
        public int TargetNumber { get; set; }
    }
}
