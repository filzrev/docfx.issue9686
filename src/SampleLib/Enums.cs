// This file is copied from `https://github.com/dotnet/docfx/issues/9686#issuecomment-1934516398`

namespace Examples
{
    /// <summary>
    /// An example enum with values assigned to most, but not all fields.
    /// </summary>
    public enum EnumWithValue
    {
        /// <summary>
        /// The first element that has index 0.
        /// </summary>
        Zeroeth = 0,
        /// <summary>
        /// The second element that has index 1.
        /// </summary>
        First = 1,
        /// <summary>
        /// This item has a remarks element.
        /// </summary>
        /// <remarks>Remarks are shown for enum members below the summary.
        /// Both the summary and the remarks are nested in a table cell. (Or
        /// used to be -- doesn't appear to be working.)
        /// 
        /// * a Markdown list
        /// * in a remarks block
        /// * of an enum member
        /// </remarks>
        Second = 2,
        /// <summary>
        /// This one is not assigned a value.
        /// </summary>
        NoValue,
        /// <summary>
        /// Eponymously four.
        /// </summary>
        Fourth = 4,
        /// <summary>
        /// Terminal five.
        /// </summary>
        /// <value>5</value>
        Last = 5
    }

    /// <summary>
    /// An example enum with no values assigned.
    /// </summary>
    public enum EnumSansValue
    {
        /// <summary>
        /// Defined first.
        /// </summary>
        None,
        /// <summary>
        /// Defined second.
        /// </summary>
        One,
        /// <summary>
        /// Defined third.
        /// </summary>
        Some,
        /// <summary>
        /// Defined fourth.
        /// </summary>
        Few,
        /// <summary>
        /// Defined fifth (last).
        /// </summary>
        Last
    }

    /// <summary>
    /// An example enum with no values assigned.
    /// </summary>
    public enum EnumWithDifferentNumberingAndType : long
    {
        /// <summary>
        /// Defined first, value = -255.
        /// </summary>
        None = -255,
        /// <summary>
        /// Defined second, value = 767.
        /// </summary>
        SevenAndFriends = 767,
        /// <summary>
        /// Defined third, value = -23.
        /// </summary>
        WildSwingBackToNegative =-23,
        /// <summary>
        /// Defined fourth, value = 999999.
        /// </summary>
        AlmostAMillion = 999999,
        /// <summary>Defined fifth, value = `SevenAndFriends`.</summary>
        SameAsSevenAndFriends = SevenAndFriends,
        /// <summary>
        /// Defined sixth (last), no value assigned.
        /// </summary>
        Last,
    }
}