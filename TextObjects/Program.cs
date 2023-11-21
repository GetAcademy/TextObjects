// See https://aka.ms/new-console-template for more information

using TextObjects;

// Pause til 10:32

// let myText = {};
// myText = 'Hallo';
//var myText = new TextEffect();
//myText.Text = "Hallo";

//var myTexts = new TextEffect[3];
//myTexts[0] = myText1;
var model = new Model
{
    CurrentUser = "terje",
    Texts = new TextEffect[] {
        new TextEffect() {
            Text = "AAAAA",
            Color = ConsoleColor.Red,
            Col = 1,
            Row = 1,
            IsInverted = false,
            Case = Case.Upper,
        },
        new TextEffect() {
            Text = "BBB",
            Color = ConsoleColor.Blue,
            Col = 1,
            Row = 1,
            IsInverted = true,
            Case = Case.Default,
        },
        new TextEffect() {
            Text = "C",
            Color = ConsoleColor.Green,
            Col = 1,
            Row = 1,
            IsInverted = false,
            Case = Case.Lower,
        }
    }
};

// Pause til 11:02

foreach (var text in model.Texts)
{
    Console.CursorLeft = text.Col;
    Console.CursorTop = text.Row;
    if (text.IsInverted)
    {
        Console.BackgroundColor = text.Color;
        Console.ForegroundColor = ConsoleColor.Black;
    }
    else
    {
        Console.ForegroundColor = text.Color;
        Console.BackgroundColor = ConsoleColor.Black;
    }

    var myText = text.Text;
    if (text.Case == Case.Upper) myText = myText.ToUpper();
    else if (text.Case == Case.Lower) myText = myText.ToLower();
    Console.Write(myText);
}

Console.CursorTop = 20;

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

/*
    En tekst på skjermen
     - Posisjon
     - Farge
     - Invertert
     - Flytte 
     - Store eller små bokstaver

    1. Hvordan ville vi modellert dette i JavaScript?
    2. Hvordan oversetter vi det til C#?
        - Hva med objekter inne i objekter?
    3. Tegne opp
    4. Flytte logikk
        - funksjoner inne i en klasse (metoder)
        - constructor
    5. Fleksibel liste
    6. Lese fra og skrive til JSON-fil
    7. Static vs ikke-static

 */