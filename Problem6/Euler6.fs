open System

/// <summary>
/// The sum of the squares of the first ten natural numbers is 385
/// The square of the sum of the first ten natural numbers is 3025
/// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 - 385 = 2640.
///
/// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
/// </summary> 
[<EntryPoint>]
let main argv = 
    let sumOfSquares = [1 .. 1 .. 100] |> List.map(fun x -> x*x) |> List.sum
    let squareOfSum = [1 .. 1 .. 100] |> List.sum |> fun x -> x*x

    let ans = squareOfSum - sumOfSquares

    printfn "Answer = %A" ans
    Console.ReadLine() |> ignore;
    0 // return an integer exit code