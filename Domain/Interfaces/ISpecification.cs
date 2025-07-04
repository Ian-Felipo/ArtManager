namespace ArtManager.Domain.Interfaces;

public interface ISpecification<T>
{
    string ErrorMessage { get; }
    bool IsSatisfiedBy(T entity);
}