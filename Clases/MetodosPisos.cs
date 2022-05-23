using examen.NET.Entidades;
using examen.NET.Interfaces;

namespace examen.NET.Clases
{
    public class MetodosPisos : IMetodosPisos
    {
         List<Piso> listaPisos = Piso.GetPisos();
         List<Municipio> listaMunicipios = Municipio.GetMunicipios();
        public List<PisoExtendido> GetPisosJoin()
        {

            var query1 =
                from p in listaPisos
                join mun in listaMunicipios on p.MunicipioId equals mun.Id
                select new PisoExtendido
                {
                    Tamaño = p.Tamaño,
                    Nombre = p.Nombre,
                    NumHabitaciones = p.NumHabitaciones,
                    NumBaños = p.NumBaños,
                    NumPlanta = p.NumPlanta,
                    MunicipioId = mun.Id,
                    NombreMunicipioPiso = mun.Nombre

                };

            List<PisoExtendido> lista1 = query1.ToList();
            return lista1;
        }


        public List<PisoExtendido> GetPisosCadiz()
        {

            var query2 =

                 from p in listaPisos
                 join mun in listaMunicipios on p.MunicipioId equals mun.Id
                 where mun.Nombre == "Cadiz"
                 select new PisoExtendido
                 {

                     Nombre = p.Nombre,
                     NombreMunicipioPiso = mun.Nombre

                 };



            List<PisoExtendido> lista2 = query2.ToList();
            return lista2;
        }


        

        public List<PisoExtendido> GetPisosRoom()
        {

            var query3 =

                    from p in listaPisos
                    where p.NumHabitaciones >= 3
                    select new PisoExtendido
                    {

                        Nombre = p.Nombre,
                        NumHabitaciones = p.NumHabitaciones

                    };

            List<PisoExtendido> lista3 = query3.ToList();
            return lista3;


        }


        public List<PisoExtendido> GetPisosSize()
        {
            var query4 =

               from p in listaPisos
               where p.Tamaño >= 105
               select new PisoExtendido
               {
                   Tamaño = p.Tamaño,
                   Nombre = p.Nombre

               };
            List<PisoExtendido> lista4 = query4.ToList();
            return lista4;

        }

    }
    }
