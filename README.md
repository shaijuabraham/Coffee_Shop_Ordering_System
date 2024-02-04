
In this project, I have developed a comprehensive coffee shop management application that follows the MVC (Model-View-Controller) design pattern for modularity and reusability. Here's a summarized overview:

Implementing MVC Design Pattern:

Created three core classes: Menu (Model), MenuBuilder (Controller), and MenuDisplay (View).
These classes are designed to be independent of the GUI, facilitating reuse in other programs.
Ensured that classes do not rely on GUI controls, allowing for versatility in various program environments.
Creating Menu Management Form:

Designed a form to enable employees to add new drink or pastry items to the coffee shop's menu.
Implemented form controls for entering item details such as category, short and long descriptions, retail price, cost, and image URL.
Incorporated selection controls for choosing the item's category.
Included buttons to store the menu item and view the entire menu.
Menu Display Form:

Developed a form that displays the coffee shop's entire menu.
Users can view summary information like short description, category, and price.
Detailed information, including images, is displayed when a menu item is selected.
Implemented a search tool for users to filter items by category, and optionally, additional search criteria.
Saving & Restoring the Menu:

Ensured that the application can save the menu (collection of menu items) to a text file upon exiting.
Program can restore the menu from the saved text file when starting.
Created an empty collection if the text file doesn't exist.
Creating Orders:

Allowed users to create and submit orders by entering customer information and selecting menu items.
Designed an Order class to store customer details, order date and time, and selected menu items.
Calculated the total cost for the order with tax and displayed a detailed receipt on a separate form.
This project demonstrates a versatile and reusable coffee shop management application that effectively separates the GUI from core functionality. It enables menu creation, management, order processing, and data persistence, providing a comprehensive solution for coffee shop employees to enhance their operations.
