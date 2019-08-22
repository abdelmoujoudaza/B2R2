open B2R2.BinIR.LowUIR
open System

module Program =

  [<EntryPoint>]
  let main _ =
    printfn "........LowUIRParser running......"
    let p = LowUIRParser ()
    while true do
      let test = Console.ReadLine ()
      let result =
        if test.Length = 0 then "->"
        else "->" + p.Run test
      printfn "%s" result


    0
