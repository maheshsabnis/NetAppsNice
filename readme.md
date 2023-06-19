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
	

	
