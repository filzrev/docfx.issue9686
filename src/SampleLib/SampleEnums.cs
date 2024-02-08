using namespace SampleLib;

/// <summary>
/// Sample enum1
/// </summary>
public enum SampleEnum1
{
    None,
    Enum1,
    Enum2,
}

/// <summary>
/// Sample enum2 (with explicit value assignment)
/// </summary>
public enum SampleEnum2
{
    None = 0,
    
    /// <summary>
    /// Description1for EnumB.
    </summary>
    EnumB = 0x01
    
    /// <summary>
    /// Description1for EnumB.
    /// </summary>
    EnumD = 0x02,
    
    /// <summary>
    /// Description1for EnumA.
    /// </summary>
    EnumA = 0x04,
}