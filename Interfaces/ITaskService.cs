
using TaskManagementAPI.DTOs;
using TaskManagementAPI.Models;

namespace TaskManagementAPI.Interfaces
{
    public interface ITaskService
    {
        Task<List<TaskItem>> GetAllAsync();

        Task<TaskItem?> GetByIdAsync(int id);

        Task<TaskItem> CreateAsync(CreateTaskDto dto);

        Task<TaskItem?> UpdateAsync(int id, UpdateTaskDto dto);

        Task<bool> DeleteAsync(int id);
    }
}
