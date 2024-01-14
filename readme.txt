A simple program that allows the user to select the best equipment for their industrial application.

technologies used:
	VisualStudio2013
		-C#
		-Sql
		-Windows Forms
refference list:
	layout
		https://www.youtube.com/watch?v=mdFgbdM8PYk
	other youtube vidoes and forums information that I lost track of


# database:
connection is a string with the path to the Database1.mdf file in this form:
Data Source=(LocalDB)\v11.0;AttatchDbFileName="<path>";Integrated Security=True
example:
"Data Source=(LocalDB)\\v11.0;AttachDbFilename=\"C:\\Users\\username\\...\\Project\\RobotDataBase\\Database1.mdf\";Integrated Security=True"

Files:
InsertMachine.cs
line 17 - private static String connection = ""
InsertRobot.cs
line 17 - private static String connection = ""
MachinesWindow.cs
line 20 - private static String connection = ""
RobotsWindow.cs
line 19 - private static String connection = ""
UpdateMachine.cs
line 17 - private static String connection = ""
UpdateMachinesWindow.cs
line 17 - private static String connection = ""
UpdateRobot.cs
line 17 - private static String connection = ""
UpdateRobotsWindow.cs
line 17 - private static String connection = ""

I removed the connection string for 2 reasons. 1) on a different computer (or path) the old string wouldn't work, and a new one needs to be put, to reflect the new path. 2) privacy, I did not wish to share my computer username, which was visible in the path.