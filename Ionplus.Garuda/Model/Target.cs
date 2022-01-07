// -----------------------------------------------------------------------
// <copyright file="Target.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Ionplus.Garuda.Model
{
    /// <summary>
    /// The target model.
    /// </summary>
    public sealed class Target
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public TargetIdentifier Id { get; set; } = new TargetIdentifier();

        /// <summary>
        /// Gets the sample number.
        /// </summary>
        public int SampleNumber => this.Id.SampleNumber;

        /// <summary>
        /// Gets the preparation number.
        /// </summary>
        public int PreparationNumber => this.Id.PreparationNumber;

        /// <summary>
        /// Gets the target number.
        /// </summary>
        public int TargetNumber => this.Id.TargetNumber;

        /// <summary>
        /// Gets the isotope number.
        /// </summary>
        public int IsotopeNumber => this.Id.IsotopeNumber;

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        public int? Position { get; set; }

        /// <summary>
        /// Gets or sets the maximum cycles.
        /// </summary>
        public int MaxCycles { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        public string? Comment { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Gets or sets the code number.
        /// </summary>
        public string? CodeNumber { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is writable.
        /// </summary>
        public bool IsWritable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is writable.
        /// </summary>
        public string? MagazineName { get; set; }

        /// <summary>
        /// Gets or sets the weight in g.
        /// </summary>
        public double? Weight { get; set; }
    }
}
