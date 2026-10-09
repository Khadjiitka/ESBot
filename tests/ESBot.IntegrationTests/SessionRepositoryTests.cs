using Testcontainers.PostgreSql;

namespace ESBot.IntegrationTests;

public sealed class SessionRepositoryTests : IAsyncLifetime
{
    private readonly PostgreSqlContainer _postgres = new PostgreSqlBuilder()
        .WithImage("postgres:16-alpine")
        .Build();

    public async ValueTask InitializeAsync()
    {
        await _postgres.StartAsync();
    }

    public async ValueTask DisposeAsync()
    {
        await _postgres.DisposeAsync();
    }

    [Fact]
    public void ShouldStartPostgresContainer()
    {
        Assert.NotEmpty(_postgres.GetConnectionString());
    }
}