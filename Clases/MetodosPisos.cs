using examen.NET.Entidades;
using examen.NET.Interfaces;

namespace examen.NET.Clases
{
    public class MetodosPisos : IMetodosPisos
    {
        public List<Piso> GetPisosJoin()
        {
            List<Piso> listaPisos = Piso.GetPisos();
            List<Municipio> listaMunicipios = Municipio.GetMunicipios();

            var query1 =
                from p in listaPisos
                join mun in listaMunicipios on p.MunicipioId equals mun.Id
                select new Piso
                {
                   Tamaño = p.Tamaño,
                    Nombre = p.Nombre,
                    NumHabitaciones = p.NumHabitaciones,
                    NumBaños = p.NumBaños,
                    NumPlanta = p.NumPlanta,
                    MunicipioId = mun.Id,
                    

                };

            
                return listaPisos;
            
        }
    }
}
