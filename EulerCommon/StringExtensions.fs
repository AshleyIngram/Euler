namespace AshleyIngram.Euler.Common

/// <summary>
/// Extensions to the built in <see cref="System.String" /> type to enhance
/// functionality
/// </summary>
module StringExtensions = 
    /// <summary> 
    /// Static Extension method to <see cref="System.String" />
    /// Create a new string from an array of characters 
    /// </summary>
    /// <param name="ca">The character array used to create the string</param>
    /// <returns>A string from the char array</returns>
    type System.String with 
        static member FromCharArray(ca: char[]) = System.String ca