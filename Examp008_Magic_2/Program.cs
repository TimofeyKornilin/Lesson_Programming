Console.Clear ();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

Console.WriteLine("     *** Start Program ***");

int xa=10, ya=2,
    xb=10, yb=28,
    xc=90, yc=28,
    xe=90, ye=2;

int x = 50, y = xb;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("@");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("$");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("&");

Console.SetCursorPosition(xe, ye);
Console.WriteLine("!");

int count = 0;

while(count<1000)
{
    int rand = new Random().Next(1,4); // [0,4) ->  0,1,2,3,
    if (rand == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }

    if (rand == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }

    if (rand == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }

    if (rand == 3)
    {
        x = (x + xe)/2;
        y = (y + ye)/2;
    }


    Console.SetCursorPosition(x, y);
    Console.WriteLine("^");
    count = count + 1;
}


Console.SetCursorPosition(xc+1, yc+1);
Console.WriteLine(")(");

Console.WriteLine(" ");
Console.WriteLine("     *** End Program ***");