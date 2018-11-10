
# MVC5 Improved Custom Template
## My Custom made Template for MVC Applications created with the following in mind
Out of the box support for: Repository Pattern,Unit Of Work, Depedency Injection, Notifications, Global and Local Logging, Folder structure with Best Practices of JRMP(Javascript Revealing Module Patter) and more,made in order to solve the need to recreate the same structure over and over when starting new projects

![](https://i1.wp.com/codigosimples.net/wp-content/uploads/2016/03/mvc_logo.png?fit=250%2C200&ssl=1)

1. Repository Pattern
2. Unit Of Work Pattern
3. AutoMapper 6.2.2
4. Dependency Injection with Ninject
5. Entity Framework Migrations-Enabled
6. Font-Awesome 
7. Toastr
8. Global Logging With TrackerEnableContext
9. Folder Structure and Example for {Javascript's Revealing Module Pattern}
10. Identity Login with Username and NOT email.


### NuGet Packages and recommended versions

*1. Ninject MVC5 v3.2.1.0*
*2. Ninject.Web.WebApi v3.2.1*
*3. Ninject.Extensions.Conventions v.3.2.1*
*4. AutoMapper 6.2.2*
*5. FontAwesome 4.7.0*
*6. Toastr 2.1.1*
*7. TrackerEnabledIdentity 3.6.1*

# How To use 

1. Download and Run project in Visual Studio 2015+
2. Change Connection string inside of `Web.Config` to match that of the Database you will create in the next step
3. Run Update-Database inside of Package Manager Console
4. Run project with Ctrl-F5