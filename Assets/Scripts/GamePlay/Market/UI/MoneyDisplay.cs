using TMPro;
using UnityEngine;

public class MoneyDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text moneyText; // Para miktar�n� g�sterecek UI eleman�
    private MoneyManager moneyManager;

    void Start()
    {
        // Para y�netim sistemini al�yoruz
        moneyManager = FindAnyObjectByType<MoneyManager>();
        UpdateMoneyDisplay();
    }

    public void UpdateMoneyDisplay()
    {
        // Para miktar�n� ekranda g�ncelliyoruz
        moneyText.text = $"Para: {moneyManager.GetCurrencyAmount()}";
    }
}
