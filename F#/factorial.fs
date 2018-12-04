open System

[<EntryPoint>]
let main argv =
    let rec factorial x =
        if x < 1 then 1
        else x * factorial (x - 1)

    printf "Factorial : %i" (factorial 4)

    0 // Return 0. This indicates success.