// See https://aka.ms/new-console-template for more information

using TextObjects;

FlexibleListDemo.Run();

Console.CursorTop = 20;

/*
    I dag:
    5. Fleksibel liste - Kommandostyrt program
    6. Lese fra og skrive til JSON-fil
    7. Static vs ikke-static
    8. Ev. starte på innkapsling ELLER mer detaljert fleksibel liste

 Terjes AI-tips: 
   - https://www.deeplearning.ai/courses/machine-learning-specialization
   - https://dotnet.microsoft.com/en-us/apps/machinelearning-ai/ml-dotnet
   Ole Magnus Brastein
   - https://www.youtube.com/ombrastein
   - https://jeremy.fast.ai/

    Tirsdag:
    1. Hvordan ville vi modellert dette i JavaScript?
    2. Hvordan oversetter vi det til C#?
        - Hva med objekter inne i objekter?
    3. Tegne opp
    4. Flytte logikk
        - funksjoner inne i en klasse (metoder)
        - constructor
 */

/*
var model = new Model
{
    CurrentUser = "terje",
    Texts = new TextEffect[] {
        new TextEffect() {
            Text = "AAAAA",
            Color = ConsoleColor.Red,
            Col = 5,
            Row = 1,
            IsInverted = false,
            Case = Case.Upper,
        },
        new TextEffect() {
            Text = "BBB",
            Color = ConsoleColor.Blue,
            Col = 4,
            Row = 2,
            IsInverted = true,
            Case = Case.Default,
        },
        new TextEffect() {
            Text = "C",
            Color = ConsoleColor.Green,
            Col = 3,
            Row = 3,
            IsInverted = false,
            Case = Case.Lower,
        }
    }
};
*/



/*
  let model = {
    currentUser: 'terje',
    texts : [
       {
           text: 'Hallo',
           color: 'red',
           col: 3,
           row: 10,
           isInverted: false,
           case: null,
       },
       {
           text: 'Hallo',
           color: 'red',
           col: 3,
           row: 10,
           isInverted: false,
           case: null,
       },
       {
           text: 'Hallo',
           color: 'red',
           col: 3,
           row: 10,
           isInverted: false,
           case: null,
       },
    ]
  }

 */

