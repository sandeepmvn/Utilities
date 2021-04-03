using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions.EnumHelper
{
    /// <summary>
    /// Enum Extension helper methods
    /// </summary>
    public static partial class EnumHelpers
    {
        /// <summary>
        /// Retrieves the name of the constant in the specified enumeration that has the specified value.
        /// </summary>
        /// <typeparam name="T">An enumeration type.</typeparam>
        /// <param name="value">A string containing the name or value to convert.</param>
        /// <returns>A string containing the name of the enumerated constant in enumType whose value  is value; or null if no such constant is found. </returns>
        //Get Enum Name
        public static string GetEnumName<T>(int value)
        {
            return Enum.GetName(typeof(T), value);
        }

        /// <summary>
        /// Converts the string representation of the name or numeric value of one or more enumerated constants to an equivalent enumerated object.
        /// </summary>
        /// <typeparam name="T">An enumeration type.</typeparam>
        /// <param name="value">A string containing the name or value to convert.</param>
        /// <exception cref="NullReferenceException">If value is null or empty return null reference exception</exception>
        /// <returns>An object of type enumType whose value is represented by value.</returns>
        //Get Enum Number
        public static T EnumParse<T>(string value) where T : Enum
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                throw new NullReferenceException("Required value");
            return (T)(Enum.Parse(typeof(T), value));
        }
    }
}
