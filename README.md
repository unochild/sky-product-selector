# sky-product-selector

## Tools / Technologies used

- ASP.NET 4.5.1 / MVC 5
- NUnit
- Moq
- Fluent Assertions
- Unity
- Bootstrap
- jQuery

## Building / Running the solution

- The solution requires VS 2013. Hitting F5 should restore missing nuget packages, build and run the solution.
- Unit tests were written using NUnit and can either be run using the ReSharper test runner or a standalone NUnit test runner (pointing at the compiled assemblies).

## Potential Improvements / Considerations (with more time)

- Write web tests to test the controllers / actions (mocking the service calls)
- UI tests - using selenium and coded UI tests using teststack seleno
- Implement proper DAL using an ORM (possible EF) rather than in memory repository
- Users selections currently not persisted (refreshing page clears them)