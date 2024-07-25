namespace DICTIONARY_STRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DICTIONARY DESCRIBING
            var personel_list = new Dictionary<int, personel>()
            {
                {120,new personel("mehmet","bakırcı",10000) },
                 {130,new personel("hasan","demir",250000) },
                  {150,new personel("ali","candan",100000) },
            };

            personel_list.Add(50, new personel("ali","dönmez",5000));
            foreach (var p in personel_list)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
        }

        private static void DICTIONARY_STRUCTURE()
        {
            var il_code = new Dictionary<int, string>()
            {
                {01,"adana" },
                {34,"sitanbul" },
                {06,"ankara" },
                {35,"izmir" },

            };
            // ADDING
            il_code.Add(50, "nevşehir");
            il_code.Add(25, "erzurum");
            il_code.Add(51, "niğde");

            //CONTAINS KEY
            if (!il_code.ContainsKey(40))
            {
                Console.WriteLine("kırşehir codu tanımlı değildir...");
                il_code.Add(40, "kırşehir");
                Console.WriteLine("kırşehir eklenmiştir..");
            }
            //CONTAINS VALUE
            if (!il_code.ContainsValue("konya"))
            {
                Console.WriteLine("konya codu tanımlı değildir...");
                il_code.Add(42, "konya");
                Console.WriteLine("konya eklenmiştir..");
            }
            foreach (var s in il_code)
            {
                Console.WriteLine(s);
            }
        }
    }
}
