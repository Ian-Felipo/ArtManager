namespace ArtManager.Domain.Specifications;

public interface ISpecification<T>
{
    string ErrorMessage { get; }
    bool IsSatisfiedBy(T entity);
}