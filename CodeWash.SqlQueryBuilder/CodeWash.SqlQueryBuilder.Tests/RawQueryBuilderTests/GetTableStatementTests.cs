namespace CodeWash.SqlQueryBuilder.Tests.RawQueryBuilderTests;

public class GetTableStatementTests
{
    private RawQueryBuilder _rawQueryBuilder;

    [SetUp]
    public void Setup()
    {
        _rawQueryBuilder = new RawQueryBuilder("Table1", "t1");
    }

    [Test]
    public void WhenTableAliasIsNull()
    {
        string tableStatement = _rawQueryBuilder.GetTableStatement("Table1");
        Assert.That(tableStatement, Is.EqualTo("[Table1]"));
    }

    [Test]
    public void WhenTableAliasIsTheSameWithTableName()
    {
        string tableStatement = _rawQueryBuilder.GetTableStatement("Table1", "Table1");
        Assert.That(tableStatement, Is.EqualTo("[Table1]"));
    }

    [Test]
    public void WhenTableAliasIsNotNull()
    {
        string tableStatement = _rawQueryBuilder.GetTableStatement("Table1", "t1");
        Assert.That(tableStatement, Is.EqualTo("[Table1] [t1]"));
    }
}