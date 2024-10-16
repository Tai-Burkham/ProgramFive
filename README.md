## PROBLEM: MORE Analyzers!
This application is part of a game that allows a player to solve puzzles by searching for clues to solve a
murder mystery. Design a 3 level inheritance hierarchy with 5 classes for several different types of analyzers
for a forensic lab. Use Analyzer as the abstract base class of the hierarchy. Have a PrintAnalyzer to find as many
fingerprints (‘@’) as it can in a grid representing some object and a second analyzer to collect DNA/hair/fiber/etc.
samples in a grid representing a room. You should come up with a third analyzer class that inherits from the
second analyzer that is different enough from the other two, but has different member data / or overridden
methods from the second analyzer. Input for the crime will come from a file this time. Your instructor will give
you sample code to show you how to read data from a file – but you decide the file format and how you want to
store it. 
# Your program will do the following:
-  Have the user select the input data file
-  Allow the user t-  select what type of evidence t-  collect (via buttons)
-  Show the result of the evidence collection
   -  Returns a string t-  = displays the results of all fingerprints (‘@’) found in a label
   -  Returns a reference t-  = a 2D array of picture boxes created dynamically at run time t-  display an image of evidence collected (boundary lines could be visible or invisible?). Find some .png files
-  Displays a message indicating the success of the evidence collection
-  Displays a messages on the number of fingerprints or samples collected
-  Show a message box in some exception handler if there is some problem with the input file
# INPUT: 
D2L has a file that shows you how t-  read data from a file, but the input file format is up t-  you. User
should be able to:
-  enter the name of the file
-  enter the data from the file and store in object’s class variables
# OUTPUT: 
Output is all done on a form. The form should display:
-  The filename (case number/name)
-  Type of evidence currently being examined
-  Results of evidence collection: Success, number collected, “image”
# TURN IN all materials in a 9x12 envelope:
-  Print out of documented Source code
-  2 input files
-  Screen dump(s) of image(s) when running (indicate which input file it is using).
-  Project and Application on a flash memory stick. The application is in a debug folder.
-  Partner log file
-  Peer evaluation form
-  In an envelope
# Extra Credit
Dynamic 2D array Picture Boxs 
+5 points
