using examen.NET.Entidades;

namespace examen.NET.Interfaces
{
    public interface IMetodosAdosados
    {
        List<AdosadoExtendido> GetAdosadosJoin();
        List<AdosadoExtendido> GetAdosadosRoom();

        List<AdosadoExtendido> GetAdosadosSize();

        List<AdosadoExtendido> GetAdosadosCadiz();

        List<AdosadoExtendido> GetAdosadosPool();
    }
}
