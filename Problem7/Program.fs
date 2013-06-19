open System
open AshleyIngram.Euler.Common.MathExtensions

/// <summary>
/// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
///
/// What is the 10 001st prime number?
/// </summary>
[<EntryPoint>]
let main argv = 
    let ans = Seq.take 10001 Math.PrimeSequence |> Seq.last

    printfn "Answer = %A" ans
    Console.ReadLine() |> ignore;
    0 // return an integer exit code