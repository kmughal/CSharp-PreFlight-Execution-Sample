# Introduction

This is a sample code which demonstrates different approaches if you want to execute a code before your Main thread or 
Main application.

- Use a static constructor
- Decorate method with ``` [System.Runtime.CompilerServices.ModuleInitializer] ``` attribute
- Set an environment variable with the dll name before starting the app  DOTNET_STARTUP_HOOKS=myapp.dll
 