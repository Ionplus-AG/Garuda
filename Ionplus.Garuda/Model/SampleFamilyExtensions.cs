// -----------------------------------------------------------------------
// <copyright file="SampleFamilyExtensions.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Ionplus.Garuda.Model
{
    /// <summary>
    /// Extension methods for <see cref="SampleFamily"/> values.
    /// </summary>
    public static class SampleFamilyExtensions
    {
        /// <summary>
        /// Determines whether the specified family is a blank.
        /// </summary>
        /// <param name="family">The family.</param>
        /// <returns>
        ///   <c>true</c> if the specified family is a blank; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsBlank(this SampleFamily family)
            => family == SampleFamily.BlankSolid || family == SampleFamily.BlankGas;

        /// <summary>
        /// Determines whether the specified family is a standard.
        /// </summary>
        /// <param name="family">The family.</param>
        /// <returns>
        ///   <c>true</c> if the specified family is a standard; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsStandard(this SampleFamily family)
            => family == SampleFamily.StandardSolid || family == SampleFamily.StandardGas;

        /// <summary>
        /// Determines whether the specified family is a reference solid.
        /// </summary>
        /// <param name="family">The family.</param>
        /// <returns>
        ///   <c>true</c> if the specified family is a reference solid; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsReferenceSolid(this SampleFamily family)
            => family == SampleFamily.BlankSolid || family == SampleFamily.StandardSolid;

        /// <summary>
        /// Determines whether the specified family is a reference gas.
        /// </summary>
        /// <param name="family">The family.</param>
        /// <returns>
        ///   <c>true</c> if the specified family is a reference gas; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsReferenceGas(this SampleFamily family)
            => family == SampleFamily.BlankGas || family == SampleFamily.StandardGas;
    }
}
