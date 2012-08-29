// -----------------------------------------------------------------------
// <copyright file="IProvider.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Catalog.DAL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Common interface for all providers.
    /// </summary>
    /// <typeparam name="T">
    /// Entity type
    /// </typeparam>
    public interface IProvider<T>
    {
        void Add(T category);

        T Get(int id);

        void Delete(int id);
    }
}
