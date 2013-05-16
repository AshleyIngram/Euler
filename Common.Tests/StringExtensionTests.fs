namespace AshleyIngram.Euler.Test.Common.StringExtensionTests

open NUnit.Framework
open FsUnit

open AshleyIngram.Euler.Common.StringExtensions.String

[<TestFixture>]
type ConvertFromCharArrayTests ()=
    [<Test>]
    member x.``it converts to a char array to a String successfully`` ()=
            System.String.FromCharArray([|'h'; 'e'; 'l'; 'l'; 'o'|]) |> should equal "hello";

[<TestFixture>]
type PalindromeTests ()=
    [<Test>] 
    member x.``It returns true for a palindrome`` ()=
            // odd number of characters
            "aba".IsPalindrome |> should equal true;

            // even number of characters
            "abba".IsPalindrome |> should equal true;

    [<Test>] 
    member x.``It returns false for a non-palindrome`` ()=
            "abc".IsPalindrome |> should equal false;