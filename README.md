# Library Management System (C# WinForms + SQL Server)

## 📌 Overview
This repository contains a simple **Library Management System** built using **C# WinForms** for the desktop interface and **SQL Server** as the backend database.  
It is designed as an entry-level project to practice database connectivity, CRUD operations, and layered system design.

---

## 🎯 Features
- Add / Edit / Delete Books  
- Add / Edit / Delete Members  
- Issue & Return Books  
- View Available / Issued Books  
- Search and filter records  

---

## 🏗️ Project Structure
```
📂 LibraryManagementSystem
│
├── 📁 LibraryApp          → WinForms C# application
│   ├── Forms              → UI Forms (Books, Members, Issue, Return)
│   ├── Models             → C# models representing DB tables
│   ├── Services           → Database service classes (CRUD operations)
│   └── Program.cs         
│
├── 📁 Database
│   ├── library.sql        → SQL script to create DB & tables
│
└── README.md
```

---

## 🔌 Database Connection
You must update your **connection string** in `DatabaseService.cs`:

```csharp
string connectionString = "Server=YOUR_SERVER;Database=LibraryDB;Trusted_Connection=True;";
```

Replace `YOUR_SERVER` with your SQL Server instance name.

---

## ▶️ How to Run
1. Restore the SQL database by running `library.sql` in SQL Server.  
2. Open the solution `.sln` file in Visual Studio.  
3. Update the connection string.  
4. Run the WinForms application.

---

## 📚 Future Enhancements
- User authentication  
- Book categories and authors  
- Logging system  
- Export to Excel / PDF

---

## 📄 License
This project is free for personal & educational use.
