using System.Reflection;
using System.Windows.Controls.Primitives;

namespace Memenim.Framework.Extensions
{
    public static class ComboBoxExtensions
    {
        private static readonly FieldInfo PopupField;



        static ComboBoxExtensions()
        {
            // Hack

            PopupField = typeof(ComboBox).GetField("_dropDownPopup",
                BindingFlags.Instance | BindingFlags.NonPublic);
        }



        public static Popup GetPopup(this ComboBox source)
        {
            // Hack

            if (PopupField?.GetValue(source) is Popup popup)
                return popup;

            return null;
        }
    }
}
