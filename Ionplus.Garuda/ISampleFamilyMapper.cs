// -----------------------------------------------------------------------
// <copyright file="ISampleFamilyMapper.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using Ionplus.Garuda.Model;

namespace Ionplus.Garuda
{
    /// <summary>
    /// Maps target types to <see cref="SampleFamily"/> values.
    /// </summary>
    public interface ISampleFamilyMapper
    {
        /// <summary>
        /// Maps the specified target type to the matching sample family.
        /// </summary>
        /// <param name="targetType">Type of the target.</param>
        /// <returns>The matching sample family.</returns>
        SampleFamily FromTargetType(string targetType);
    }
}
