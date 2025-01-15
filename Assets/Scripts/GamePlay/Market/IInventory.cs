public interface IInventory
{
    void AddItem(Product product);
    bool RemoveItem(Product product);
    bool HasItem(Product product);
}