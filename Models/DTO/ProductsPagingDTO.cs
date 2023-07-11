namespace FuenAPI.Models.DTO
{
    public class ProductsPagingDTO
    {
        public int TotalPages { get; set; }
        public List<ProductDTO>? ProductsResult { get; set; }
    }
}
