namespace AshleyIngram.Euler.Common

/// <summary>
/// Extensions to the built in <see cref="Microsoft.Fsharp.Collections.List" /> type to enhance
/// functionality
/// </summary>
module ListExtensions =
    /// <summary>
    /// Checks if a list contains an element
    /// </summary>
    /// <param name="l">The list to check for the element</param>
    /// <param name="i">The item to check for in the list</param>
    /// <returns>Boolean indicating whether the collection contains the value</returns>
    // TODO: Can this be rewritten as a Type Extension? (<'T where 'T: equality> doesn't match List<'T'>)
    let Contains(l, i) = List.exists(fun e -> e = i) l