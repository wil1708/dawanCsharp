namespace ProjetDLL.TellDontAsk.Good
{
    public interface IAccountRepository
    {
        Account findById(int id);
        void Save(Account c);
    }
}