using MongoDb_Project.Dtos.CustomerDtos;

namespace MongoDb_Project.Services.CustomerServices
{
    public interface ICustomerService
    {
        Task<List<ResultCustomerDto>> GetAllCustomerAsync();
        Task CreateCustomerAsync(CreateCustomerDto createUpdateDto);
        Task UpdateCustomerAsync(UpdateCustomerDto updateUpdateDto);
        Task DeleteCustomerAsync(string id);
        Task<GetByIdCustomerDto> GetByIdCustomerAsync(string id);
    }
}
