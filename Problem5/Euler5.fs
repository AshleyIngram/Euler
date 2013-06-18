open System
open AshleyIngram.Euler.Common.MathExtensions

/// <summary>
/// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
///
/// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
/// </summary> 
[<EntryPoint>]
let main argv = 
    let ans = Math.LowestCommonMultiple([1I .. 1I .. 20I])

    printfn "Answer = %A" ans
    Console.ReadLine() |> ignore;
    0 // return an integer exit code