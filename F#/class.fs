open System

type Animal = class
    val Name : string
    val Height : float
    val Weight : float

    new (name, height, weight) =
        {Name = name; Height = height; Weight = weight;}

    member x.Run =
        printfn "%s Runs" x.Name
end

type Dog(name, height, weight) =
    inherit Animal(name, height, weight)

    member x.Bark =
        printfn "%s Barks" x.Name

let foobar() =
    let bolt = new Dog("Bolt", 20.0, 25.0)
    bolt.Run 
    bolt.Bark

foobar()