# Cool C# Bootstrapper
A cool c# bootstrapper I made in a day (with testing and breaks of course) (I get frustrated very easily)

# What does it do?
Make a folder called whatever you want, (be careful editing the code)

Download a zip, (make sure it downloads from the right link and to the correct path)

Extract the contents of that zip to the folder, (make sure it extracts to the right folder)

And run the chosen exe file mentioned in the code. (by line 77 or line 115)

# How does it work? (there will be small pictures of the code here)
![QCZFbQRz](https://user-images.githubusercontent.com/70717570/148246399-df3b73a1-03ec-4851-86fd-e202a78ca2cb.png)

This is just loading the initial window text. (To tell the user what is going on)

The label named "TopLabel" is title of the window. (as I am using a borderless window)

The label named "checklabel" is to indicate the status of the program (so the user knows what is going on)

![k4wjhXNg](https://user-images.githubusercontent.com/70717570/148247061-dbe457b8-7a23-48f5-8f2b-c96b7869e929.png)

It then checks for a folder the user named (the default is called "bin", which you can change)

Then 2 other useless animations are called (by the help of the synapse x github repository)

![GISJ6EhJ](https://user-images.githubusercontent.com/70717570/148247612-6f5d4f24-3cf4-4e50-a6bf-90b2e9a9e0f5.png)

Now real code comes....

Checks if the directory named "bin" in this case exists.

If it does, then it proceeds to download the zip that you will be providing in the next section of code.

First it deletes all the files in the "bin" folder (in this case of course)

Then it downloads the zip file you have provided in the argument with "DirectDownloadLink", and downloads it to the folder you named.

Now it is extracting the file downloaded into the folder you named. (yes i see mistake and have fixed it)

Once done extracting it deletes any trace of zip files, and then tells the user that it is done and will launch the application.

# What happens if the bin folder isn't found?
Good question. It will make a bin folder and continue with the above.

# How do I use this?
![Joemama](https://user-images.githubusercontent.com/70717570/148248596-ccb91156-340f-43f2-89e9-bb8162bf1ff4.png)

Download the source code.
Open the .sln file.
And then edit it to your liking.

# It didn't work
Do everything commented in the source code (or don't be retarded)

-Make sure you've changed the "DirectDownloadLink" to a direct download of the zip file you are going to be extracting.

-Make sure if you've changed anything, that it is mentioned correctly in other lines of code.
