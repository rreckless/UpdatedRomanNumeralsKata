namespace TestRomanNumeralsKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UpdateRomanNumeralsKata;

[TestClass]
public class ConvertToRomanNumeralsTests
{
    [TestMethod]
    [DataRow(1, "I")]
    [DataRow(5, "V")]
    [DataRow(10, "X")]
    [DataRow(50, "L")]
    [DataRow(100, "C")]
    [DataRow(500, "D")]
    [DataRow(1000, "M")]
    [DataRow(2,"II")]
    [DataRow(3,"III")]
    [DataRow(4,"IV")]
    [DataRow(6,"VI")]
    [DataRow(7,"VII")]
    [DataRow(8,"VIII")]
    [DataRow(9,"IX")]
    [DataRow(14, "XIV")]
    [DataRow(20, "XX")]
    [DataRow(30, "XXX")]
    [DataRow(40, "XL")]
    [DataRow(49, "XLIX")]
    [DataRow(99, "XCIX")]
    [DataRow(499, "CDXCIX")]
    [DataRow(888, "DCCCLXXXVIII")]
    [DataRow(999, "CMXCIX")]
    [DataRow(2022, "MMXXII")]
    [DataRow(3999, "MMMCMXCIX")]
    public void ConvertToRomanNumerals(int value, string numeral)
    {
        var rnc = new RomanNumeralConverter();
        var answer = rnc.ConvertToRomanNumerals(value);
        Assert.AreEqual(numeral, answer);
    }

    
    [TestMethod]
    public void ConvertToRomanNumerals_Zero_ThrowsArgumentOutOfRangeException()
    {
        var rnc = new RomanNumeralConverter();
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => rnc.ConvertToRomanNumerals(0));
    }

    [TestMethod]
    public void ConvertToRomanNumerals_Negative_ThrowsArgumentOutOfRangeException()
    {
        var rnc = new RomanNumeralConverter();
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => rnc.ConvertToRomanNumerals(-5));
    }
}
