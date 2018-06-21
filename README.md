# contractor-test
for Wilhelm Mostert

## Development test
## Description	
I would like you to put together a website that displays a list of students and allows certain users 
to the able to create or edit a student’s record.  
The website should use a database and interact with the database using entity framework code first.  
The solution should use the “unit of work” and repository design patterns.  
When supplying the solution I should be able to generate the database from migrations.

## Student record
The Student record is made up of the following fields
·         Salutation (Mr, Miss, Mrs, Dr)
·         First name
·         Surname
·         Age
·         Gender (Male, Female)

## Student list page (Home page)
Any user can view the list of students, but only admins can add or edit them.  
The fields displayed in the list are:
·         Full name made up of Salutation, First name, Surname
·         Gender
·         Age
·         Edit link (only displays if you have permission to edit a record)

At the top of the page, there should be a button to add a new record, 
which only shows when you have permission to add a student.  
If you do not have permission to add a student, there should be a message in its place stating 
“You do not have the correct permissions to change student records.”

## Add/Edit student record
If the user has permission to add or edit a student record, the information will be displayed in a pop-up window.  
If I select “Add Student” you will display a pop-up window with the required fields highlighted, but no values entered.  
If I select edit on a student record you will display a pop-up window with the student information populated 
and required fields highlighted.  

The pop-up window should have a cancel button that cancels and changes and closes the window.  
There should also be a Save button that saves the changes, if the changes are valid and then close the window.  
If the information entered is not valid there should be validation information shown.  
If changes were saved, the student list should update itself.

# NOTES

## The solution contains 2 migrations
1. for the Asp.Net membership system and 
2. for the Database holding the students table

**Neither** of the above will provide *any seed records*.
However, a single user "sa@domain.com" in the 'SuperAdmin' role will be created (see Startup.cs for the password) 
allowing one to perform Admin functions like creating users, creating roles and assigning users to roles.

As per the spec above, a user needs to be in the Admin role in order for him to be allowed to edit/add Student records.
Note that this means even the SuperAdmin role cannot add/edit student records.

New users may also register - in this way they too will be added to the membership system.
Email validation/confirmation for new registrations has not been tested.

As a bare minimum the system needs one user in the Admin role in order to test the Student management fully.

Finally, this applicatiomn is not meant to be a complete, fully function app!








