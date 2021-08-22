# .NET-Lessons-ITVDN
  Exercise 1.
Improve the SimpleApp application. In the data.txt file add additional information about
product - product description, number of units in stock.
Add a description of the product and the number of units in stock to the Details view.
In the List view, make sure that if the product is out of stock, the message is displayed
opposite the product - "out of stock", if the quantity is up to 5 units in the warehouse - "runs out",
if more than 5 units - "in stock".

  Assignment 2
In the SampleApp, from the first homework assignment. Add information to the data.txt file about which category the product is in.
Modify the Products controller so that you can get products in the specified category on the page through the parameter in the request.
For example,
localhost: 50234 / products / list - all products;
localhost: 50234 / products / list / pc - all products in the pc category;
localhost: 50234 / products / list / office - all products in the office category.
