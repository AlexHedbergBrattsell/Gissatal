
Console.WriteLine("Välkommen till hangman! Ett hemlig ord med 6 bokstäver har genererats, ta gissningar med bokstaver och försök lista ut  ordet under åtta försök! Men var försiktig, en fel gissning får dig att förlora spelet!");


int fel = 0;
int försök = 8;

string alphabet = "abcdefghijklmnopqrstuvwxyzåäö";

List<string> ord = new List<string>();

ord.Add("platta");
ord.Add("drycka");
ord.Add("strida");
ord.Add("listan");
ord.Add("fågeln");
ord.Add("slängt");
ord.Add("trångt");
ord.Add("dansar");
ord.Add("piller");

string slumpord = "";

Random rnd = new();

slumpord = ord[rnd.Next(ord.Count)].ToUpper();

alphabet = alphabet.ToUpper();

string rättbokstäver = "";

while (true)
{

    string input = Console.ReadLine();


    input = input.ToUpper();

    if (slumpord == input)
    {

        Console.WriteLine($"Bra jobbat! Ordet var: {slumpord}");

        break;

    }

    bool isCorrect = false;

    for (int i = 0; i < slumpord.Length; i++)
    {

        if (slumpord[i] == input[0])
        {
            rättbokstäver += input[0];


            isCorrect = true;
        }

        if (rättbokstäver.Contains(slumpord[i]))
        {
            Console.Write(slumpord[i]);
        }

        else
        {
            Console.Write("*");
        }

    }
    if (isCorrect == false && input.Length == 1)
    {


        fel++;

        Console.WriteLine();

        Console.WriteLine($"fel bokstav! du har {försök - fel} försök till!");

    }
    if (fel == försök)
    {
        Console.WriteLine();
        Console.WriteLine($"Tyvärr, du har förlorat! Ordet var: {slumpord}");
        break;
    }

    if (input.Length < 5 && input.Length > 1)
    {
        Console.WriteLine();
        Console.WriteLine("Du kan bara gissa en bokstav åt gången eller gissa ordet!");
    }

    if (!alphabet.Contains(input[0]))
    {
        Console.WriteLine();
        Console.WriteLine("Du kan bara gissa bokstäver!");
    }

    if (input.Length == 6 && slumpord != input)
    {
        Console.WriteLine();
        Console.WriteLine($"Tyvärr, Ordet var {slumpord}. Du förlorar!");
        break;

    }
    Console.WriteLine();

}