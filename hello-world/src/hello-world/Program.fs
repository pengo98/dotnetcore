// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#! Arg=%A DateTime=%A foo=%s" argv (DateTimeOffset.UtcNow) "bar"
    0 // return an integer exit code
