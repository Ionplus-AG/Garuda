// -----------------------------------------------------------------------
// <copyright file="Initializer.cs" company="Ionplus AG">
// Copyright (c) Ionplus AG. All rights reserved.
// Licensed under the MIT license.
// See LICENSE in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Linq;
using System.Reflection;

using Ionplus.Garuda.Model;

namespace Ionplus.Garuda
{
    /// <summary>
    /// The initializer for connection.
    /// </summary>
    public static class Initializer
    {
        /// <summary>
        /// Initializes the connection.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <param name="data">The data.</param>
        /// <returns>The initialized connection.</returns>
        /// <exception cref="ArgumentException">
        /// No implementation of type 'IConnection' found.
        /// or
        /// Implementation of type 'IConnection' is missing an constructor with 'InitializeData'.
        /// </exception>
        public static IConnection InitializeConnection(Assembly assembly, InitializeData data)
        {
            var connectionType = assembly.GetTypes().SingleOrDefault(t => t.GetInterfaces().Contains(typeof(IConnection)));
            if (connectionType == null)
            {
                throw new ArgumentException("No implementation of type 'IConnection' found.");
            }

            var types = new Type[1];
            types[0] = typeof(InitializeData);
            var constructor = connectionType.GetConstructor(types);
            if (constructor == null)
            {
                throw new ArgumentException("Implementation of type 'IConnection' is missing an constructor with 'InitializeData'");
            }

            return (IConnection)constructor.Invoke(new object[] { data });
        }
    }
}
