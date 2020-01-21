// -----------------------------------------------------------------------
// <copyright file="Target.cs" company="Ionplus AG">
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
    /// The target model.
    /// </summary>
    public sealed class Target
    {
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

        /// <summary>
        /// Gets or sets the isotope number.
        /// </summary>
        public int? IsotopeNumber { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        public int? Position { get; set; }

        /// <summary>
        /// Gets or sets the maximum cycles.
        /// </summary>
        public int? MaxCycles { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the runs.
        /// </summary>
        public IEnumerable<Run> Runs { get; set; }

        /// <summary>
        /// Gets or sets the last changed.
        /// </summary>
        public DateTime? LastChanged { get; set; }
    }
}
