Console.Clear ();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

Console.WriteLine("     *** Start Program ***");

int xa=27, ya=2,
    xb=1, yb=28,
    xc=100, yc=28;

int x = xa, y = xb;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("@");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("$");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("&");

int count = 0;

while(count<10000)
{
    int rand = new Random().Next(0,3); // [0,3) ->  0,1,2.
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

    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    count = count + 1;
}


Console.SetCursorPosition(xc+1, yc);
Console.WriteLine("&");

Console.WriteLine(" ");
Console.WriteLine("     *** End Program ***");