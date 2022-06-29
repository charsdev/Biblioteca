namespace Biblioteca.Interfaces
{
    public interface ICollectionDataContract
    {
        string File { get; }
        void Update();
        void Clear();
    }
}