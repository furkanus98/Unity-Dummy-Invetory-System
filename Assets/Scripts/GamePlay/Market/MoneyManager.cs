using UnityEngine;

public class MoneyManager : MonoBehaviour, ICurrency
{
    [SerializeField] private int _currency;

    public void AddCurrency(int amount)
    {
        _currency += amount;
    }

    public bool SpendCurrency(int amount)
    {
        if (_currency >= amount)
        {
            _currency -= amount;
            return true;
        }
        return false;
    }

    public int GetCurrencyAmount()
    {
        return _currency;
    }
}