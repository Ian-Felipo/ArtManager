namespace ArtManager.Domain.Specifications;

public class IntRangeSpecification<T> : ISpecification<T>
{
    private readonly int _min;
    private readonly int _max;
    private readonly string _propertyName;
    public string ErrorMessage { get; }

    public IntRangeSpecification(int min, int max, string propertyName)
    {
        _min = min;
        _max = max;
        _
    }
} 