using UnityEngine;

public class MarketSystem : MonoBehaviour
{
    [Header("Market")]
    [SerializeField] private MoneyManager moneyManager;
    [SerializeField] private IInventory inventoryManager;
    [SerializeField] private PurchaseSystem purchaseSystem;

    void Start()
    {
        moneyManager = new MoneyManager();
        inventoryManager = new InventoryManager();
        purchaseSystem = new PurchaseSystem(moneyManager, inventoryManager);

        moneyManager.AddCurrency(200);
        //Product sword = new Product("Kýlýç", 50);
        //Product kalkan = new Product("Kalkan", 100);

        // Ürün satýn al
        //purchaseSystem.Purchase(sword);
    }
}
