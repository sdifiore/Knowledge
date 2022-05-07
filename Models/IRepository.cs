namespace Knowledge.Models
{
    public interface IRepository
    {
        IEnumerable<Framework> GetFrameworks();
    }
}
