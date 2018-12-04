open System

type Rectangle = struct
    val Length : float
    val Width : float

    new (length, width) =
        {Length = length; Width = width}
end

let foobar() =
    let area(shape: Rectangle) =
        shape.Length * shape.Width

    let rect = new Rectangle(5.0, 5.0)

    let rect_area = area rect

    printf "Area : %.2f" rect_area

foobar()