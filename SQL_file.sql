--1.	Create roles/groups for security in the database.

CREATE ROLE SalesRole;
CREATE ROLE HRRole;
CREATE ROLE CEORole;

--2.	Modify access for those roles/groups.
--	Grant SalesRole the ability to view Orders and Customers table

GRANT SELECT ON dbo.Orders TO SalesRole;
GRANT SELECT ON dbo.Customers TO SalesRole;

--	Grant HRRole the ability to view Employee table

GRANT SELECT ON dbo.Employees TO HRRole;

--	Grant CEORole the ability to view Orders, Customers and Employee tables

GRANT SELECT ON dbo.Orders TO CEORole;
GRANT SELECT ON dbo.Customers TO CEORole;
GRANT SELECT ON dbo.Employees TO CEORole;

--3.	Create three new database users:
--4.	Add each user to the appropriate role\group.
-- Create new database users and add them to roles/groups


Create User_CEO and add to CEORole
CREATE LOGIN User_CEO WITH PASSWORD = 'User_CEO';
CREATE USER User_CEO FOR LOGIN User_CEO;
ALTER ROLE CEORole ADD MEMBER User_CEO;

Create User_HR and add to HRRole
CREATE LOGIN User_HR WITH PASSWORD = 'User_HR';
CREATE USER User_HR FOR LOGIN User_HR;
ALTER ROLE HRRole ADD MEMBER User_HR;

Create User_Sales and add to SalesRole
CREATE LOGIN User_Sales WITH PASSWORD = 'User_Sales';
CREATE USER User_Sales FOR LOGIN User_Sales;
ALTER ROLE SalesRole ADD MEMBER User_Sales;


