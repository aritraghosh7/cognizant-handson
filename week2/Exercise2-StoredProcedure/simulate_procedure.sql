-- Simulate inserting employee like sp_InsertEmployee
INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES ('Alice', 'Brown', 3, 7200.00, '2022-02-10');

-- Query employees from a specific department (simulate parameter = 3)
SELECT * FROM Employees WHERE DepartmentID = 3;
