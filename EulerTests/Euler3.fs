namespace AshleyIngram.Euler.Test.Solutions

open NUnit.Framework
open FsUnit

open AshleyIngram.Euler.Problem3

[<TestFixture>]
type Solution3 ()=
    [<Test>]
    member x.``The solution calculates the correct answer for the provided sample`` () =
        solution 13195UL |> should equal 29