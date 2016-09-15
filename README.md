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

- The solution requires VS 2013. Hitting F5 should restore missing nuget packages, build and run the solution (you might need to click 'restore missing packages' from the package manager window).
- Unit tests were written using NUnit can be found under a solution folder called 'Tests'. The VS test runner doesn't seem to pick these up. I'm using ReSharper's test runner but you should be able to use any NUnit test runner and point it at the compiled assemblies. 

## Potential Improvements / Considerations (with more time)

- Write web tests to test the controllers / actions (mocking the service calls)
- UI tests - using selenium and coded UI tests using teststack seleno
- Implement proper DAL using an ORM (possibly Entity Framework) rather than in memory repository
- Product selections currently not persisted (refreshing page clears them)
- Use Knockout / Angular for frontend - the current functionality is v simple so I felt it was probably overkill for this.
- Use code coverage tool