using System.Runtime.InteropServices;

namespace Memenim.Framework.Native
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    internal struct IpcBusMessage
    {
        public string Name { get; set; }
        public byte[] Content { get; set; }
        public IpcBusContentType ContentType { get; set; }
        public bool RestoreWindow { get; set; }



        public IpcBusMessage(string name,
            byte[] content, IpcBusContentType type,
            bool restoreWindow = true)
        {
            Name = name;
            Content = content;
            ContentType = type;
            RestoreWindow = restoreWindow;
        }



        public string GetStringUtf8()
        {
            if (ContentType == IpcBusContentType.StringUtf8)
                return Encoding.UTF8.GetString(Content);

            return null;
        }
    }
}
