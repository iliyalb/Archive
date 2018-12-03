open System

let hello()=
    printf "Your name: "

    let name = Console.ReadLine();

    printfn "Hello %s" name

hello()

Console.ReadKey() |> ignore