# CustomerCRUD -- This is a project to create, edit and list customers. Built with .Net Core 6.0 and Angular 17
## I spent about 2 hours working on the project. Although it wasn't 2 hours at once, I took breaks at some point to attend to other things. I started late in the night and completed the backend but didn't start the UI till this afternoon.
## The BackEnd API took me less than an hour. However, I spent a longer time on the frontend. I am backend heavy and ran into some problems with Angular 17 during development.
## On the Frontend, I used Angular 17.
### I used a service oriented architecture. Whereby, I had a backend API and frontend client to consume the API. This is to allow loose coupling and to ensure the backend can be reuseable by other client like a mobile app. It would also allow us test both parts of the application independently.
### The Backend API was also broken down into different layers i.e service, data , presentation. This allowed for efficient unit testing and separation of concerns.
### I also added an ID to the customer class to make sure it has a unique value as we may have customers with the same name.
## No serious issues, just ran into some Server-side rendering using Angular 17.I didn't get to add validation to the frontend and add the modal.
## I would had further validation, more logging, add authentication and authourization, user automapper to map DTOs, implement the modal as requested, add a repository layer for db connection to persist the data.

