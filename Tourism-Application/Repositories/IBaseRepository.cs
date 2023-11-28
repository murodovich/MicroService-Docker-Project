namespace Tourism_Application.Repositories
{
    public interface IBaseRepository<Tmodel,TView> where Tmodel : class
    {
        public ValueTask<bool> CreateAsync(Tmodel model);
        public ValueTask<bool> UpdateAsync(int id,Tmodel model);
        public ValueTask<bool> DeleteAsync(int id);
        public ValueTask<Tmodel> GetByIdAsync(int id);
        public ValueTask<List<Tmodel>> GetAllAsync();

    }
}
