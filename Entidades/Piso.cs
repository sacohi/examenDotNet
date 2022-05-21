namespace examen.NET.Entidades
{
    public class Piso: Vivienda
    {
        public int NumPlanta { get; set; }

        public static List<Piso> GetPisos()
        {
            return new List<Piso>
            {
                new Piso
                {
                    Tamaño = 90,
                    Nombre = "Piso1",
                    NumHabitaciones = 2,
                    NumBaños = 2,
                    NumPlanta = 2,
                    MunicipioId = 1
                },
                new Piso
                {
                    Tamaño = 105,
                    Nombre = "Piso2",
                    NumHabitaciones = 4,
                    NumBaños = 2,
                    NumPlanta = 1,
                    MunicipioId = 2
                },
                new Piso
                {
                    Tamaño = 85,
                    Nombre = "Piso3",
                    NumHabitaciones = 3,
                    NumBaños = 2,
                    NumPlanta = 3,
                    MunicipioId = 3
                },
                new Piso
                {
                    Tamaño = 150,
                    Nombre = "Piso4",
                    NumHabitaciones = 5,
                    NumBaños = 2,
                    NumPlanta = 4,
                    MunicipioId = 4
                }

            };
        }

    }
}
