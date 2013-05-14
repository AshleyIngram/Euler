namespace AshleyIngram.Euler.Common.StringExtensions

open System

/// <summary>
/// Extensions to the built in <see cref="System.String" /> type to enhance
/// functionality
/// </summary>
module String = 
    /// <summary> 
    /// Static Extension method to create a new string from an array of characters 
    /// </summary>
    /// <param name="ca">The character array used to create the string</param>
    /// <returns>A string from the char array</returns>
    type System.String with 
        static member FromCharArray(ca: char[]) = System.String ca

    /// <summary>
    /// Extension method to determine whether a string is a palindrome
    /// </summary>
    /// <returns>Boolean indicating whether this string is a palindrome</returns>    
    type System.String with 
        member this.IsPalindrome =
            let halfLength = (float(this.Length) / 2.0) |> Math.Floor |> int
            let firstHalf = this.Substring(0, halfLength)

            // Calculate halfway mark correctly if string is odd length
            let startIndex = if this.Length % 2 = 0 then halfLength else halfLength + 1
            let secondHalf = this.Substring(startIndex, halfLength).ToCharArray() |> Array.rev |> String.FromCharArray
    
            firstHalf.Equals(secondHalf)