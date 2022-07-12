using Microsoft.EntityFrameworkCore;
using zad4;



var Kontekst = new MyDbContext();

//Kontekst.Database.EnsureCreated();
//for (int i = 0; i < 3; i++)
//{
//    var autor = new Autor()
//    {
//        Name = "Adam" + i,
//        Surname = "Mickiewicz" + i
//    };
//    for (int j = 0; j < 3; j++)
//    {
//        autor.Ksiazki.Add(new Ksiazka
//        {
//            Tytul = "Pan Tadeusz" + j,
//            RokWydania = 1920

//        });
//    }
//    Kontekst.Autor.Add(autor);
//}

Kontekst.SaveChanges();

int wybor = 0;
Console.Write("1 - wyszukaj autora po nazwisku ");
Console.WriteLine();
Console.Write("2 - wyszukaj ksiazki po tytule");
Console.WriteLine();
wybor = Int32.Parse(Console.ReadLine());

switch (wybor)
{
    case 1:
        Console.WriteLine("Podaj nazwisko autora:");
        string nazwisko = Console.ReadLine();
        var query=Kontekst.Autor.Where(x => x.Surname == nazwisko).Include(s => s.Ksiazki).ToList();

        foreach (var item in query)
        {
            Console.WriteLine($"Imie: {item.Name}, Nazwisko: {item.Surname} ");
            foreach (var i in item.Ksiazki)
            {
                Console.WriteLine($"Ksiazka:{i.Tytul},Rok wydania:{i.RokWydania}");
            }
        }

        break;
    case 2:
        Console.WriteLine("Podaj tytul ksiazki:");
        string tytul = Console.ReadLine();
        var query2 = Kontekst.Ksiazka.Where(x => x.Tytul == tytul).ToList();

        foreach (var item in query2)
        {
            Console.WriteLine($"Tytul ksiazki: {item.Tytul}, Rok wydania: {item.RokWydania} ");
            
        }

        break;
}


