namespace ArtManager.Domain.Specifications;

public class StringLengthSpecification<T> : ISpecification<T>
{
    private readonly int _min;
    private readonly int _max;
    private readonly string _propertyName;
    private readonly Func<T,string> _selector;
    public string ErrorMessage { get; }

    public StringLengthSpecification(int min, int max, string propertyName, Func<T, string> selector)
    {
        _min = min;
        _max = max;
        _propertyName = propertyName;
        _selector = selector;
        ErrorMessage = $"{_propertyName} deve ter entre {_min} e {_max} caracteres.";
    }

    public bool IsSatisfiedBy(T entity)
    {
        var value = _selector(entity)?.Trim() ?? string.Empty;
        return value.Length >= _min && value.Length <= _max;
    }
}