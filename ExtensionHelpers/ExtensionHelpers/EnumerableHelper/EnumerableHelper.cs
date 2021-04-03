using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Extensions.EnumerableHelper
{
    public static partial class EnumerableHelper
    {
        /// <summary>
        /// Provides functionality to evaluate queries against a specific data source where in the type of the data is known.
        /// </summary>
        /// <typeparam name="TSource">element type of the input</typeparam>
        /// <param name="source">parameter of element type of the input</param>
        /// <param name="condition">check its ture or false</param>
        /// <param name="predicate">Encapsulates a method that has two parameters and returns a value of the type specified by the TResult parameter.</param>
        /// <returns></returns>
        //Whereif
        public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source, bool condition, Func<TSource, int, bool> predicate)
        {
            if (condition)
                return source.Where(predicate);
            else
                return source;
        }
        /// <summary>
        /// Provides functionality to evaluate queries against a specific data source where in the type of the data is known.
        /// </summary>
        /// <typeparam name="T"> The type of the data in the data source.</typeparam>
        /// <param name="query">parameter of element type of the input</param>
        /// <param name="condition">check its ture or false</param>
        /// <param name="predicate">true to indicate that the expression should be compiled to an interpreted form, if it is available; false otherwise.</param>
        /// <returns></returns>
        //whereif
        public static IEnumerable<T> WhereIf<T>(this IEnumerable<T> query, bool condition, Func<T, bool> predicate)
        {
            if (condition)
                return query.Where(predicate);
            else
                return query;
        }
        /// <summary>
        /// Provides functionality to evaluate queries against a specific data source where in the type of the data is known.
        /// </summary>
        /// <typeparam name="TSource">element type of the input</typeparam>
        /// <typeparam name="TKey">element type of a key used for things like grouping.</typeparam>
        /// <param name="query">parameter of element type of the input</param>
        /// <param name="condition">check its ture or false</param>
        /// <param name="keySelector">parameter of element type of the input and element type of a key used for things like grouping.</param>
        /// <returns></returns>
        //Sorting by Orderby
        public static IEnumerable<TSource> OrderByIf<TSource, TKey>(this IEnumerable<TSource> query, bool condition, Func<TSource, TKey> keySelector)
        {
            if (condition)
                return query.OrderBy(keySelector);
            else
                return query;
        }

        /// <summary>
        /// Provides functionality to evaluate queries against a specific data source where in the type of the data is known.
        /// </summary>
        /// <typeparam name="TSource">element type of the input</typeparam>
        /// <typeparam name="TKey">element type of a key used for things like grouping.</typeparam>
        /// <param name="query">parameter of element type of the input</param>
        /// <param name="condition">check its true or false</param>
        /// <param name="keySelector">parameter of element type of the input and element type of a key used for things like grouping.</param>
        /// <returns></returns>
        //Sorting by OrderDescending
        public static IEnumerable<TSource> OrderByDescendingIf<TSource, TKey>(this IEnumerable<TSource> query, bool condition, Func<TSource, TKey> keySelector)
        {
            if (condition)
                return query.OrderByDescending(keySelector);
            else
                return query;
        }
    }
}
