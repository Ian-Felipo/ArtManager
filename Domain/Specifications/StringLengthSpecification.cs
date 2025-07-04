namespace ArtManager.Domain.Specifications;

public class StringLengthSpecification<T> : ISpecification<T>
{
    private readonly int _min;
    private readonly int _max;
    private readonly string _propertyName;
    private readonly Func<T,string> _selector;
    public string ErrorMessage { get; private set; } = string.Empty;

    public StringLengthSpecification(int min, int max, string propertyName, Func<T,string> selector)
    {
        _min = min;
        _max = max;
        _propertyName = propertyName;
        _selector = selector;
    }

    public bool IsSatisfiedBy(T entity)
    {
        string value = _selector(entity) ?? string.Empty;
        value = value.Trim();
        bool isValid = value.Length >= _min && value.Length <= _max;
        ErrorMessage = isValid ? string.Empty : $"{_propertyName} deve ter entre {_min} e {_max} caracteres, mas recebe {value.Length}";
        return isValid;
    }
}