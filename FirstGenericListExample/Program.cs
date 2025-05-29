public class Program
{
    public static void Main(string[] args)
    {
        List<string> Guests = new List<string>() { "Bülent Ersoy","Ajda Pekkan","Ebru Gündeş","Hadise","Hande Yener","Tarkan","Funda Arar","Demet Akalın"};

        Console.WriteLine("**Davetliler**");
        //index numaralarına ihtiyaç duyduğum için for kullandım
        for(int i=0; i<Guests.Count; i++)
        {
            Console.WriteLine(+(i+1) +" - " + Guests[i]);
        }
    }
}
