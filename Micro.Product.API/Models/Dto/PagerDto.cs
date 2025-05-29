namespace Micro.Product.API.Models.Dto
{
    public record PagerDto(int Page = 1, int RecordsPerPage = 10)
    {
        private const int MaxRecordPerPage = 50;
        public int Page { get; set; } = Math.Max(1, Page);
        ///<summary>
        ///clamp me permite identificar un valor valido entre 1 y el valor
        ///</summary>

        public int RecordsPerPage { get; init; } = Math.Clamp(RecordsPerPage, 1, MaxRecordPerPage);
    }
}
