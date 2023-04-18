// -----------------------------------------------------------------------
// <copyright file="ObsoleteMagazine.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace Ionplus.Garuda.Model
{
    /// <summary>
    /// The obsolete magazine model.
    /// </summary>
    public class ObsoleteMagazine
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the last changed.
        /// </summary>
        public DateTime LastChanged { get; set; }
    }
}
