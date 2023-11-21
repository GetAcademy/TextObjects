// See https://aka.ms/new-console-template for more information

using TextObjects;

Console.WriteLine("Hello, World!");

// let myText = {};
// myText = 'Hallo';
//var myText = new TextEffect();
//myText.Text = "Hallo";

var myText = new TextEffect()
{
    Text = "Hallo",
    Color = ConsoleColor.Red,
    Col = 3,
    Row = 10,
    IsInverted = false,
    Case = Case.Default,
};

/*
  let texts = [
   {
       text: 'Hallo',
       color: 'red',
       col: 3,
       row: 10,
       isInverted: false,
       case: null,
   },
   ];
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

 */