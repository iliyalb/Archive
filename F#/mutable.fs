open System

[<EntryPoint>]
let main argv =
    let mutable weight = 100
    weight <- 70
    printfn "Weight : %i" weight

    let changable = ref 10
    changable := 50
    printfn "Change : %i" ! changable

    0 // Return 0. This indicates success.