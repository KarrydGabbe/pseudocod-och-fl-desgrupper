Random rd = new Random();
int tal= rd.Next( 1,100 ) ;

Console.WriteLine("Hej! Jag heter Kasper. Gissa vilket tal jag tänker på: ");

string tal1 = Console.ReadLine();
int tal2= int.Parse(tal1);

int forsok = 1 ;

while ( tal2 != tal )
{
    
    if(tal2 > tal )
    {
        Console.WriteLine("talet är mindre");
    }
    if(tal2 < tal )
    {
        Console.WriteLine("talet är större");
    }
    tal1 = Console.ReadLine();
    tal2= int.Parse(tal1);
    forsok++;
}

Console.WriteLine( "Du svarade rätt!");
Console.WriteLine(" Antal försök:" + forsok );
