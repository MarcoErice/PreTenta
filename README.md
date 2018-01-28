# PreTenta
MVC course Pre exam
Create a new ASP.NET Core MVC application with authentication enabled (Individual accounts) and make sure that the following tasks are implemented:

Switch to InMemoryDatabase
Add a Product model with the properties Name, UnitPrice, ReleaseDate and IsDeleted using appropriate types
Name should be at least 3 characters long
UnitPrice should be less than or equal to 1000000
Add a ProductController with associated Views
Seed the database with some products
Seed one role: Administrators
Seed two user accounts: Student and Administrator
Seed the association between Administrator user and Administrators role
Use a custom font for the default site layout
Change Products/Index so that it is sorted by Name
Require Administrators Role for calling Products/Delete
Add a Products link to the navigation bar of the layout
Make your Product links SEO friendly by adding slug support to them (the Index view is a good place to start)
Inject a logger into ProductsController and write a message to the log every time a new Product has been created
Make time travel possible. After 1st february 2018 the background color should change.
Add CultureCode to ApplicationUser
Add necessary changes to related Controllers and Views to manage the property CultureCode
Localize the navigation bar to English and Swedish (look at my solution at Ping Pong / MVC / Kursdokument / DeepdiveLocalizationWebe.zip to get some ideas/inspiration)
