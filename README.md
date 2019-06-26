# ReSharperTestFailToRun

* Load the solution in VS2019 16.1.4 with R# 2019.1.2
* Open `MyClassValidationTests.cs` and ctrl-t, ctrl-r to run the tests
* Unit test sessions shows all green but if you expand Validation node you see the test didn't run with following error

  2019.06.26 18:05:40.409    WARN Element ReSharperTestFailToRun.Unit.Tests.MyClassTests+Validation+Name.NameIsCorrectlySet was left pending after its run completion.
