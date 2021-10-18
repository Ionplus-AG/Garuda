// -----------------------------------------------------------------------
// <copyright file="ServerType.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

namespace Ionplus.Garuda.Model
{
    /// <summary>
    /// The supported servertypes.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:EnumerationItemsMustBeDocumented", Justification = "Names should be self explanatory.")]
    public enum ServerType
    {
        MySql,
        MariaDb,
    }
}
