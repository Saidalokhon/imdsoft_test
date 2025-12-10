
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
6. **Build the solution `(Ctrl+Shift+B)`**
7. **Run the application**
	- Press F5 or click Start in Visual Studio.
	- On first run, the database will be created and seeded with sample patients and tests automatically.

## Functionality

### Patients

- **Create patient**
  1. In the main form, click **"Add patient"**.
  2. In the opened dialog, enter the patient details.
  3. Click **"Save"**.

- **Update patient**
  1. In the main form, locate the desired patient in the list.
  2. Double-click the patient.
  3. In the opened dialog, update the patient details.
  4. Click **"Save"**.

- **Delete patient**
  1. In the main form, locate the desired patient in the list.
  2. Double-click the patient.
  3. In the opened dialog, click **"Delete"**.

### Tests

- **Create test**
  1. In the main form, click the patient the test belongs to.
  2. Click **"Add test"**.
  3. In the opened dialog, enter the test details.
  4. Click **"Save"**.

- **Update test**
  1. In the main form, select the patient, then locate the desired test in the tests list.
  2. Double-click the test (or open it via the edit button, if available).
  3. In the opened dialog, update the test details.
  4. Click **"Save"**.

- **Delete test**
  1. In the main form, select the patient, then locate the desired test in the tests list.
  2. Double-click the test (or open it via the edit button, if available).
  3. In the opened dialog, click **"Delete"**.

### Reports

- **Generate report**
  1. In the main form, click **"Generate report"**.
  2. In the opened dialog, select **From** and **To** dates.
  3. If you want to download the report as CSV, check **"Generate CSV"**.
     - If **"Generate CSV"** is checked, you will be prompted to save the report as a CSV file.
     - If it is **not** checked, the report will be opened in a new form.

## Original test description
## Patient Test Manager
## Description
Create a desktop application using either WinForms or WPF in C#. The application should connect to a local SQL database (e.g., SQLite or Microsoft SQL Server) and enable users to manage patients and their associated medical tests.
## Entities
### Patient
- Id (int, primary key)
- Name (string)
- DateOfBirth (date)
- Gender (string)
### Test
- Id (int, primary key)
- PatientId (int, foreign key)
- TestName (string)
- TestDate (date)
- Result (numeric, e.g., decimal or double)
- IsWithinThreshold (bool)
## Requirements
### Database Layer
- Design and create the database schema for both tables, including the relationship
	- Feel free to use code-first approach or CREATE TABLE SQL scripts (make sure to include them in your project)
- For data access, you may use either Entity Framework or plain SQL statements. If you choose plain SQL, you must write the necessary SQL statements for CRUD operations for both Patient and Test tables, using parameterized queries to prevent SQL injection.
### UI Layer (WinForms or WPF):
- Display a list of patients in a grid or list view
-  When a patient is selected, display their tests in a separate grid or list
-  Provide controls to add, edit, and delete patients and tests
	- Make sure to refresh the lists after any operation 
### Validation & Error Handling
- Validate user input (e.g., required fields, valid dates and numeric values)
- Handle and display database errors gracefully

### Report
- Generate a report using a plain SQL statement (not ORM) that shows the following columns:
	- Patient ID
	- Patient name
	- Total number of tests for the patient
	- The percentage of tests within the threshold for the patient (number of tests with IsWithinThreshold = true divided by the total number of tests for that patient)
- The report should accept two parameters (`from date` and `to date`) and only include tests within that date range
- Provide the report to the user either by displaying it in the UI in a grid or downloading it as a
CSV (your choice).

## Deliverables
- Source code (preferably in a GitHub public repository or as a zip file uploaded to any file sharing platform)
	- Make sure to include all needed files and scripts
- Brief README with setup and run instructions