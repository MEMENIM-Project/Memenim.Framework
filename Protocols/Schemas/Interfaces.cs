namespace Memenim.Framework.Protocols.Schemas
{
    public interface IUserProtocolSchema
    {
        string Name { get; }

        bool ParseUri(Uri uri);
    }
}
