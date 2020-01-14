# DotNetCoreAngular
Repository using Angular in ASP.Net 3.1 core project

## Useful Angular CLI commands
### 1) Create component 
```ng g c <component name> -m <app>```  


```ng``` - Angular CLI  
```g```  - Generate  
```c```  - Component  
```<component name>``` - Specify the component name  
```-m``` - Specify which module  
```<app>``` - Which module it should be included  
#### Sample:  
```ng g c get-book -m app```  
- After run it will generate a new component and automatically added the dependencies in app.module.ts file.  

### 2) Create service 
```ng g s <service name>```  


```ng``` - Angular CLI  
```g```  - Generate  
```s```  - Component  
```<service name>``` - Specify the service name  
#### Sample:  
```ng g s book```  
- After run it will generate a new service but need to manually add dependencies to app.module.ts file and update the providers array.    