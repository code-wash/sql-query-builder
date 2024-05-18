namespace CodeWash.SqlQueryBuilder.Tests.RawQueryBuilderTests;

public class SelectColumnsTests
{
    private RawQueryBuilder _rawQueryBuilder;

    [SetUp]
    public void Setup()
    {
        _rawQueryBuilder = new RawQueryBuilder("Table1", "t1");
    }

    [Test]
    public void SelectColumns_Default_IsStar()
    {
        Assert.That(_rawQueryBuilder.SelectColumns, Is.EqualTo("*"), "default value of SelectColumns should be *");
    }
}
