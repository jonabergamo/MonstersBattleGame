using CoreLibrary.Entities;

public interface IObserver
{
    void Update(Player player, string happening);

    string GetObserverName();
}