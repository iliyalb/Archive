open System

[<EntryPoint>]
let main argv =
    let magic_number = "7"
    let mutable guess = ""

    while not(magic_number.Equals(guess)) do
        printf "Guess the number : "
        guess <- Console.ReadLine()

    printf "You guessed the number!"

    Console.ReadKey() |> ignore

    0 // Return 0. This indicates success.