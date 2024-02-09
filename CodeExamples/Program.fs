module CodeTests

open System // Gets access to functionality in System namespace.

// Defines a list of names and numbers below
let names = ["Reed"; "Jonah"; "Jerome"; "Gina"; "Daisy"; "Gabriella"]
let numbers = [2; 5; 3; 6; 7; 9]

// Defines a function that takes a name and produces a greeting.
let getGreeting name = $"Hello, {name}"

let squared number = printfn $"{number} squared is {number * number}"


let fib n =
    let rec loop acc1 acc2 n =
        match n with
        | 0 -> acc1
        | 1 -> acc2
        | _ ->
            printfn $"current value: {acc2}"
            loop acc2 (acc1 + acc2) (n - 1)    
    loop 0 1 n

let n = 20
let x = fib(n)

printfn $"fibbonaci({n}): {x}"

// Prints a greeting for each name!
names
|> List.map getGreeting
|> List.iter (fun greeting -> printfn $"{greeting}! Enjoy your F#")

// Prints the squared number of each number
numbers
|> List.map squared
|> List.iter (fun square -> printfn $"{square}")