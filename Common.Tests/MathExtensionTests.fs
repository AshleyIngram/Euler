namespace AshleyIngram.Euler.Test.Common.MathExtensionTests

open NUnit.Framework
open FsUnit

open AshleyIngram.Euler.Common.MathExtensions

[<TestFixture>]
type ``Fibonacci Sequence Tests``()=
    [<Test>]
    member x.``The fibonacci sequence is generated correctly``()=
        let nums = Math.FibonacciSequence |> Seq.take 10 |> Seq.toList;
        nums.Length |> should equal 10
        nums |> should equal [1; 2; 3; 5; 8; 13; 21; 34; 55; 89]

[<TestFixture>]
type ``Greatest Common Factor Tests``()=
    [<Test>]
    member x.``Greatest Common Factor for 2 numbers is calculated correctly``()=
        Math.GreatestCommonFactor(24I, 36I) |> should equal 12I

[<TestFixture>]
type ``Lowest Common Multiple Tests``()=
    [<Test>]
    member x.``Lowest Common Multiple for 2 numbers is correct``()=
        let list: bigint list = [24I; 36I];
        Math.LowestCommonMultiple(list) |> should equal 72I

    [<Test>]
    member x.``Lowest Common Multiple for more than 2 numbers is correct``() =
        Math.LowestCommonMultiple([1I .. 1I .. 10I]) |> should equal 2520I
