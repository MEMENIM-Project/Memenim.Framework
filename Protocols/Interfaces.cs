namespace Memenim.Framework.Protocols
{
    public interface IUserProtocol
    {
        string Name { get; }
        IUserProtocolSchema Schema { get; }

        bool Register();

        bool Exists();
    }
}
