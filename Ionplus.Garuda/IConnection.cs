// -----------------------------------------------------------------------
// <copyright file="IConnection.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Threading.Tasks;

namespace Ionplus.Garuda
{
    /// <summary>
    /// The connection interface.
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    public interface IConnection : IDisposable
    {
        /// <summary>
        /// Gets the database connection string.
        /// </summary>
        string DatabaseConnectionString { get; }

        /// <summary>
        /// Gets the machine number.
        /// </summary>
        int MachineNumber { get; }

        /// <summary>
        /// Gets the prefix.
        /// </summary>
        string Prefix { get; }

        /// <summary>
        /// Gets the connection description.
        /// </summary>
        string ConnectionDescription { get; }

        /// <summary>
        /// Gets the sample family mapper.
        /// </summary>
        ISampleFamilyMapper SampleFamilyMapper { get; }

        /// <summary>
        /// Evaluates the is connected state.
        /// </summary>
        /// <returns><c>true</c> if it is connected; otherwise, <c>false</c>.</returns>
        Task<bool> EvaluateIsConnected();

        /// <summary>
        /// Creates the session.
        /// </summary>
        /// <returns>The created session.</returns>
        ISession CreateSession();
    }
}
