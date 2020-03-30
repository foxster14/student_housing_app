# Dunwoody Housing Application (Project 3)

Create a GUI application that allows a Resident Director to create new residents and look-up current residents who reside in the newly constructed Dunwoody residence hall.   Each resident can be searched by their Id number, and for each resident their first and last name is recorded along with their dorm room number, monthly rent/fee and floor they reside on.  Residents include student workers, scholarship recipients and athletes.  Each resident is responsible for paying monthly rent/fee.  Scholarship recipients pay a flat boarding fee of $100 monthly, student athletes pay $1200 monthly and student workers’ pay $1245 a month minus half of their monthly student worker pay (which is calculated by taking the monthly hours worked * base hourly rate).  The base hourly rate for a student worker is $14.00.  There are 8 floors, student worker only reside on floors 1- 3, student athletes reside on floors 4 – 6 and scholarship residents reside on floors 7 and 8.

#### The GUI application will consist of four or five tabs.

1.  Entry Tab - The first tab will be an entry screen that requests the RD who also lives in the hall to enter a generic password and username. The generic username is “home” and the password is “1234”.  Once the correct password is entered, the resident director will be presented with the selection tab.
2.  Selection Tab - The RD will be presented with a selection tab that will allow the RD to press a button to enter a new resident or press a button to search for current residents.
3.  New Resident Tab – If the RD presses the new resident button, the RD is then presented with a screen where they can select which type (scholarship, athlete, student worker) of resident they would like to enter. This tab should also include a button that allows the RD to return to the selection form.
4.  Resident Search Tab – If the RD presses the search resident’s button, a screen is presented where the RD can enter an ID number to search for students.  Please have a minimum of two residents in your text file.   The two residents should have the id #0001 and 0002.  Within this tab you will provide some analytical information(You may want to consider using LINQ to query the data.  
    1.  You will need to provide a total count for each type of student.
    2.  Provide the total number of students for each floor range (1-3, 4-6, 7-8)

## Requirements

Create using .NET Core Console Application

The Program should make use of Object Oriented Principles discussed in class and utilize additional class structures that implement inheritance and a level of abstraction. 

Your project must also handle all errors and exceptions that may possibly occur.


