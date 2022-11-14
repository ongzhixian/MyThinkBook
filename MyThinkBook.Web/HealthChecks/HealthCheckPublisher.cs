using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MyThinkBook.Web.HealthChecks;

public class HealthCheckPublisher : IHealthCheckPublisher
{
    public Task PublishAsync(HealthReport report, CancellationToken cancellationToken)
    {
        
        return Task.CompletedTask;
    }
}