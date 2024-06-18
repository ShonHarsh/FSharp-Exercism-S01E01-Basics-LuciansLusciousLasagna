module LuciansLusciousLasagna
(*
    Lucian's Luscious Lasagna
*)

// Create a binding of the expected total minutes in the oven.
let expectedMinutesInOven: int =  40

//Functions are also regular bindings, but with one or more parameters. A function automatically returns its last expression
// Create a binding of the remaining minutes in the oven.
let remainingMinutesInOven (minutesElapsedInOven: int): int = expectedMinutesInOven - minutesElapsedInOven

// Create a binding for the total preparation time based on the layer quantity.
let preparationTimeInMinutes (layerQuantity: int) = layerQuantity * 2

//Invoking a function is done by specifying its name and passing arguments for each of the function's parameters.
// Create a binding for the total elapsed time in minutes.
let elapsedTimeInMinutes (layerQuantity: int) (minutesElapsedInOven: int): int = preparationTimeInMinutes(layerQuantity) + minutesElapsedInOven