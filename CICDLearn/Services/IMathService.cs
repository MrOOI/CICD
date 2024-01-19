namespace CICDLearn.Services;

public interface IMathService
{
    Task<long> AddAsync(long a, long b, CancellationToken cancellationToken = default);
}

public class MathService : IMathService
{
    public async Task<long> AddAsync(long a, long b, CancellationToken cancellationToken)
    {
        return await Task.FromResult(a + b);
    }
}