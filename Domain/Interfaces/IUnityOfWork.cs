namespace ArtManager.Domain.Interfaces;

public interface IUnityOfWork
{
    void Commit();
}