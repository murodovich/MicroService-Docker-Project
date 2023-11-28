namespace Tourism_Infrastructure.Services;
public interface IBaseservice<Tmodel,TmodelDto> where TmodelDto : class
{
    public ValueTask<bool> Create(TmodelDto dto);
    public ValueTask<bool> Update(int id, TmodelDto dto);
    public ValueTask<bool> Delete(int id);
    public ValueTask<List<Tmodel>> GetAll();
    public ValueTask<Tmodel> GetById(int id);

}
