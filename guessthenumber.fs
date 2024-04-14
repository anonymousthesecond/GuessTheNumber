open System

let rec guessNumber (target: int) (attemptsLeft: int) =
    if attemptsLeft <= 0 then
        printfn "Out of attempts! The number was: %d" target
    else
        printfn "Guess the number (between 1 and 100, inclusive): "
        let guess = Console.ReadLine()
        match Int32.TryParse(guess) with
        | true, number ->
            if number = target then
                printfn "Congratulations! You guessed it!"
            elif number < target then
                printfn "Too low! Try again."
                guessNumber target (attemptsLeft - 1)
            else
                printfn "Too high! Try again."
                guessNumber target (attemptsLeft - 1)
        | _ ->
            printfn "Invalid input. Please enter a valid number."
            guessNumber target attemptsLeft

let main() =
    let rnd = Random()
    let targetNumber = rnd.Next(1, 101) // Generate a random number between 1 and 100
    printfn "Welcome to the Guess the Number game!"
    printfn "You have 5 attempts to guess the number."
    guessNumber targetNumber 5

main()
