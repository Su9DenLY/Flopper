open Flopper

let input_file = System.Console.ReadLine()
let input = System.IO.File.ReadAllText input_file

let result = Parser.parse input

match result with
| Result.Ok res ->
    // AST output:
    // printfn $"{res}"
    let exitCode = Interpreter.interpret res
    printfn $"Program finished with {exitCode}"
| Result.Error err -> printf $"{err}"
