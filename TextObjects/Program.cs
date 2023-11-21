// See https://aka.ms/new-console-template for more information

using TextObjects;

// Pause til 10:32

// let myText = {};
// myText = 'Hallo';
//var myText = new TextEffect();
//myText.Text = "Hallo";

//var myTexts = new TextEffect[3];
//myTexts[0] = myText1;

var tea = new TextEffect("AAAAA", ConsoleColor.Red, 
    5, 1, false, Case.Upper);
/*
   var tea = new TextEffect();
   tea.Init("AAAAA", ConsoleColor.Red, 5, 1, false, Case.Upper); 
 */

var model = new Model
{
    CurrentUser = "terje",
    Texts = new TextEffect[] {
        new TextEffect("AAAAA",ConsoleColor.Red,5,1,false,Case.Upper),
        new TextEffect("BBB",ConsoleColor.Blue,4,2,true,Case.Default),
        new TextEffect("C",ConsoleColor.Green,3,3,false,Case.Lower),
    }
};

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

while (true)
{
    Console.Clear();
    foreach (var text in model.Texts)
    {
        text.Show();
        text.Flip();
        text.Double();
    }
    Thread.Sleep(1000);
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