# .NET Apps

- C# Programming Language
- Hight-Level Language aka defacto Programming model for .NET Apps
- 100% OOPs
- Support for, Desktop, Web, Mobile, Cloud, ML, Gaming, and IoT Apps
- Programming Concepts
	- namespace
		- collection of similar behavior classes, based on Proncipal of Single-Responsibility
		- a namespace can have other namespaces
		- The 'System' is the highest level namespce for Application Dev.
			- Database, Collection, Files, etc	 
		- The .NET Application Dev. Runtime has 'Microsoft' as top level namespace
			- Microsoft.NetCore.App
				- All .NET Apps 
			- Microsoft.AspNetCore.App
				- Only for ASP.NET Core Eco-System (Pages, MVC, API, Blazor)
	- Application Runtime
		- dotnet.exe, Cross-Platform
			- A Host for .NET Apps, this loads following components while running the application
				- Standard .NET Libs, also know as Framework Classs Library (FCL)
				- Runtime Services
					- Memory Mangement
					- Code-Optimizer based on the version 
				- Runtime Dependencies
					- All Standard and externally referred Packages (aka libraries) 
				- The Application intermidiate code (Intermidiate Language OR IL)
	- LOng Term Support (LTS)
		- Production Ready support across Apps across all suported OS including Docker
	- Standard Term Support
		- Available for Current Version for Production, but aftre Next release this may be revoked or removed 
# C# Application
- Main() as enrtypoint
	- .NET 6, the Main() is implicit in Program.cs
	- The Main() methid is a part of 'Program' class and all methods in the Program class are 'static'
- .NET Types
	- Vale and Ref types	
	- The 'char', with size is 2 bytes
	- The 'string' size is (Length*2 + 2) bytes
- The 'System.Type' is the Type class that is used to read the 'typeof()' each declaratrion in .NET using the 'GetType()' method
	
- Object Oriented Programming (OOPs)
	- Abstratcion and Encapsulation
		- Data Encapsulation, with Data Members
		- Behavior Abstratcion with Methods and Properties
	- Inheritance
		- we cannot have multiple interitance 
	- Polymorphism
- Class
	- Members with Access Specifiers
		- public, private, protected, internal, protected internal
			- public: Visiable to entire application
			- private: Only within the class, default for each member of the class
			- protected: Within declaring and derived class in same namespace
			- internal: Visiable across all classes with the namespace, this is default for all classes and interface 
			- protected internal: Same as 'internal' but also accessible across derived classed in different assembly
		- Members Types as follows
			- Data Members
				- Private, Public, Protected declarations those holds values for the class
			- Properties
				- Intelligent Fields because they have 'setter' and 'getter' blocks for defininmg logic for the private data member
			- Methods
			- Events 
	- Modifiers
		- Static, same as 'shared' thread-safe
		- abstract, class must be inherited
			- abstract class and abstract methods
				- abstract methgod must be overriden 
		- sealed, class cannot be inherited
		- virtual, for methods, these have implementation that can be either overriden or may be used as it is by the derived class
- The 'new' nmoniker, the keyword (aka operator) that is used to instantiate the object
	- The memory is allocated for the declaration	
- Code-Debugging
	- F9 key for Applying Breakpoints
	- F10, Step Over
	- F11, Strp into
	- F5 Run the Application
		

# Applied OOPs
- Using the OOPs concepts for Application Development
- Neatly implement 
	- Data Encapsulation, aka Properties
	- Behavior Abstratcion, aka Methods
		- A Generlize Behavior class that contains definition for generalized Read/Write Requirements  
		- Using 'abstract' class
			- It can have following modifiers for methods
				- The 'virtual' methods
					- They have implementation
				- The 'abstract' methods
					- The do not have any implementation (same as PURE Vurtual Function in C++) 
			- The abstrct class MUST be derived by the derived class(es)
				- The drived class MUST 'override' 'abstract' methods of the abstract class else the derive class MUST be modified as 'abstract' class
				- The derived class may or may not override the virtual methods of the abstract base class instaed derived class can directly access implementation of virtual methods
	- Inheritence
		- Code (aka Logic) reusability
			- Implementation of Open for extension Close for modification  Principal (OCP) 
	- Polymorphism
		- Runtime behavior that will be executed for the class method, based on the Invoking object as well as the input parameter(s)  for the method at runtime  
- Interfaces
	- Abstract classes are fastest in Cohesive System where all derivations are present within the system itself (Namespace or Assembly)
	- But if our need is to stablish communication accross systems (Homogeneous or Hetrogeneous) with decoupling then its always receommended to use 'Interface'
	- The 'interface' is a keyword
	- Its internal by default
	- All methods declared in interface uses same access specifier of the interface
	- Methods does not have any implementation (Note C# 9.0+ the interface method can have a default implementation)
	- IMP*****
		- a class can implement one-or-more interfaces
		- all methods of interface MUST be implemented by class
		- Interface can be implmented by class using one of the following way
			- Implicit: Methods are present in class and access by interface reference as well as class instance
			- Explict: Methods are present in class but they can be accessed only using the interface reference
				- This is recommended if the class implement multiple interfaces and these interfaces have same methods with same signeture 	


# Delegate and Event
- Delegate is like pointer to fucntion
- Technically
	- It is a .NET Type that invokes the method with its reference, provide the signeture of method MUST match with the signeture of the delegate
	- The Delegate encapsulate the method implementation, means we can directly write / provide an implementation to the delegate
		- Anonymous Methods
			- Extremly useful when a similar logic is to be executed frequently at various locations in the applicaton e.g. Collection Utilitiy Methods like Sort(), Reverse(), Find(), etc.
	- Since the delegate is type we can pass it as input parameter to method, if a method is accepting delegate as input parametere then to that method we can pass 'Lambda expression' as inout parameter
		- Syntax is    '=>'
	- Declare Events
		- The delegate that is used to declare an event MUST hav return type as 'void'
		- This means that the method that will be raing event will also be void
		- The event is declared inside the class using delegate and with 'event' keyword
		- The class that is used to listen to the notification MUST have the subscription of the Event Raiser class
			- This subscritpion is managed by passing an instance of the event raiser class as   the Constructor parameter to the Lister class  
	- Asynchronous Programming

- C#  Extensaion Methods
	- These are those methods which are accessed by the class although they are not present in the class and not even present in it derived class (if any)

	- We add extension method generally for Sealed classes
	- C# 3.0 Compilation Enhancements
		- Auto-Implemented Properties
		- Lambda Expression
		- Objhect Initializer /  Collection Initilizer
		- Extension Methods
	- Mechanism aka rules of Defining Extension Methods
		- The class containing extension method MUST be Static
		- The method that is used as extension method MUST be Static
		- The first parameter of this method MUST be 'this' referred raeefernce of the 'class' or 'interface' for which we are writing an extension method

````csharp
// 1. The class
public sealed MyClass {......}

// 2. Extension Method class
public static MyExtensionClass 
{
   public static void MyExtensionMethod(this MyClass m)
   {
   
   }
}

MyClass m = new MyClass();
m.MyExtensionMethod();
````

- Collection Framework
	- Enhanced approach to store and manipulate data in Application's Memory
	- Approach to store data in Apps memory w/o any size limit (by default its App Memoru provide by the Runtime)
	- System.Collections
		- The Enumerations 
		- ArrayList
		- Statck
		- Queue
		- .... any many more
	- All Entries in Collection are stored as 'object'
- The Generic Framework
	- An enhancement in Collections to create a 'type-safe' in-memory data storage to store and read data w/o boxing and unboxing
	- System.Collections.Generics
		- Generic Interfaces
````csharp
			- IEnumerable<T>, IList<T>, ICollection<T>, etc.
````
		- Classes
````csharp
			- List<T>, Queue<T>, Stack<T>, Dictionary<K,V>, etc.
````
		- The 'T' is template parameter, that represents the type for which the collection is created
		- The 'K' and 'V', the Multi-Type Generics

````csharp
  List<int> intList = new List<int>(); // Generic List instance only for integers
  List<string> strList = new List<string>();
````
	- When declaring Custom Generic types alway set type constraints on it so that the Compiler knows in advances that for which type the generic instance is created and it will inform this to runtime

- Language Integrated Query (LINQ)
	- a structured mechansim of Querying to In-Memory Collection like Database Queries
	- a Combination of Extension Methods and Lambda Expression
	- Enumerations, a class that contains extension methods, all these extension methods exeuted on the Collection Types
		- The interface 'IEnumerable&lt;T&gt;'  has all extension methods
			- Where(), Select(), OrderBy(), OrderByDescending(), Join(), GroupBy(), etc.
			- Each method accepts delegate as input parameter
				- Action,Action&lt;T&gt;
				- Func&lt;bool,Expression&gt;
					- if Expression is evaluated on collection then the bool will be true
			- Scalar Methods
				- Sum(), Avg(), Min(), Max(), etc. 
		- The Imperative Query like SQL is provide as Language Agonistic
			- select maps with Select
			- where maps with Where
			- order by maps with OrderBy
			- join maps with Join

# Line of Business Apps (LOB)
- Data Storage
	- RDBMS
	- NoSQL
	- Files
- Business Processes
	- Workflows 
		- Resource Intensive Operations*
			- Additional Process Utilization 
		- Resource Intensive Operations Solutons using Threads
			-  System.Threading Namespace
				- Threading class
				- ThreadStart Delegate
				- Monitor
				- Mutex
	
- UI

# Task Parallel Library (TPL)
- The Parallel Class
	- Responsible to request Runtime to allocate threads and perform operations on it
	- Methods
		- For(), Used to Process Collection Parallely where each collection is processed on seperate or reused thraed
		- ForEach(), Split the work to be done into multiple tasks (Threads) and process them parallely
		- Invoke()
			- Invokes multiple operations at a time and ask the runtime to execute them on multiple threads
- The Task Class
	- Unit of Async Operations performed by Runtime
	- A Task is a Thread
	- Default executed Asynchronously
	- Can Run multiple tasks and establish synchronization across them
		- Wait()
			- Wait for  a specific Taks or currently executing task to complete	 
		- WaitAll()
			- Wait for all running tasks or array of Specific Tasks to complete 
		- ContinueWith()
			- After completing first task take its result and move to the next task
		- Factory Object
			- An Object from which a Task can be assigned to perform operation on it  
			- Of the Type 'TaskFactory', this is used to request to the runtime to create a Schedular and allocate a Thread in it so that the opertaion can be executed Asynchronously 
		- A 'Result' property, this represents the data returned from Task
		
	- .NET Runtime Enhancements because of the Task Class (.NET Framework 4.5 and by default in .NET Core and .NET 5/6/7)
		- async and await modifiers 
			- If a method has TailWord as 'Async' then it is executed asynchronously and this method returns a Task Object
			- E.g.
				- Resource Intensive Methods are async
				- Database Operations
					- Task t = Connection.OpenAsync() 
				- File Operations
					- Task t = ReadFileAsync() 
				- Http / Network Operations
					- Task t = UploadAsync()	
		- While writjng code for Asynchronous Operations use the following rules
			- The Method Must be having TailWord as 'Async', its MUST return Task Object and such Mtheod while calling must be using modifier as 'await' 
			- e.g.
			 
````csharp
  // Only Task return menas the method is void and is executed asynchronously
	public async Task ReadDataAsync()
	{
	    var data = await File.ReadFileAsync(FILE-NAME);
	}

	// Calling Method

	await  ReadDataAsync();

	// Method Returns 'string' asynchronously using Task Object Task<string>
	public async Task<string> ReadDataReturnAsync()
	{
	    var data = await File.ReadFileAsync(FILE-NAME);
		return data;
	}

	// Calling Method

   string data = await ReadDataReturnAsync();

````

- File IO
	- System.IO Namepsace
		- Stream abstract class
			- FileStream, NetworkStream, and MemoryStream
				- FileStream
					- Sync and Async Methods 
			- StreamReader, StreamWriter
		- File, FileInfo
			- Create(), ReadAllText(), ReadLine(), AppendAllText() 
		- Directory, DirectoryInfo
		- Practices while Handling Files
			- Check If File Exists
			- If File is created based on name passed by the user then make sure that check the non-empty name
			- Always Close the FileHandle, so that the file is available to other request
			- Dispose the FileHanlde
			- Use the Exception Handling using try...catch block to prevent any error  



# ADO.NET
- System.Data Namespace 	
- System.Data.SqlClient for SQL Server DB
- SqlConnection
	- Open(), OpenAsync();
	- Close(), CloseAsync()
	- ConnectionString property
		- When using SQL Server Database with Windows Auth 
			- "Data Source={SERVER-NAME\INSTANCE-NAME};Initial Catalog={DATABASE-NAME};Integrated Security=SSPI"
			- OR
			- "Server={SERVER-NAME\INSTANCE-NAME};Database={DATABASE-NAME};Integrated Security=SSPI"
		- If using SQL Server Credentials
			- "Data Source={SERVER-NAME\INSTANCE-NAME};Initial Catalog={DATABASE-NAME};User Id={USER-NAME};Password={PASSWORD}" 
			- OR
			- "Server={SERVER-NAME\INSTANCE-NAME};Database={DATABASE-NAME};User Id={USER-NAME};Password={PASSWORD}"
		- SERVER-NAME: Machine NAme | IP ADDRESS Whene SQL Server Instance is Running
			- For Local MAchine use  SERVER-NAME  as . (dot) or localhost 
		- DATABASE-NAME: The name of the database to cdonnected
		- E.g.
			- If SQL database instance is on my local machine and database name is 'Company' the connection string will be as follows
				- "Data Source=.;Initial Catalog=Company;Integrated Security=SSPI"
			- If User Id = sa and Password=sa the connection string will be 
				- "Data Source=.;Initial Catalog=Company;User Id=sa; Password=sa"
- SqlCommand
	- ExecuteReader()/ExecuteReaderAsync()
	- ExecuteNonQuery()/ExecuteNonQueryAsync()
	- ExecuteScalar()/ExecuteScalarAsync()
- SqlDataRedaer 
	- Fasted Way to read data provided by database using the Select Query 
	- The Read(), metjod to start reading from First-Record to Last-record
	- The Close(), method to close tha reader
	- Over a single connection we can have 'only one' data reader active
	- To have multiple data readers i.e. reading data from multiple tables having multiple readers open, then connection string will be
		 -  "Data Source=.;Initial Catalog=Company;Integrated Security=SSPI;MultipleActiveResultSets=true"
	- Asynchronous Connection request to SQL Server Database, 
		-  "Data Source=.;Initial Catalog=Company;Integrated Security=SSPI;MultipleActiveResultSets=true;Asynchronous Processing=true"- In .Net Core (New its .NET 5/6/7), the System.Data.SqlClient package is not by default available we need to install it explicitly
	- Right-Click on Project, Select 'Manager NuGet Package', This will open the NuGet Package window, there search for System.Data.SqlCLient and onece found click on Install button .
	- OR
	- Navigate to Command Prompt (Terminal WIndow for Linux and Mac) (THIS IS required if usinf Visual Studio Code)
		- Navigate to the project folder (You MUST have bin directly inside this folder)
		- Runt the Following COmmand to install package for the Project
			- dotnet add package [PACXKAGE-NAME] -v [VERSION-NUMBER]
			- e.g.
				- dotnet add package System.Data.SqlClient  



# REST APIs using ASP.NET Core
- Microsoft.AspNetCore.App
	- MVC
	- Razor Views
	- API Controllers
		- ControllerBase as a base class for API Controllers
		- This contains Action Methods i.e. methods those are invoked over HttpRequest
		- Each Action  Method returns a Contract Named 'IActionResult'
			- for REST APIs this is JSON Data 
	- Dependency Injection
		- Containser that defines registration for following  objects
			- Security
				- Authentication and Authorization
			- Sessions
			- Caching
			- Cross-Origin-Resource-Sharing (CORS)
			- Custom Services as [er the application's business logic
			- Third Party Services
		- The 'IServiceCollection' a contract interface that provides an access to the Dependency Container 
			- Uses the 'ServiceDescriptor' class
				- This class manages all registrations as per the Lifetime Requirements
					- Singleton
						- Object will ve live and shared across all sessions
						- This object will be live till the app is running
					- Scopped
						- The object will be registead in DI Container and will be available for each new session and will be used throught the session
						- One the session is closed or timeout the object will be garbage collected
					- Transient
						- The Object will be created for each new request (This is stateless)
						- Once the response is send against that request the object will be garbage collected 
		- Configuration
		- The appSettings.json file
			- This contains following
				- Logging Configuration
				- Database Connection
				- Other application level settings e.g. Signerure for JSON Web Tokens
		- IConfiguration is the interface used to read this file
	- Hosting
		- Host the ASP.NET Core App default in 'Kestral Engine'
		- This manages following
			- a Public endpoint to accept requests from clients over HTTP
			- Dependency Injection Container
			- Middewares
				- IApplicationBuilder is a contract interfae used to Register Middlewares in the HTTP Pipeline 
				 - Defaults
					- Exception
					- HttpsRedirection
					- HSTS
					- Routing
					- CORS
					- StaticFiles
					- Custom Middlewares
					- Authentication
					- Authorization
					- EndPoint
			- The 'HttpContext'
				- This class represents a current HTTP Pipeline where Request Processing Takes Place 

# ASP Development Practically

- Data Access Layer using Entity Framework Core
	- ORM for Data Access
		- Microsoft.EntityFrameworkCore
			- DbContext Class
				- Used to Manage the Db COnnection, MApping with Tables, and Transaction to Commit data back to database
				- SaveChanges() / SaveChangesAsync(), COmmite the data to db (Complete DB Transaction) 
			- DbSet&lt;T&gt;
				- Map the CLR Class os name T with Database Table of name T
				- e.g. If class Name is Employee then Table Name will be Employee 
		- Microsoft.EntityFrameworkCore.SqlServer
			- Providfe SQL Server Type System Access and aConnection to Application usign EF Core 
		- Microsoft.EntityFrameworkCore.Ralational
			- For CLR to Table Mapping Management 
		- Microsoft.EntityFrameworkCor.Design
			- Used for Following Approaches
				- Database First
					- Generate Data Access Code and Table to Class Mapping from Ready to Use Database (Production Ready)
						- USe this in Migration app, you are migrating an existing app to .NET Core but want to use Database as it is
						- Command to use Dtaabase First, to be executed from Project Folder on Command Prompt 
````csharp
// 1. MAkse sure that the EF is installed in global scope
			dotnet tool install --global dotnet-ef
// 2. Scaffold (generate) EF Core Object Model from Database

			dotnet ef dbcontext scaffold "CONNECTION-STRING" Microsoft.EntityFramewotkCore.SqlServer -o [OUTPUT-FOLDER-TO-CREATE-ENTITIES]
// e.g.
	
	dotnet ef dbcontext scaffold "Data Source=.;Initial Catalog=Company;Integrated Security=SSPI"  Microsoft.EntityFramewotkCore.SqlServer -o Models
	// THis will generate the DbContext class and Entity Classes in the Models folder of the Project
````
				- Code-First
					- USe this when app is to be developed from scratch and which database is to be used is not known
						- Product Based Companies
					- We need to create Entity Classes (C# Classes with Public Properties)
					- Generate Database and table from it
````csharp
 // 1. Create Entity classes and DbCOntext class
 // 2. Run the Following Command to generate Db Migrations,  these are C# Code Scripts to create table(s)
		dotnet ef migrations add [MIGRATION-NAME] -c [NAMESPACE.DBCONTEXT-CLASS-NAME]
// 3. Update the Database, thsi will run Migration scripts to genberate Database and Tables
		dotnet ef database update -c [NAMESPACE.DBCONTEXT-CLASS-NAME]

````

		- Microsoft.EntityFrameworkCor.Tools

- Pseduo code for CRUD Operations using EF Core
- COnsider the DbContext is CompanyContext, the you create its instance as 'ctx'
- Conside CompanyContext has Employee Entity mapping as DbSet&lt;Employee&gt as 'Employees'

- To Read All Employees
	- var emps = ctx.Employees.ToList() / ctx.Employees.ToListAsync();
- To Extract a record based on Primary Key
	- var emp = ctx.Employees.Find(EMPNO) / ctx.Employees.FindAsync(EMPNO)

- To Create a new Employees
	- First Define an instance of EMployee and set its property values e.g. emp
	- Append this object in Employees
		- ctx.Employees.Add(emp); / ctx.Employees.AddAsync(emp);
	- Commit Transaction
		- ctx.SaveChanges() / ctx.SaveChangesAsync();

- To Add MUltiple Employees	
	- Define an array /  list of employees with values in it e.g. emps
	- Use AddRange() method
		- ctx.Employess.AddRange(emps) / ctx.Employess.AddRangeAsync(emps)

- To Update record based on Primary Key
	- Find Record based on Primary Key 
	- Update property values for this searched record
	- Commit Transaction

- To Delete Record
	- Find Record based on Primary Key 
		 - var emp = ctx.Employees.Find(EMPNO) / ctx.Employees.FindAsync(EMPNO)
	- Pass this object to remove method
		- ctx.Employees.Remove(emp);
	- Commit Transaction

- BulkUpate() and BulkDelete() method for DbCOntext 

- Use the following command when usign .NET 7 for Scaffolding
- 
dotnet ef dbcontext scaffold "Data Source=.;Initial Catalog=Company;Integrated Security=SSPI;TrustServerCertificate=Yes" Microsoft.EntityFrameworkCore.SqlServer -o Models

- ControllerBase
	- Base class for API Controllers
	- Contanis following
		- Properties
			- ModelState, of the type ModelStateDictionary
				- Used to valuidate incommind data for POST and PUT request based on the validation rules applied on entity classes
			- HttpContext, HttpRequest, HttpResponse
				- Create HTTP Pipeline and managing Request Processing
			- RouteData, of the type 'RouteData'
				- represents the current route expression 
		- Methods
			- Ok() return OkObjectResult, this represent JSON response to be send to client
			- BadRequest(), BadRequestResult
			- NotFound(), NotFoundResult
			- .... and many more
			- All these classes e.g. OkObjectResult, BadRequestResult, NotFoundResult, implement 'IActionResult'
				- A Contract interface that executes the Action Method from Controller and generate Response
	

# REST API Design Practices
- Always perform Model Validation before the model data is processed
	 - System.ComponentModel.DataAnnotations
		- ValidationAttribute abstract class
			- RequireAttribute, CompareAttribute, StringLengthAttribute, etc.
	 - Handle Exceptions
		- Apply Global level exceptions instaed of writing execfption handling in each action method
			- Middlewares
- Define Action Method Parameters with Suitable Parameter Binders (Varies case-to-case basis)
	- FromBody
	- FromQuery
	- FromRoute
	- FromForm
- Implement suitable security
	- Users
	- Roles
	- Token

# Core Components for every service aka APIs
- Exception Management
	- Make sure that the app is running against any type of process issures
	- The error handling MUST be applied at global level to listen applicaiton wide error or exceptions
	- The app MUST have capacility to execute a fallback logic to handle thses error w/o crashing the app
- Communication Management from Browser Clients
	- Creating a pool of allowed Origins to access the API with specific Headers as well as methods 
		- Corss Origin Resource Sharing (CORS)
	- Manage the Security
		- Authentication based on Users
		- Authorization based on roles and/or the Json Web Token (JWT)
- Deployment Management
	- On-Premises
	- Cloud


# Creating Custome Middleware
- The class containing logic for Custom Middleware MUST be constructor injected with 'RequestDelegate' delegate
- This delegate returns 'Task' (means and Async operations)
- The input parameter to the delegate is 'HttpContext', the Http request Pipeline 
- The class must define an 'InvokeAsync()' method that accepts input parameter as 'HttpContext' and returns Task, this method will be implicitly invoked by the RequestDelegate 
	- This method will contain logic for custom middleware

- To register this class as a custom middleware in pipeline, create an extension class
	- The class MUSt be static
	- The method MUST be static with the first parameter as 'IApplicationBuilder' 
	- IApplicationBuilder, interface has an extension method as follows
````csharp
UseMiddleware<T>
````
	- Here T is the class that is constructor injected with requestDelegate and Containing InvokeAsync method that mataches with the signeture of RequestDelegate 

# Identity
- Microsoft.AspNetCore.Identity
````csharp
	- UserManager<IdentityUser> // for User Management, CReate, Read, Update, etc.
	- RoleManager<IdentityRole> // for Role Management
	- SignInManager<IdentityUser> // for Login and Logout

	- Registration of Identity in DI Container in Hosting 

  // This will Register the UserManager, RoleManager, and SignInManager in DI Container
  // SO that we can Inject them
    builder.Services.AddIdentity<IdentityUser,IdentityRole>()
			.AddEntoityFrameworkStore(); // The database where IdentityInfo e.g. User and Roles are stored

  // COnfiggure Identity Middleware

   app.UseAuthentication();
   app.UseAuthorization();	

````
- Microsoft.AspNetCore.Identity.EntityFrameworkCore
	- IdentityUser, User Entity class that maps with AspNetUsers table in Database
	- IdentityRole, Role Entity class that maps with AspNetRoles table in Database
- System.IdentityModel.Tokens.Jwt
	- Provides 'ClaimIdentity' that will be used to specify the Authorization information in Json Web Token 
- Microsoft.AspNetCore.Authentication.JwtBearer
	- Classes to Generate JWT 	

# IFromFile interface
	This interface is used to Read file(s) received in HTTP Request
