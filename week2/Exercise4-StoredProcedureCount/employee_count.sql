-- Simulating stored procedure to count employees in DepartmentID = 1
SELECT 
    d.DepartmentName,
    COUNT(e.EmployeeID) AS EmployeeCount
FROM Departments d
LEFT JOIN Employees e ON d.DepartmentID = e.DepartmentID
WHERE d.DepartmentID = 1
GROUP BY d.DepartmentID;
