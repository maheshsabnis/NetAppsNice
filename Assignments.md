#Assignments

#Day1 : Create a Class called as 'StringIoerations' and Use the following String in the C# Code and perform operations
The String is:

The James Bond series focuses on James Bond, a fictional British Secret Service agent created in 1953 by writer Ian Fleming, who featured him in twelve novels and two short-story collections. Since Fleming's death in 1964, eight other authors have written authorised Bond novels or novelisations: Kingsley Amis, Christopher Wood, John Gardner, Raymond Benson, Sebastian Faulks, Jeffery Deaver, William Boyd, and Anthony Horowitz. The latest novel is With a Mind to Kill by Anthony Horowitz, published in May 2022. Additionally Charlie Higson wrote a series on a young James Bond, and Kate Westbrook wrote three novels based on the diaries of a recurring series character, Moneypenny.

The character—also known by the code number 007 (pronounced "double-oh-seven")—has also been adapted for television, radio, comic strip, video games and film. The films are one of the longest continually running film series and have grossed over US$7.04 billion in total at the box office, making it the fifth-highest-grossing film series to date, which started in 1962 with Dr. No, starring Sean Connery as Bond. As of 2021, there have been twenty-five films in the Eon Productions series. The most recent Bond film, No Time to Die (2021), stars Daniel Craig in his fifth portrayal of Bond; he is the sixth actor to play Bond in the Eon series. There have also been two independent productions of Bond films: Casino Royale (a 1967 spoof starring David Niven) and Never Say Never Again (a 1983 remake of an earlier Eon-produced film, 1965's Thunderball, both starring Connery). In 2015, the series was estimated to be worth $19.9 billion in total (based on box-office grosses, DVD sales and merchandise tie-ins),[1] making James Bond one of the highest-grossing media franchises of all time.

Perform Following Operations by creating methods in string class
- Print Length of String
- Print How many special characters are present in string
- Print Number of Words in string
- Print Number of Statements in string
- Print Digits provided in string
- Print digigs representing 'year e.g. 2015' in the string
- Print numbers of times and their appearing indices of following words in string
	- the, of, in, to, be, have

- MAke sure that string isn not empty by creating a private method in class
	- Switch case is same as C++ and JAVA


2. (Optional) Create an Employee class with following Properties
	- EmpNo, EmpName, Designation, DeptName, Salary, Tax
	- Create EmployeeLogic class that will have methods as follows
		- void AddEmployee(Employee)
		- boolean UpdateEmployee(eno, Employee)
			- if eno is not found or update fails then return false 
		- boolean DeleteEmployee(eno)
			- if eno is not found or delete fails then return false 	
		- GetEmployees()
			- Return all Employees
		- Before Add/Update operations make sure that, the 
			- EmpNo is required and Must not already be present
			- EmpName is required and cannot have Digits and Special Characters
			
# Date: 20-June-2023

1. Complete Problem statement 2 of Day 1 with following MOdifications
	- Create a Salary Slip for Each Employee (Director, Manager, Consultant) with Gross and NetIncome using the Accountant Class (Refer the code from CS_AppliedOOPs Project)
	- Modify Get Method for Displaing Employees based on Designation (No formal Designation property Exists in Employee class so build the logic for this)
2. (Optional)
	- Show the NetSalary in words 	
3. Modify the Accountant class that implement following Interface 
	-  interface IAccountant 
		- {
		    GetNetSalary()
			GetGrossSalaty()
			GetTax() 
		}
4. Create an accountant Application Console Project that will only print the Income Details of Each Employee (Refer: CS_Logger and CS_LoggerUtilizer Projects)


 5. Questionire on OOPs. Try this by creating seperate projects for each point given below, note the result (Error or Sucess )
	- Can we override public method of abstract class in derived class using private access specifier
	- Can we have private and protected abstract as well as vertual methods
	- Can we have abctrat class as static class
	- Can we override a method more than once
	- Can we have 2 methods in abstract class with same name and signeture but one is virtual and other is abstract
	- Can we have static constructir in class, if yes then how and when will it be executed
	- Can we have static constructor in abstract class
	- Can we have private as well as protected access specifier on class
	- Can we have provate as well as protected constructor in the class 	
	- Can we habe abstract, virtual, protected methods (seperate) in sealed class
	- 

# Date: 21-June-2023

- Modify the Employee, Director, and Manager Project by Having a Same Dictionay for storing records for all Employees
- Exeute Following Queries on the Dictionary of Employees
	- Print Second MAximum Salary for Each Employee Type (Manager, Director, Salas Manager)
	- Sum of all Salaries by Employee Type
	- Print Employees of all designations in a specific DeptName
	- Update Salaries of all Managers for all Departments by 20%
	- Add an Update ande Delete methods in EmployeeLogic class to Update Employee Record in Dictionary based on EmpNo
		- Search Record using 'TryGetValue()'
			- Self Reading for ref and out in C# 


# Date : 22-06-2023

1. Complete the EmployeeDataAccess class
	- When passing DeptNo for adding new employee, make sure that the Depratment for the DeptNo is not already full with Employees, if yes then thorw exception that Employee Cannot be inserted
		- e.g. If for Employee Record DeptNo is 20, and capacity of Department with   
		- e.g. If for Employee Record DeptNo is 20, and capacity of Department with DeptNo as 50 is already having 50 employees in that department the do not add new employee in it
2. Create Two Tasks in Continution as follows
	- Task 1 will create a department
	- Task 2 will add 10 Employees in thate nely created department

