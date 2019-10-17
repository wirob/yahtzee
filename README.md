# yahtzee

In short, the assignment is to create an application that plays the dice game Yahtzee. You should create a domain model, a design model and an implementation of the game. My suggestion is that you work with the domain model first to understand the problem and then you iteratively design, implement, test and evaluate. The game does not need to be graphically attractive (a console application is good enough). The focus should be a good and solid design and a stable implementation. The following are the requirements:

- You should be able to play the game Yahtzee using the original rules and at least one variant of the game, for example Maxi-Yahtzee
- The game should consist of one human player and one computer
  - The player has a name
- The game result should be saved when it is over
- Two different lists for saved games should be available:
  - A compact list that shows the date, players and the total score for each player.
  - A full list that shows the date and the full scoring-sheet.
- Model-View-Controller architecture
- Good quality of code (for example naming, standards, duplication)
- An object oriented design and implementation. This includes but is not limited to:
  - Objects are connected using associations and not with keys/ids.
  - Classes have high cohesion and are not too large or have too much responsibility.
  - Classes have low coupling and are not too connected to other entities.
  - Avoid the use of static variables or operations as well as global variables.
  - Avoid hidden dependencies.
  - Information should be encapsulated.
  - Use a natural design, the domain model should inspire the design.
  - Use design patterns, GRASP and GoF, to solve design problems where appropriate.
- Tested – the application should work and not behave strangely during normal operations.
- Delivered with class diagram (domain and design model)and interaction diagram(s) for important parts, class diagram (design model that correspondto the implementation), source code, executable version.
