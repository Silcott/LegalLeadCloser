using LLC.Application.Features.Products.Commands.AddEdit;
using LLC.Application.Features.Products.Queries.GetAllPaged;
using LLC.Application.Requests.Catalog;
using LLC.Client.Infrastructure.Extensions;
using LLC.Shared.Wrapper;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace LLC.Client.Infrastructure.Managers.Catalog.Product
{
    public class ProductManager : IProductManager
    {
        private readonly HttpClient _httpClient;

        public ProductManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<int>> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{Routes.ProductsEndpoints.Delete}/{id}");
            return await response.ToResult<int>();
        }

        public async Task<string> ExportToExcelAsync()
        {
            var response = await _httpClient.GetAsync(Routes.ProductsEndpoints.Export);
            var data = await response.Content.ReadAsStringAsync();
            return data;
        }

        public async Task<IResult<string>> GetProductImageAsync(int id)
        {
            var response = await _httpClient.GetAsync(Routes.ProductsEndpoints.GetProductImage(id));
            return await response.ToResult<string>();
        }

        public async Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request)
        {
            var response = await _httpClient.GetAsync(Routes.ProductsEndpoints.GetAllPaged(request.PageNumber, request.PageSize));
            return await response.ToPaginatedResult<GetAllPagedProductsResponse>();
        }

        public async Task<IResult<int>> SaveAsync(AddEditProductCommand request)
        {
            var response = await _httpClient.PostAsJsonAsync(Routes.ProductsEndpoints.Save, request);
            return await response.ToResult<int>();
        }
    }
}