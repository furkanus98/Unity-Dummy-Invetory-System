#Currency Management (MoneyManager)

A centralized system (MoneyManager) is responsible for managing the player's currency. This includes adding currency, spending currency, and checking the current balance.
Ensured flexibility by decoupling the logic from UI or other systems, adhering to the Single Responsibility Principle (SRP).
Inventory System

A structure for storing and managing purchased items. Each purchase adds an item to the inventory, demonstrating separation of concerns between managing currency and managing items.
Market Display System (MoneyDisplay)

A display mechanism updates the user interface to reflect changes in currency and inventory dynamically.
The display system subscribes to relevant events from MoneyManager, adhering to the Observer pattern for efficient updates.
Event-Driven Architecture

Integrated events and delegates to decouple the currency management logic from the UI and other game systems.
Events allow the system to notify multiple listeners (e.g., UI components) of changes without hard dependencies.
SOLID Principle Application

Single Responsibility Principle: Each class has a clearly defined purpose (e.g., MoneyManager for currency, Inventory for items, MoneyDisplay for UI).
Open/Closed Principle: The system can be extended with new functionality (e.g., new item types or UI changes) without modifying existing code.
Liskov Substitution Principle: Interfaces and abstract classes ensure components can be replaced with new implementations if needed.
Interface Segregation Principle: Interfaces are designed to include only the methods relevant to a specific functionality.
Dependency Inversion Principle: High-level modules depend on abstractions rather than concrete implementations.
Extensibility

The system is designed to be flexible and expandable, allowing for future features such as:
Special offers or discounts in the market.
Complex inventory management systems.
Integration with online services for currency and item synchronization.

# Unity FPS Counter
 This Unity script displays the current Frames Per Second (FPS) on the screen. It's a lightweight tool to monitor your game's performance during development.
