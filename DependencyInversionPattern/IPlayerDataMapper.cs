namespace DependencyInversionPattern
{
    public interface IPlayerDataMapper
    {
        bool PlayerNameExistsInDatabase(string name);
        void InsertNewPlayerIntoDatabase(string name);
    }
}
