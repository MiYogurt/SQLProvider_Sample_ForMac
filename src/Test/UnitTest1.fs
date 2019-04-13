module Test1

open NUnit.Framework
open System


[<Test>]
let Test1() =
    Assert.IsNotNull(11)


[<Test>]
let Hello() = 
    Assert.AreEqual(10, 10)
