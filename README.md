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

  Task 2
Create a web application. Add a model that will represent a collection of objects with Id, Price, Name properties. Fill the collection with random values.
Make a Products controller with an Index accessor that returns a view with all the data from the model. Do the data transfer to the view in two ways, via the ViewBag and via the strongly typed view. What difficulties did you face while implementing views in two different ways?

  Assignment 2
Create a controller that displays information to the user about his IP address and the browser that made the request.
