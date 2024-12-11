# BulkyBook  

**BulkyBook** is a web application built using ASP.NET Core MVC (version 8), designed to manage book categories efficiently. The project demonstrates CRUD (Create, Read, Update, Delete) operations on a **Category** table, utilizing Microsoft SQL Server for data storage and manipulation. This project serves as a learning experience in ASP.NET Core development, providing hands-on practice with MVC architecture, validations, and client-side notifications.

## Features  

- **CRUD Operations**:  
  - Create new book categories.  
  - View a list of all categories.  
  - Edit existing category details.  
  - Delete categories with confirmation.  
- **Microsoft SQL Server Integration**:  
  - Store and manipulate category data using a relational database.  
- **Bootstrap 5 for Styling**:  
  - Responsive and modern UI using Bootstrap 5.  
- **Form Validations**:  
  - Server-side and client-side validations to ensure secure and error-free operations.  
- **Notifications with Toastr**:  
  - Real-time notifications for create, update, and delete actions.  
- **Secure and User-Friendly**:  
  - Validation checks to prevent invalid data entry.  

## Technical Stack  

- **Framework**: ASP.NET Core MVC (Version 8)  
- **Database**: Microsoft SQL Server  
- **Front-End**: HTML, CSS, Bootstrap 5  
- **Notification**: Toastr.js  

## Project Structure  

1. **Category Controller**:  
   - Contains actions like `Create`, `Edit`, `Delete`, and `Details` to manage the Category table.  
2. **Views**:  
   - Dedicated views for creating, editing, and listing categories, styled with Bootstrap 5.  
3. **Validation**:  
   - Both client-side and server-side validations to ensure data integrity.  
4. **Notifications**:  
   - Toastr.js integrated for user-friendly notifications on CRUD operations.  

## Installation  

1. Clone the repository:  
   ```bash  
   git clone https://github.com/your-username/bulkybook.git  
   ```  
2. Open the project in Visual Studio 2022 or later.  
3. Configure the connection string in `appsettings.json` to point to your SQL Server database.  
4. Run the migrations to create the database schema:  
   ```bash  
   dotnet ef database update  
   ```  
5. Build and run the project.  

## Screenshots  

*(Add screenshots of your application here, showcasing the UI and CRUD operations.)*

## Learning Outcomes  

- Gained hands-on experience with ASP.NET Core MVC architecture.  
- Improved skills in creating and managing database-driven web applications.  
- Learned to use Bootstrap 5 for responsive UI design.  
- Enhanced understanding of secure and validated CRUD operations.  
- Experienced real-time user feedback using Toastr.js notifications.  

## Acknowledgements  

- [ASP.NET Core Documentation](https://learn.microsoft.com/en-us/aspnet/core/)  
- [Bootstrap 5 Documentation](https://getbootstrap.com/docs/5.0/)  
- [Toastr.js](https://github.com/CodeSeven/toastr)  

---

Feel free to adjust the content, especially the placeholder links and add screenshots for a more comprehensive README.
