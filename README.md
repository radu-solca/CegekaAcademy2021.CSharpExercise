# CegekaAcademy2021.CSharpExercise


You are given the Student and University classes, and a Persistence class that handles access to a fictive database. The Persistence class implements 2 asynchronous generic methods: InsertAsync, and GetAllAsync. 

InsertAsync is used to insert any type of object into the database, but it has a few limitations: 
  - First, the object has to have a property "Id" that should be a valid string (non-null, max 10 characters, and should not contain the character '%'). Not respecting this rule will lead to a ArgumentException being thrown.
  - Second, the database has limited memory, so there is also a rule that a maximum of 3 objects of each type are allowed. Inserting a 4th item of the same type will lead to an InvalidOperationException beign thrown.

GetAllAsync is used to read all stored objects of a particular type. It will throw an InvalidOperationException if no items of the given type are stored.

Requirements:
  1. In the Program.cs, create a simple text based UI that allows the user to insert and read Students/Universities in the fictitious database.
  2. Do not reference the Persistence class directly in Program.cs - create instead service classes as needed to keep UI separated from persistence.
  3. Do not modify the Persistence class - assume this is 3rd party code outside of your control.
  4. Use generic types to remove any code duplication.
  5. Make sure exceptions are caught and handled accordingly - the program should still run after an exception is encountered, and the user should clearly see what happened.
  6. In case of an invalid Id, the peristence class will throw a generic "invalid Id" message - Implement logic to display clearer error massages.
