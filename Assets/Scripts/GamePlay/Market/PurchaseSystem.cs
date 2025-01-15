using UnityEngine;

public class PurchaseSystem
{
    private ICurrency _currency;
    private IInventory _inventory;

    public PurchaseSystem(ICurrency currency, IInventory inventory)
    {
        _currency = currency;
        _inventory = inventory;
    }

    public bool Purchase(Product product)
    {
        if (_currency.SpendCurrency(product.Price))
        {
            _inventory.AddItem(product);
            Debug.Log($"{product.Name} satýn alýndý!");
            return true;
        }
        else
        {
            Debug.Log("Yeterli para yok.");
            return false;
        }
    }
}
