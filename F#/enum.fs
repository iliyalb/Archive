open System

type enumerator =
    | first = 0
    | second = 1
    | third = 2

[<EntryPoint>]
let main argv =
    let number = enumerator.second

    match number with
    | enumerator.first -> printfn "One"
    | enumerator.second -> printfn "Two"
    | enumerator.third -> printfn "Three"
    | _ -> printfn "Error"

    0 // Return 0. This indicates success.