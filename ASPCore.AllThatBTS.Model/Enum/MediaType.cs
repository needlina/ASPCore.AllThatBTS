using System.ComponentModel;
using System.Reflection;

namespace ASPCore.AllThatBTS.Enum
{
    public enum MediaType
    {
        [Description("O")]
        OfficialTwitter,
        [Description("T")]
        Twitter,
        [Description("Y")]
        Youtube,
        [Description("I")]
        Instagram
    }
}