public interface ICurrency
{
    void AddCurrency(int amount);
    bool SpendCurrency(int amount);
    int GetCurrencyAmount();
}