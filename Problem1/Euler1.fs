open System

/// <summary>
/// Solution to Project Euler problem 1
/// "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
///  The sum of these multiples is 23. Find the sum of all the multiples of 3 or 5 below 1000."
/// </summary>
[<EntryPoint>]
let main argv = 
    let allnums = [0 .. 1 .. 999]

    let ans = allnums |> List.filter(fun n -> n % 3 = 0 || n % 5 = 0) |> List.sum

    printfn "Answer = %A" ans
    Console.ReadLine() |> ignore;
    0 // return an integer exit code