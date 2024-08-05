using System.Linq.Expressions;

namespace MagicVilla_API.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T : class 
        //hacemos que sea generica para que trabaje con cualquier entidad que le enviemos
    {
        Task Crear(T entidad);

        Task<List<T>> ObtenerTodos(Expression<Func<T,bool>>? filtro = null);

        Task<T> Obtener(Expression<Func<T, bool>> filtro = null, bool tracked = true);

        Task Remover(T entidad);

        Task Grabar();
    }
}
