namespace examen.NET.Entidades
{
    public class Adosado: Vivienda
    {
        public bool Piscina { get; set; }

        public static List<Adosado> GetAdosados()
        {
            return new List<Adosado>()
            {
                new Adosado
                {
                    Tamaño = 160,
                    Nombre = "Adosado1",
                    NumHabitaciones = 3,
                    NumBaños = 3,
                    Piscina = true,
                    MunicipioId =1
                },
                new Adosado
                {
                    Tamaño = 160,
                    Nombre = "Adosado2",
                    NumHabitaciones = 4,
                    NumBaños = 2,
                    Piscina = false,
                    MunicipioId = 2
                },
                new Adosado
                {
                    Tamaño = 160,
                    Nombre = "Adosado3",
                    NumHabitaciones = 5,
                    NumBaños = 3,
                    Piscina = true,
                    MunicipioId = 3
                },
                new Adosado
                {
                    Tamaño = 160,
                    Nombre = "Adosado4",
                    NumHabitaciones = 5,
                    NumBaños = 2,
                    Piscina = false,
                    MunicipioId = 4
                },
            };
        }
    }
}
