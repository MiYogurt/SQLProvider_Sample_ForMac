// Learn more about F# at http://fsharp.org

open System
open FSharp.Data.Sql

let [<Literal>] connString = "Host=localhost;Database=test_db;Username=bob;Password=bob"

let [<Literal>] dbVendor = Common.DatabaseProviderTypes.POSTGRESQL

type sql = SqlDataProvider<dbVendor,connString, "", "./temp" >

let runtimeConnString = connString

[<EntryPoint>]
let main argv =
    let ctx = sql.GetDataContext(runtimeConnString)
    printfn "Hello World from F#!"
    0 // return an integer exit code
