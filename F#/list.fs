open System

[<EntryPoint>]
let main argv =
    let list1 = [1;2;3]
    let list2 = List.map (fun x -> x * 2) list1
    
    printf "Doubles : %A" list2

    [5;6;7;8]
    |> List.filter (fun v -> (v % 2) = 0)
    |> List.map (fun x -> x * 2)
    |> printf " Even Doubles : %A"

    0 // Return 0. This indicates success.