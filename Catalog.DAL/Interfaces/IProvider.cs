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
        T Get(int id);

        List<T> GetAll();

        void Add(T item);

        void Delete(int id);
    }
}
