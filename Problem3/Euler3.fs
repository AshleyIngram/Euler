module AshleyIngram.Euler.Problem3

open System;
open AshleyIngram.Euler.Common.MathExtensions

/// <summary>
/// The prime factors of 13195 are 5, 7, 13 and 29.
/// What is the largest prime factor of the number 600851475143?
/// </summary>
let solution input =
    let allPrimes = Math.PrimeGenerator(input);
    let primeFactors = allPrimes |> List.filter(fun n -> input % n = 0UL);
    primeFactors.Item(primeFactors.Length - 1)


[<EntryPoint>]
let main argv = 
    let input = 600851475143UL;
    let ans = solution input
    Console.WriteLine("Highest Prime Factor is " + ans.ToString());
    Console.ReadLine() |> ignore;
    0 // return an integer exit code