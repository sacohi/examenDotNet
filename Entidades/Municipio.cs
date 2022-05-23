namespace examen.NET.Entidades
{
    public class Municipio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public static List<Municipio> GetMunicipios()
        {
            return new List<Municipio>
            {

                new Municipio
                {
                    Id = 1,
                    Nombre = "Cadiz"
                },
                new Municipio
                {
                    Id = 2,
                    Nombre = "Malaga"
                },
                new Municipio
                {
                    Id = 3,
                    Nombre = "Sevilla"
                },
                new Municipio
                {
                    Id = 4,
                    Nombre = "Almeria"
                }

            };
        }

    }
}
