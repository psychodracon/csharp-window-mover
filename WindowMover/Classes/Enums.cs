using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowMover.Classes
{
    public enum WindowCompareTemplate
    {
        [Description("Zgadza się")]
        Match,
        [Description("Zaczyna się")]
        BeginWith,
        [Description("Kończy się")]
        EndWith,
        [Description("Zawiera")]
        Contains
    }

    public enum EditorMode
    {
        [Description("Nowy")]
        New,
        [Description("Modyfikuj")]
        Edit
    }

    public static class Enums
    {
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}
