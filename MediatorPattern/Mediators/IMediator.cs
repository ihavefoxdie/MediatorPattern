namespace MediatorPattern.Mediators;

public interface IMediator
{
    public void Notify(object sender, string command);
}
