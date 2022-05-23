using examen.NET.Clases;
using examen.NET.Entidades;

namespace examen.NET;

class Program
{
    static void Main(string[] args)
    {
       
        MetodosPisos nuevoMetodosPisos = new MetodosPisos();

        Municipio newMunicipio = new Municipio();

        List<PisoExtendido> listaPisos = nuevoMetodosPisos.GetPisosJoin();

        List<Municipio> listaMunicipios = Municipio.GetMunicipios();

        MetodosAdosados nuevoMetodosAdosados = new MetodosAdosados();

        List<AdosadoExtendido> listaAdosados = nuevoMetodosAdosados.GetAdosadosJoin();

       



        //EJERCICIO 1: SACAR POR PANTALLA UN LISTADO DE LOS MUNICIPIOS

        Console.WriteLine();
        Console.WriteLine("------------------------*** Ejercicio Num.1: Sacar por pantalla un listado de los municipios ***---------------");
        Console.WriteLine();
        foreach (Municipio municipio in listaMunicipios)
        {
            Console.WriteLine($"El municipio con Id: {municipio.Id} es {municipio.Nombre}.");
        }



        //EJERCICIO 2: SACAR UN LISTADO DE PISOS Y EL MUNICIPIO AL QUE PERTENECEN

        Console.WriteLine();
        Console.WriteLine("------------------------*** Ejercicio Num.2: Sacar un listado de pisos y el municipio al que pertenecen ***---------------");
        Console.WriteLine();

        foreach (PisoExtendido piso in listaPisos)
        {
            Console.WriteLine($"El {piso.Nombre} tiene {piso.Tamaño}m2, {piso.NumHabitaciones} habitaciones, {piso.NumBaños} baños, se encuenetra en la planta {piso.NumPlanta} y su municipio es {piso.NombreMunicipioPiso}.");
        }


      

        //EJERCICIO 3: SACAR UN LISTADO DE ADOSADOS Y EL MUNICIPIO AL QUE PERTENECEN

        Console.WriteLine();
        Console.WriteLine("------------------------*** Ejercicio Num.3: Sacar un listado de Adosados y el municipio al que pertenecen ***---------------");
        Console.WriteLine();

        foreach (AdosadoExtendido adosado in listaAdosados)
        {
            Console.WriteLine($"El {adosado.Nombre} tiene {adosado.Tamaño}m2, {adosado.NumHabitaciones} habitaciones, {adosado.NumBaños} baños, tiene pisicina = {adosado.Piscina}  y su municipio es {adosado.NombreMunicipioAdosado}.");
        }


        //EJERCICIO 4: SACAR UN LISTADO DE PISOS FILTRANDO POR NOMBRE DE MUNICIPIO --> CADIZ

        List<PisoExtendido> listaPisosCadiz = nuevoMetodosPisos.GetPisosCadiz();

        Console.WriteLine();
        Console.WriteLine("------------------------*** Ejercicio Num.4: Sacar un listado de pisos filtrando por nombre de Municipio -> Cadiz ***---------------");
        Console.WriteLine();

        foreach (PisoExtendido piso in listaPisosCadiz)
        {
            Console.WriteLine($"El {piso.Nombre} se encuentra en el municipio de {piso.NombreMunicipioPiso}.");
        }


        //EJERCICIO 5: SACAR UN LISTADO DE ADOSADOS FILTRANDO POR NOMBRE DE MUNICIPIO --> CADIZ

        List<AdosadoExtendido> listaAdosadosCadiz = nuevoMetodosAdosados.GetAdosadosCadiz();

        Console.WriteLine();
        Console.WriteLine("------------------------*** Ejercicio Num.5: Sacar un listado de adosados filtrado por nombre de municipio -> Cadiz ***---------------");
        Console.WriteLine();

        foreach (AdosadoExtendido adosado in listaAdosadosCadiz)
        {
            Console.WriteLine($"El {adosado.Nombre} se encuentra en el municipio de {adosado.NombreMunicipioAdosado}.");
        }

        //EJERCICIO 6: SACAR UN LISTADO DE PISOS QUE TENGAN 3 O MAS HABITACIONES

        List<PisoExtendido> listaPisosRoom = nuevoMetodosPisos.GetPisosRoom();

        Console.WriteLine();
        Console.WriteLine("------------------------***Ejercicio Num.6: Sacar un listado de pisos que tengan 3 o mas habitaciones***---------------");
        Console.WriteLine();

        foreach (PisoExtendido piso in listaPisosRoom)
        {
            Console.WriteLine($"El {piso.Nombre} tiene {piso.NumHabitaciones} habitaciones.");
        }



        //EJERCICIO 7: SACAR UN LISTADO DE ADOSADOS QUE TENGAN 4 O MAS HABITACIONES

        List<AdosadoExtendido> listaAdosadosRoom = nuevoMetodosAdosados.GetAdosadosRoom();

        Console.WriteLine();
        Console.WriteLine("------------------------*** Ejercicio Num.7: Sacar un listado de adosados que tengan 4 o mas habitaciones ***---------------");
        Console.WriteLine();

        foreach (AdosadoExtendido adosado in listaAdosadosRoom)
        {
            Console.WriteLine($"El {adosado.Nombre} tiene {adosado.NumHabitaciones} habitaciones.");
        }


        //EJERCICIO 8: SACAR UN LISTADO DE ADOSADOS QUE TENGAN PISCINA

        List<AdosadoExtendido> listaAdosadosPool = nuevoMetodosAdosados.GetAdosadosPool();

        Console.WriteLine();
        Console.WriteLine("------------------------*** Ejercicio Num.8: Sacar un listado de Adosados que tengan piscina ***---------------");
        Console.WriteLine();

        foreach (AdosadoExtendido adosado in listaAdosadosPool)
        {
            Console.WriteLine($"El {adosado.Nombre} en el municipio {adosado.NombreMunicipioAdosado} tiene piscina.");
        }



        //EJERCICIO 9: SACAR UN LISTADO DE PISOS QUE TENGAN 105 O MAS METROS CUADRADOS

        List<PisoExtendido> listaPisosSize = nuevoMetodosPisos.GetPisosSize();

        Console.WriteLine();
        Console.WriteLine("------------------------*** Ejercicio Num.9: Sacar un listado de pisos que tengan 105 o mas metros cuadrados ***---------------");
        Console.WriteLine();

        foreach (PisoExtendido piso in listaPisosSize)
        {
            Console.WriteLine($"El {piso.Nombre} tiene un tamaño de {piso.Tamaño}m2.");
        }




        //EJERCICIO 10: SACAR UN LISTADO DE ADOSADOS QUE TENGAN 170 O MAS METROS CUADRADOS

        List<AdosadoExtendido> listaAdosadosSize = nuevoMetodosAdosados.GetAdosadosSize();

        Console.WriteLine();
        Console.WriteLine("------------------------*** Ejercicio Num.10: Sacar un listado de adosados que tengan 170 o mas metros cuadrados ***---------------");
        Console.WriteLine();

        foreach (AdosadoExtendido adosado in listaAdosadosSize)
        {
            Console.WriteLine($"El {adosado.Nombre} tiene un tamaño de {adosado.Tamaño}m2.");
        }







    }
}