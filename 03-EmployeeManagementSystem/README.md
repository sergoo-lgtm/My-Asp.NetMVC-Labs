<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:0F2027,50:203A43,100:2C5364&height=260&section=header&text=Employee%20Management%20System&fontSize=45&fontAlignY=40&animation=fadeIn&fontColor=ffffff" />
</p>

<p align="center">
  <img src="https://readme-typing-svg.herokuapp.com?font=Fira+Code&weight=600&size=22&pause=1000&color=00C2FF&center=true&vCenter=true&width=650&lines=ASP.NET+Core+MVC+Project;.NET+8+with+Entity+Framework+Core;SQL+Server+Integration;Clean+MVC+Architecture" />
</p>

<p align="center">
  <img src="https://komarev.com/ghpvc/?username=your-github-username&style=for-the-badge" />
</p>

---

# 🏢 Employee Management System

A complete **Employee Management System** built using **ASP.NET Core MVC (.NET 8)** with **Entity Framework Core** and **SQL Server**.

This project demonstrates real-world CRUD operations with relational database integration between **Employees** and **Departments**.

---

## 🚀 Default Route

```
/Employee/ShowAllEmployees
```

---

## 🎯 Features

- 👨‍💼 Manage Employees
- 🏢 Manage Departments
- 🔗 One-to-Many Relationship (Department → Employees)
- ✏️ Edit Employees
- ➕ Add Departments
- 🗂️ Entity Framework Core Integration
- 🧱 Clean MVC Architecture
- 📱 Responsive UI (Bootstrap)
- 🔄 Eager Loading using Include()

---

## 🛠️ Tech Stack

- **C#**
- **.NET 8**
- **ASP.NET Core MVC**
- **Entity Framework Core**
- **SQL Server**
- **Bootstrap**
- **Rider / Visual Studio**

---

## 🧠 Database Design

### Department Table

| Column        | Type   |
|--------------|--------|
| Id           | int    |
| Name         | string |
| ManagerName  | string |

---

### Employee Table

| Column        | Type   |
|--------------|--------|
| Id           | int    |
| Name         | string |
| Salary       | int    |
| JobTitle     | string |
| ImageURL     | string |
| Address      | string |
| DepartmentId | int (FK) |

---

## 🔗 Relationship

```
Department (1)
      |
      |------< Employee (Many)
```

- Each Department can have multiple Employees.
- Employee contains a Foreign Key: `DepartmentId`.

---

## 📂 Project Structure

```text
📦 EmployeeManagementSystem
 ┣ 📂 Controllers
 ┃ ┣ 📜 DepartmentController.cs
 ┃ ┗ 📜 EmployeeController.cs
 ┣ 📂 Models
 ┃ ┣ 📜 Department.cs
 ┃ ┣ 📜 Empoloyee.cs
 ┃ ┗ 📜 DContext.cs
 ┣ 📂 Views
 ┃ ┣ 📂 Department
 ┃ ┃ ┣ 📜 Index.cshtml
 ┃ ┃ ┗ 📜 Add.cshtml
 ┃ ┣ 📂 Employee
 ┃ ┃ ┣ 📜 ShowAllEmployees.cshtml
 ┃ ┃ ┗ 📜 EditEmployees.cshtml
 ┣ 📜 Program.cs
```

---

## 🧠 Architecture Flow

```
User Request
     ↓
Controller
     ↓
DbContext (EF Core)
     ↓
SQL Server Database
     ↓
Model
     ↓
View
     ↓
HTML Response
```

---

## ⚙️ How To Run

### 1️⃣ Clone Repository

```
git clone https://github.com/your-username/EmployeeManagementSystem.git
```

---

### 2️⃣ Configure Database

Inside `DContext.cs`:

```csharp
optionsBuilder.UseSqlServer(
  "Server=localhost,1433;Database=EmployeeManagementSystemDB;User Id=sa;Password=YourPassword;TrustServerCertificate=True;"
);
```

---

### 3️⃣ Run Migrations

```
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

### 4️⃣ Run Project

```
dotnet run
```

---

## 📸 Screenshots

### 🏢 Departments Page

<p align="center">
  <img src="https://raw.githubusercontent.com/your-username/EmployeeManagementSystem/main/screenshots/departments.png" width="900"/>
</p>

---

### 👨‍💼 Employees Page

<p align="center">
  <img src="https://raw.githubusercontent.com/your-username/EmployeeManagementSystem/main/screenshots/employees.png" width="900"/>
</p>

---
---

## 💡 Future Improvements

- ✅ Add Create Employee
- 🗑️ Delete Employee
- 🗑️ Delete Department
- 🔍 Search Feature
- 🧪 Validation using DataAnnotations
- 🧱 Apply Dependency Injection for DbContext
- 📦 Use Repository Pattern
- 🔐 Authentication & Authorization

---

## 👨‍💻 Author

<p align="center">
  Developed with 🔥 by <b>Youssef</b><br>
  Backend Developer (.NET)
</p>

---

## ⭐ Support

If you like this project, consider giving it a ⭐ on GitHub!
