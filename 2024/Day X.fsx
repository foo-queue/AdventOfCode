// https://adventofcode.com/2024/day/X
#if INTERACTIVE
#load "../FSharpHelpers.fsx"
#endif

open System
open System.Text.RegularExpressions
open FSharpHelpers

type InputData = string[]

let parseInput (text: string) : InputData =
    text
    |> String.splitAndTrim "\n"
    |> Array.map (fun s ->
        match s with
        | "pattern" -> s
        | _ -> failwithf "Unexpected input: %s" s)
    |> dump

let validateAssumptions (data: InputData) =
    // Note: `assert` does not work in FSI, so must throw exception
    if false then
        failwith "bad assumption"

let parseData s = parseInput s |> tee validateAssumptions

let sample1 =
    parseData
        """

"""

let sample2 = sample1

let data =
    let rawData = getInput ()
    lazy (rawData |> parseData)

let part1 (data: InputData) =
    //
    0

let part2 (data: InputData) =
    //
    0

executePuzzle "Part 1 sample" (fun () -> part1 sample1) 0
executePuzzle "Part 1 finale" (fun () -> part1 data.Value) 0

executePuzzle "Part 2 sample" (fun () -> part2 sample1) 0
executePuzzle "Part 2 finale" (fun () -> part2 data.Value) 0
