namespace Demo_Indexeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudyRoom room_pixel = new StudyRoom() { Name = "Pixel" };

            room_pixel.InitDictionnary();

            Student s1 = new Student() { FirstName = "Vincent", LastName = "Crispiels" };
            Student s2 = new Student() { FirstName = "Manuel", LastName = "Randour" };
            Student s3 = new Student() { FirstName = "François", LastName = "Dumont" };
            Student s4 = new Student() { FirstName = "Adrien", LastName = "Legrain" };
            Student s5 = new Student() { FirstName = "Cédric", LastName = "Bouvier" };
            Student s6 = new Student() { FirstName = "Ayrton", LastName = "Scorniciel" };
            Student s7 = new Student() { FirstName = "Jean-François", LastName = "Mbenda" };
            Student s8 = new Student() { FirstName = "François", LastName = "Maetens" };

            room_pixel["FORMA1101"] = s1;
            room_pixel["FORMA1107"] = s2;
            room_pixel["FORMA1108"] = s3;
            room_pixel["FORMA1109"] = s4;
            room_pixel["FORMA1110"] = s5;
            room_pixel["FORMA1113"] = s6;
            room_pixel["FORMA1116"] = s7;
            room_pixel["FORMA1118"] = s8;

            Random RNG = new Random();
            int idRandom = RNG.Next(20) + 1;
            string computerIdRandom = $"FORMA{1100 + idRandom}";
            Student studentRandom = room_pixel[computerIdRandom];
            if(studentRandom is null)
            {
                Console.WriteLine($"Il n'y a pas d'étudiant connecté sur l'ordinateur numéro {computerIdRandom}...");
            }
            else
            {
            Console.WriteLine($"L'étudiant connecté sur l'ordinateur numéro {computerIdRandom} " +
                $"est : {studentRandom.LastName} {studentRandom.FirstName} ");
            }
        }
    }
}
