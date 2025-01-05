Health Management System

This is a Health Management System web application built using ASP.NET MVC and Entity Framework. The project implements CRUD (Create, Read, Update, Delete) functionality with a login system and search functionality. It is designed to manage patient records efficiently.

Features
 • Authentication: Login and logout functionality for secure access.
 • Patient Management:
 • Add new patients.
 • View a list of patients with search functionality.
 • Update patient details.
 • Delete patient records.
 • Search: Case-insensitive search by name or address.
 • Validation: Server-side validation to ensure data integrity.
 • Responsive Design: Integrated with a third-party HTML templateonly for log in for a modern user interface.

Technologies Used
 • Frontend: Razor Views, HTML, CSS (custom and third-party templates).
 • Backend: ASP.NET MVC 5, C#.
 • Database: SQL Server, Entity Framework for ORM.
 • Tools: Visual Studio, IIS Express.
 • Version Control: Git.

Installation
 1. Clone the Repository:

git clone https://github.com/jonathanniwadev/HealthManagementSystem.git
cd HealthManagementSystem


 2. Setup the Database:
 • Open SQL Server Management Studio (SSMS).
 • Create a database named HealthcareDB.
 • Use the SQL scripts in the DatabaseScripts folder to create and seed tables (Users, Patients).
 3. Configure the Application:
 • Open the project in Visual Studio.
 • Update the connection string in Web.config to match your database configuration:

<connectionStrings>
  <add name="HealthManagementDBEntities" connectionString="Your-Connection-String" providerName="System.Data.SqlClient" />
</connectionStrings>


 4. Run the Application:
 • Set the startup project to HealthManagementSystem.
 • Press F5 to run the project.

How to Use
 1. Login:
 • Use the default login credentials:
 • Username: Jonny
 • Password: 12345
 2. Manage Patients:
 • Access the Patients module to add, edit, delete, or search for patient records.

Project Structure

HealthManagementSystem
│
├── Controllers    
│   ├── PatientsController.cs   # Manages login and logout and also Handles patient CRUD operations.
│
├── Models/
│   ├── Patient.cs              # Patient model with data annotations.
│   ├── User.cs                 # User model for authentication.
│   ├── HealthManagementDB.edmx # Entity Framework database model.
│
├── Views/
│   ├── Account/
│   │   ├── Login.cshtml        # Login view.
│   ├── Patients/
│   │   ├── Index.cshtml        # List and search patients.
│   │   ├── Create.cshtml       # Create a new patient.
│   │   ├── Edit.cshtml         # Edit patient details.
│   │   ├── Details.cshtml      # View patient details.
│   │   ├── Delete.cshtml       # Delete patient confirmation.
│   ├── Shared/
│       ├── _Layout.cshtml      # Main layout file.
│
├── Content/
│   ├── style.css               # CSS for the application.
│
├── Scripts/                    # JavaScript files.
├── App_Start/
│   ├── RouteConfig.cs          # URL routing configuration.
│
├── Web.config                  # Application configuration file.                                                             
└── README.md                   # Project documentation.



Contributions

Contributions, issues, and feature requests are welcome!
Feel free to check the issues page.

License

This project is open-source. Feel free to use, modify  and share.

Acknowledgments
 • Thanks to W3Layouts for the login page template.
 • Built with ❤️ by Jonathan.
