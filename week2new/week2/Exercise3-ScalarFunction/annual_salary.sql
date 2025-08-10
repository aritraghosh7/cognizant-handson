-- Simulating scalar function: calculate annual salary for EmployeeID = 1
SELECT 
    EmployeeID,
    FirstName || ' ' || LastName AS FullName,
    Salary,
    Salary * 12 AS AnnualSalary
FROM Employees
WHERE EmployeeID = 1;
