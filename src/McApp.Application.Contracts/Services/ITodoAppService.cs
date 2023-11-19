using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using McApp.Dto.TodoItem;
using Volo.Abp.Application.Services;

namespace McApp.Services
{
    public interface ITodoAppService : IApplicationService
    {
        Task<List<TodoItemDto>> GetListAsync();
        Task<TodoItemDto> CreateAsync(string text);
        Task DeleteAsync(Guid id);


    }
}
