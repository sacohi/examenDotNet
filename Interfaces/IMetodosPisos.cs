using examen.NET.Entidades;

namespace examen.NET.Interfaces
{
    public interface IMetodosPisos
    {

        List<PisoExtendido> GetPisosJoin();
        List<PisoExtendido> GetPisosRoom();

        List<PisoExtendido> GetPisosSize();

        List<PisoExtendido> GetPisosCadiz();
       
    }
}
