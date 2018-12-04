open System

let generic_type<'T> x y =
    printf "%A" (x + y)

generic_type<float> 2.5 3.0