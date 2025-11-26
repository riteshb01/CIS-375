# TechGadgetCollection - C# WinForms Application

This is a Windows Forms application for managing a collection of tech gadgets.

## Project Structure

- **CollectionItem.cs** - Base class for collection items with properties: Name, Brand, Price, Category, PurchaseDate
- **TechGadget.cs** - Custom class that inherits from CollectionItem and adds:
  - `WarrantyMonths` property (additional property specific to tech gadgets)
  - Overridden `GetSummary()` method that includes warranty information
  - Constructor that calls the base constructor

## Features

- Add tech gadgets to your collection
- View all gadgets in a data grid
- Track warranty period for each gadget
- Categories: Phone, Laptop, Tablet, Accessory

## Forms

1. **MainForm** - Starting screen with "Add Item" and "View Items" buttons
2. **AddItemForm** - Form for adding new gadgets with fields for:
   - Item Name
   - Brand
   - Price
   - Warranty (Months) - *Custom property*
   - Category (dropdown)
   - Purchase Date
3. **ViewItemsForm** - Displays all gadgets in a DataGridView

## Key Implementation Details

### TechGadget Class
- Inherits from `CollectionItem`
- Adds `WarrantyMonths` property (integer) for tracking warranty period
- Constructor calls base constructor: `base(name, brand, price, category, purchaseDate)`
- Overrides `GetSummary()` to include warranty information

### Inheritance Structure
```
CollectionItem (base class)
    └── TechGadget (derived class)
```

## Building and Running

This project requires:
- .NET 6.0 or later with Windows Desktop support
- Windows operating system

To build:
```bash
cd TechGadgetCollection
dotnet build
```

To run:
```bash
dotnet run
```

## Project Requirements Met

✅ CollectionItem.cs added to project with correct namespace (TechGadgetCollection)
✅ New class (TechGadget.cs) inherited from CollectionItem
✅ Constructor with parameters calls base constructor
✅ At least 1 custom property added (WarrantyMonths)
✅ CollectionItem.cs not edited (except namespace change)
✅ GetSummary() overridden to reflect custom TechGadget class
