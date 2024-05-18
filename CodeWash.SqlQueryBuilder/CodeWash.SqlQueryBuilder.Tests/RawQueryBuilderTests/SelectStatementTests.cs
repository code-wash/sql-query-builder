using Moq;

namespace CodeWash.SqlQueryBuilder.Tests.RawQueryBuilderTests;

public class SelectStatementTests
{
    private RawQueryBuilder _rawQueryBuilder;

    [SetUp]
    public void Setup()
    {
        _rawQueryBuilder = new RawQueryBuilder("Table1");
    }

    [Test]
    public void WhenItIsGenerated()
    {
        string expected =
            $"""
            SELECT
                *
            FROM
                [Table1]
            """;
        Assert.That(_rawQueryBuilder.SelectStatement, Is.EqualTo(expected));
    }
}
