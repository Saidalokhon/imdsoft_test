# iMDSoft Patient Test Manager

This is a **test project for iMDSoft**.  
It is a WinForms desktop app for managing patients, their medical tests, and generating reports.

## How to run

1. **Clone the repository**
   ```bash
   git clone https://github.com/Saidalokhon/imdsoft_test.git
   cd <REPO_FOLDER>
   ```
2. **Open the solution in Visual Studio**
	- Open the `.sln` file.
3. **Set the startup project**
	- In Solution Explorer, right-click the `iMDSoft` project (UI project).
	- Click Set as Startup Project.
4. **Check the connection string (optional)**
	- Open `iMDSoft\App.config`.
	- Make sure the `Imdsoft` connection string points to your SQL Server LocalDB (default is usually OK).
5. **Restore packages and build**
	- Right-click the solution → Restore NuGet Packages (if needed).
6. **Build the solution `(Ctrl+Shift+B)`.**
7. **Run the application**
	- Press F5 or click Start in Visual Studio.
	- On first run, the database will be created and seeded with sample patients and tests automatically.