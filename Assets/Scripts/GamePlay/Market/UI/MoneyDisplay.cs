using TMPro;
using UnityEngine;

public class MoneyDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text moneyText; // Para miktarýný gösterecek UI elemaný
    private MoneyManager moneyManager;

    void Start()
    {
        // Para yönetim sistemini alýyoruz
        moneyManager = FindAnyObjectByType<MoneyManager>();
        UpdateMoneyDisplay();
    }

    public void UpdateMoneyDisplay()
    {
        // Para miktarýný ekranda güncelliyoruz
        moneyText.text = $"Para: {moneyManager.GetCurrencyAmount()}";
    }
}
