# ASP.NET-MVC-Architecture
## Featuring:

Asp.Net MVC 5 Multi Layered Architecture using Generic Repository, Dependency Injection and Unit of Work
Motivation
The purpose of this Architecture is to provide a more advanced starting point for ASP.NET MVC apps that already features a well defined work-flow, state management and design layout.

The template is designed to be easy to build upon and extend to suit your app.

# Description

## 1.0 Project.UI/Architecture-project
This Layer contain all views and content that help to create views like CSS, JavaScript, Bootstrap all front related plugin's.

## 2.0 Logic Layer
This Layer Contains All Controller's of Application's to manage views also this layer contain Dependency Injection Configuration.

## 3.0 ServiceLayer
Service Layer Contain Interface And Concrete Classes That we can access in Controllers also we have UnitOfWork in  Service Layer.

## 4.0 DataLayer
Data Layer Contain all logic of DB Data Manipulation and generic repository to perform CRUD operations. 

## 5.0 Core
Core Layer Contains DB Model and Entity Class's of Database

## 6.0 BO
Business Object Layer Contains all Business entities to show data on front end views.

## 7.0 Util
This Layers Contains Common Functionality of applications Like Logs and Auto-mapper etc.
