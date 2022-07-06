

int time = DateTime.Now.Hour;

if ((time >= 6) && (time < 11))
    Console.WriteLine("Günaydın!");
else if (time <= 18)
    Console.WriteLine("İyi Günler!");
else
    Console.WriteLine("İyi Akşamlar!");


int kilo = Convert.ToInt32(Console.ReadLine());

string saglik = kilo >= 100 ? "Sağlığına dikkat et!" : "Sağlıklısın, böyle devam et!";

Console.WriteLine(saglik);






Console.ReadLine();

