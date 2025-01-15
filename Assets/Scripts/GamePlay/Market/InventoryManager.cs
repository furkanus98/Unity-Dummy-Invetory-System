using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : IInventory
{
    [SerializeField] private List<Product> _inventory = new List<Product>();

    public void AddItem(Product product)
    {
        _inventory.Add(product);
    }

    public bool RemoveItem(Product product)
    {
        return _inventory.Remove(product);
    }

    public bool HasItem(Product product)
    {
        return _inventory.Contains(product);
    }
}