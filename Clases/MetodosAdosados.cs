using examen.NET.Entidades;
using examen.NET.Interfaces;

namespace examen.NET.Clases
{
    public class MetodosAdosados : IMetodosAdosados
    {
            List<Adosado> listaAdosados = Adosado.GetAdosados();
            List<Municipio> listaMunicipios = Municipio.GetMunicipios();

        public List<AdosadoExtendido> GetAdosadosJoin()
        {

            var query1 =
                from a in listaAdosados
                join mun in listaMunicipios on a.MunicipioId equals mun.Id

                select new AdosadoExtendido
                {
                    Tamaño = a.Tamaño,
                    Nombre = a.Nombre,
                    NumHabitaciones = a.NumHabitaciones,
                    NumBaños = a.NumBaños,
                    Piscina = a.Piscina,
                    MunicipioId = mun.Id,
                    NombreMunicipioAdosado = mun.Nombre


                };

            List<AdosadoExtendido> lista1 = query1.ToList();

            return lista1;

        }



        public List<AdosadoExtendido> GetAdosadosCadiz()
        {
        var query2 =
                from a in listaAdosados
                join mun in listaMunicipios on a.MunicipioId equals mun.Id
                where mun.Nombre == "Cadiz"
                select new AdosadoExtendido
                {
                    Nombre = a.Nombre,
                    NombreMunicipioAdosado = mun.Nombre


                };
            List<AdosadoExtendido> lista2 = query2.ToList();

            return lista2;

        }

        public List<AdosadoExtendido> GetAdosadosRoom()
        {
            var query3 =
              from a in listaAdosados
              where a.NumHabitaciones >= 4
              select new AdosadoExtendido
              {
                  Nombre = a.Nombre,
                  NumHabitaciones = a.NumHabitaciones
              };

            List<AdosadoExtendido> lista3 = query3.ToList();

            return lista3;
        }

        public List<AdosadoExtendido> GetAdosadosPool()
        {

            var query4 =
              from a in listaAdosados
              join mun in listaMunicipios on a.MunicipioId equals mun.Id
              where a.Piscina == true
              select new AdosadoExtendido
              {

                  Nombre = a.Nombre,
                  NombreMunicipioAdosado = mun.Nombre


              };





            List<AdosadoExtendido> lista4 = query4.ToList();

            return lista4;

        }



       


        public List<AdosadoExtendido> GetAdosadosSize()
        {

            var query5 =
               from a in listaAdosados
               where a.Tamaño >= 170
               select new AdosadoExtendido
               {
                   Tamaño = a.Tamaño,
                   Nombre = a.Nombre

               };

            List<AdosadoExtendido> lista5 = query5.ToList();

            return lista5;

        }
    }
}
