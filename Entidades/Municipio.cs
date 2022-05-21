namespace examen.NET.Entidades
{
    public class Municipio
    {
        public int Id { get; set; }
        public string NombreMunicipio { get; set; }

        public static List<Municipio> GetMunicipios()
        {
            return new List<Municipio>
            {

                new Municipio
                {
                    Id = 1,
                    NombreMunicipio = "Cadiz"
                },
                new Municipio
                {
                    Id = 2,
                    NombreMunicipio = "Malaga"
                },
                new Municipio
                {
                    Id = 3,
                    NombreMunicipio = "Sevilla"
                },
                new Municipio
                {
                    Id = 4,
                    NombreMunicipio = "Almeria"
                }

            };
        }

    }
}
