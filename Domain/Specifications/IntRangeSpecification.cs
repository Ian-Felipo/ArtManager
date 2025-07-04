using ArtManager.Domain.Interfaces;

namespace ArtManager.Domain.Specifications;

public class IntRangeSpecification<T> : ISpecification<T>
{
    private readonly int _min;
    private readonly int _max;
    private readonly string _propertyName;
    private readonly Func<T, int> _selector;
    public string ErrorMessage { get; private set; } = string.Empty;

    public IntRangeSpecification(int min, int max, string propertyName, Func<T, int> selector)
    {
        _min = min;
        _max = max;
        _propertyName = propertyName;
        _selector = selector;
    }

    public bool IsSatisfiedBy(T entity)
    {
        int value = _selector(entity);
        bool isValid = value >= _min && value <= _max;
        ErrorMessage = isValid ? string.Empty : $"{_propertyName} deve estar entre {_min} e {_max}, mas recebeu {value}";
        return isValid;
    }
} 