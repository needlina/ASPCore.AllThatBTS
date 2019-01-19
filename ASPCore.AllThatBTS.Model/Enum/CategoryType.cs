using System.ComponentModel;

namespace ASPCore.AllThatBTS.Enum
{
    public enum CategoryType
    {
        [Description("Q")]
        Question,
        [Description("F")]
        Free,
        [Description("I")]
        Image,
        [Description("T")]
        Tip
    }
}