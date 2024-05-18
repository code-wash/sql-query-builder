namespace CodeWash.SqlQueryBuilder;

public record RawQueryBuilder
{
    private readonly string _tableName;
    private readonly string _tableAlias;
    private readonly string[] _selectColumns;

    public RawQueryBuilder(string tableName)
        : this (tableName, tableName)
    {
    }

    public RawQueryBuilder(string tableName, string tableAlias)
    {
        _tableName = tableName;
        _tableAlias = tableAlias;

        _selectColumns = ["*"];
    }

    internal string SelectColumns => string.Join(", ", _selectColumns);

    internal string GetTableStatement(string tableName, string? tableAlias = null) =>
        tableName == tableAlias || string.IsNullOrEmpty(tableAlias)
            ? $"[{tableName}]"
            : $"[{tableName}] [{tableAlias}]";

    internal string SelectStatement =>
        $"""
        SELECT
            {SelectColumns}
        FROM
            {GetTableStatement(_tableName, _tableAlias)}
        """;

    public string Build()
    {
        throw new NotImplementedException("Please create a test first.");
    }
}
