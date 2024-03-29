// -----------------------------------------------------------------------
// <copyright file="InitializeData.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace Ionplus.Garuda.Model
{
    /// <summary>
    /// The initialize data.
    /// </summary>
    public sealed class InitializeData
    {
        /// <summary>
        /// Gets or sets the database connection string.
        /// </summary>
        public string DatabaseConnectionString { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of the server.
        /// </summary>
        public ServerType ServerType { get; set; }

        /// <summary>
        /// Gets or sets the server version.
        /// </summary>
        public string ServerVersion { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the machine number.
        /// </summary>
        public int MachineNumber { get; set; }

        /// <summary>
        /// Gets or sets the prefix.
        /// </summary>
        public string Prefix { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the instrument id.
        /// </summary>
        public string? InstrumentId { get; set; }
    }
}
