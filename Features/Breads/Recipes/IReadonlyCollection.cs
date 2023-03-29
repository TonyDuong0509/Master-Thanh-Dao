namespace Store.Features.Breads
{
    public interface IReadonlyCollection<T>
    {
        IReadonlyCollection<T> AsReadOnly();
    }
}