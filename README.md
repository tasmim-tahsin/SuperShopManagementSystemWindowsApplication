**Supershop Management System**

This project is a C# Windows Forms application designed to streamline inventory, sales, and user management for your supershop.

**Features:**

* **Product Management:**
    * Effortlessly add, edit, and delete products, maintaining detailed information like name, category, supplier, unit price, and stock quantity.
    * Browse a comprehensive list of products with search and filter options (by category, name, etc.) for quick access and organization.
    * Manage product categories and suppliers efficiently through intuitive add, edit, and delete functionalities.

* **Sales Management:**
    * Enhance the sales process with a user-friendly shopping cart feature:
        * Add products to the cart, specifying desired quantities for each item.
        * Review and modify cart contents (quantity adjustments, item removal) before finalizing the sale.
        * Seamlessly checkout and complete the sale, automatically deducting sold quantities from stock and creating a permanent sale record.
    * (Optional / Not implemented yet) Integrate diverse payment methods (cash, credit card) for a flexible and adaptable shopping experience.
    * View a detailed sales history, providing valuable insights into product performance, sales trends, and customer behavior.

* **User Management:**
    * Create differentiated user accounts with designated roles (admin, seller) to control access levels and functionalities.
    * Edit user information (excluding role) to ensure accurate records and maintain a secure system.
    * Admins can comprehensively manage all user accounts (including sellers), fostering efficient team collaboration.
    * Delete user accounts with confirmation prompts to prevent accidental data loss.

* **Sales Report:**
    * Generate insightful reports on sales data (e.g., total sales by product, specific date ranges, product categories) to gain data-driven business intelligence.
    * Monitor product inventory levels through comprehensive reports, enabling proactive stock management and low-stock notifications for informed restocking decisions.

**User Stories:**

**As an Admin, I want to...**

* Manage product information (add, edit, delete).
* Manage product categories and suppliers.
* Search and filter products for enhanced organization.
* Create and manage user accounts with assigned roles.
* View a comprehensive sales history with detailed records.

**As a Seller, I want to...**

* Utilize the shopping cart feature for efficient sales processing.
* View and modify cart contents before checkout.
* Complete sales and create sale records.
* View my own sales history (optional).
* Access basic sales reports for improved sales performance (optional).

**Note:**

* Optional features and user stories can be incorporated based on project requirements and priorities.
* User stories can be further refined to provide more granular acceptance criteria.

**Code Style Conventions:**

We adhere to the following code style conventions to promote code readability, maintainability, and collaboration:

* **Naming:**
    * Classes and type names: PascalCase (e.g., `ProductRepository`)
    * Method names, property names, and local variables: camelCase (e.g., `addProduct`, `calculateTotalPrice`)
    * Meaningful and descriptive names that accurately reflect the code element's purpose.
* **Exception Handling:**
    * Handled all possible exceptions.
* **Braces:**
    * Braces are mandatory for all code blocks, even single-line statements within conditionals (if/else) or loops.
* **Spacing:**
    * Spaces around commas, semicolons, and binary operators for improved clarity.
* **Comments:**
    * Clear and concise comments to explain complex logic or non-obvious code sections.

**Getting Started:**

1. Clone this repository: `https://github.com/tasmim-tahsin/SuperShopManagementSystemWindowsApplication.git`
2. Open the solution file (`.sln`) in Visual Studio.
3. Configure the connection string to your SQL Server database in the appropriate configuration file.
4. Build and run the application.

**Folder Structure:**

* **Models:** Contains C# classes representing database tables (Product, Category, etc.).
* **DataAccess:** Holds repository classes for interacting with the database.
* **Controls:** Includes user interface components like forms and user controls.

**Further Development:**

* Implement additional features based on project needs and priorities.
* Enhance the user interface for improved usability and user experience.
* Develop unit tests for core functionalities to ensure code quality and reliability.

**License:**

 * MIT License.

**Contributing:**

Pull requests are welcome. Please follow these coding conventions and best practices for documentation.

**Authors:**

 * Md Tasmim Al Tahsin (tasmim-tahsin)
 * Dipra Kar
 * Adindita Debnath
