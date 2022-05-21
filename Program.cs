using examen.NET.Clases;
using examen.NET.Entidades;

namespace examen.NET;

class Program
{
    static void Main(string[] args)
    {
       
        MetodosPisos nuevoMetodosPisos = new MetodosPisos();
        Municipio newMunicipio = new Municipio();

        List<Piso> listaPisos = nuevoMetodosPisos.GetPisosJoin();
        List<Municipio> listaMunicipios = Municipio.GetMunicipios();

        Console.WriteLine();
        Console.WriteLine("--------------------------EJERCICIO NUM.1------------------");
        Console.WriteLine();
        foreach (Municipio municipio in listaMunicipios)
        {
            Console.WriteLine($"El municipio es {municipio.NombreMunicipio}");
        }

        Console.WriteLine();
        Console.WriteLine("--------------------------EJERCICIO NUM.2------------------");
        Console.WriteLine();

        foreach (Piso piso in listaPisos)
        {
            Console.WriteLine($"El {piso.Nombre} tiene {piso.Tamaño}m2, {piso.NumHabitaciones} habitaciones, {piso.NumBaños} baños, se encuenetra en la planta {piso.NumPlanta} y su municipio es {piso.MunicipioId}");
        }


        MetodosAdosados nuevoMetodosAdosados = new MetodosAdosados();

        List<Adosado> listaAdosados = nuevoMetodosAdosados.GetAdosadosJoin();

        Console.WriteLine();
        Console.WriteLine("--------------------------EJERCICIO NUM.3------------------");
        Console.WriteLine();

        foreach (Adosado adosado in listaAdosados)
        {
            Console.WriteLine($"El {adosado.Nombre} tiene {adosado.Tamaño}m2, {adosado.NumHabitaciones} habitaciones, {adosado.NumBaños} baños, tiene pisicina = {adosado.Piscina}  y su municipio es {adosado.MunicipioId}");
        }


    }
}