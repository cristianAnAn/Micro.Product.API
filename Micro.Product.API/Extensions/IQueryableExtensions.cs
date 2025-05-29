using Micro.Product.API.Models.Dto;

namespace Micro.Product.API.Extensions
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paginar<T>(this IQueryable<T> queryable, PagerDto pagerDto)
        {
            return queryable
                .Skip((pagerDto.Page - 1) * pagerDto.RecordsPerPage) //esatblece el numero de pagina que se va a saltar
                .Take(pagerDto.RecordsPerPage); //tomamos la cantidad de registros devueltos en la paginacion.

        }
    }
}
