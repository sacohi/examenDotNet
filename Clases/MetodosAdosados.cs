using examen.NET.Entidades;
using examen.NET.Interfaces;

namespace examen.NET.Clases
{
    public class MetodosAdosados : IMetodosAdosados
    {
        public List<Adosado> GetAdosadosJoin()
        {
            List<Adosado> listaAdosados = Adosado.GetAdosados();
            List<Municipio> listaMunicipios = Municipio.GetMunicipios();

            var query1 =
                from a in listaAdosados
                join mun in listaMunicipios on a.MunicipioId equals mun.Id

                select new Adosado
                {
                    Tamaño = a.Tamaño,
                    Nombre = a.Nombre,
                    NumHabitaciones = a.NumHabitaciones,
                    NumBaños = a.NumBaños,
                    Piscina = a.Piscina,
                    MunicipioId = mun.Id,
                    //NombreMunicipio = mun.NombreMunicipio


                };


            return listaAdosados;

        }
    }
}
