open System
open Microsoft.FSharp.Math
open AshleyIngram.Euler.Common.Helpers

/// <summary>
/// Find if the product of 2 numbers is a palindrome
/// </summary>
let palinCheck(lhs, rhs) = IsPalindrome((lhs * rhs).ToString())

/// <summary>
/// Find the largest palindrome for any 2 numbers 
/// </summary>
let GetMaxPalindromeProduct(left: int, right: int): int =
    // Generate cartesian product of left and right
    // TODO: Move to common?
    let numbers = [for x in [left .. -1 .. 100] do for y in [right .. -1 .. 100] do yield (x, y)]

    // Get the palindromes, multiply the factors together, and grab the highest one
    numbers |> List.filter(fun (x, y) -> palinCheck(x, y)) |> List.map(fun (x, y) -> x * y) |> List.max 

/// <summary>
/// A palindromic number reads the same both ways. 
/// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 * 99.
///
/// Find the largest palindrome made from the product of two 3-digit numbers.
/// </summary>
[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    Console.WriteLine(GetMaxPalindromeProduct(999, 999));
    Console.ReadLine() |> ignore;
    0 // return an integer exit code