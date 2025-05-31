using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carvo.Business_Logic_Layer.IServices;
using Carvo.Data_Access_Layer.Entities;
using Carvo.Data_Access_Layer.Repository.IGenericRepositories;

namespace Carvo.Business_Logic_Layer.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IGenericRepository<Category, int> _categoryRepository;

        public CategoryService(IGenericRepository<Category, int> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<IEnumerable<Category>> GetAllCategoryAsync()
        {
            return _categoryRepository.GetAllAsync();
        }

        public Task<Category?> GetCategoryByIdAsync(int id)
        {
            return _categoryRepository.GetByIdAsync(id);
        }

        public async Task<Category> AddCategoryAsync(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            category.CreatedAt = DateTime.UtcNow;
            var addedCategory = await _categoryRepository.AddAsync(category);
            return addedCategory;
        }

        public async Task<Category> UpdateCategoryAsync(Category category)
        {
            if (category == null)
                throw new ArgumentNullException(nameof(category));

            var existingCategory = await _categoryRepository.GetByIdAsync(category.Id);
            if (existingCategory == null)
                throw new KeyNotFoundException($"Category with ID {category.Id} not found.");

            existingCategory.Name = category.Name;
            existingCategory.Description = category.Description;

            var updatedCategory = await _categoryRepository.UpdateAsync(existingCategory);
            return updatedCategory;
        }
       
        public async Task<bool> DeleteCategoryAsync(int id)
        {
            return await _categoryRepository.DeleteAsync(id);
        }
    }
}
