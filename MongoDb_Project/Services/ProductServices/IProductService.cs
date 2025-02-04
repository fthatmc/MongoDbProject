﻿using MongoDb_Project.Dtos.ProductDtos;

namespace MongoDb_Project.Services.ProductServices
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDto createUpdateDto);
        Task UpdateProductAsync(UpdateProductDto updateUpdateDto);
        Task DeleteProductAsync(string id);
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
        Task<List<ResultProductWithCategoryDto>> GetProductWithCategoryAsync();
        Task<List<ResultProductWithCategoryDto>> GetProductWithCategoryExcelListAsync();
    }
}
