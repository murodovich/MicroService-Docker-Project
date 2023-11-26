﻿namespace Appartment_Infrastructure.Services;
public interface IBaseService<TModel, TView> where TModel : class
{
    public ValueTask<int> CreateAsync(TView model);
    public ValueTask<int> UpdateAsync(int Id, TView model);
    public ValueTask<int> DeleteAsync(int Id);
    public ValueTask<TModel> GetByIdAsync(int Id);
    public ValueTask<List<TModel>> GetAllAsync();
}
