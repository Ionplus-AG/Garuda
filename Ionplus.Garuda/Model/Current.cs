// -----------------------------------------------------------------------
// <copyright file="Current.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using UnitsNet;

namespace Ionplus.Garuda.Model
{
    /// <summary>
    /// The current model.
    /// </summary>
    public sealed class Current
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public ElectricCurrent Value { get; set; }

        /// <summary>
        /// Gets or sets the scaler.
        /// </summary>
        public long Scaler { get; set; }
    }
}
