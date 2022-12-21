# countries-of-world
- Welcome to the Bright Dolphins Dotnet test. We want to capture your work into this repository.
## How to start:
- Pull the starter project from this github repo
- You have complete freedom to setup the API the way you want
- You may use any DB of your choosing
- Authenitication is not required
- The api should work as follows:
  - Countries have name, population and capital (1 Database table is fine)
  - GET GetCountryById retrieves country with all its data
  - GET GetAllCountries retrieves all countries names and population but doesn't include the capital
  - PUT UpdateCountry/{name} updates any field for country data
  - POST AddNewCountry with the request body containing all required country fields
## Deliverable:
- The project should build successfully without any errors
- Update the readme file with steps on how to run the application
- Push all your code to github before the deadline

# How to run the application
- Countries-of-world Restful APIs Application.
## How to run application:
- Go to Debug menu and then click start debuggin or press key F5.
- Can use Swagger UI test CRUD APIs method support as below.
  - GET api/Countries/GetCountryById
  - GET api/Countries/GetAllCountries
  - PUT api/Countries/UpdateCountry/{countryname}
  - POST api/Countries/AddNewCountry
  - DELETE api/Countries/DeleteCountry/{rowId}
## How to build application:
- Go to Build menu and then click publish countries-of-world.
- Click target do you want to destination.
