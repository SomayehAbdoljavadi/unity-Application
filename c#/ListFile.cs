using System.Collections.Generic;
using UnityEngine;
using System.IO;





public class ListFile : MonoBehaviour
{


    public string directoryPath;
    private List<string> fileNames;
    private string fullFilePath;
    private string outputMessage = "";
    private string dirOutputString = "";
    private Vector2 scrollPosition = Vector2.zero;
    private string fileNumberString = "0";


    void Start()
    {


        this.directoryPath = @"C:\Windows\Temp\";
        
        try
        {

            this.fileNames = new List<string>(Directory.GetFiles(this.directoryPath));


            for (int i = 0; i < this.fileNames.Count; i++)
            {

                this.fileNames[i] = Path.GetFileName(this.fileNames[i]);

                this.dirOutputString += i.ToString("D5") + "\t-\t" + this.fileNames[i] + "\n";
               // Console.WriteLine("Some Text");
            }
        }

        catch (System.UnauthorizedAccessException UAEx)
        {
            this.outputMessage = "ERROR: " + UAEx.Message;
        }
        catch (System.IO.PathTooLongException PathEx)
        {
            this.outputMessage = "ERROR: " + PathEx.Message;
        }
        catch (System.IO.DirectoryNotFoundException DirNfEx)
        {
            this.outputMessage = "ERROR: " + DirNfEx.Message;
        }
        catch (System.ArgumentException aEX)
        {
            this.outputMessage = "ERROR: " + aEX.Message;
        }
    }
    void OnGUI()
    {
       /* GUI.Button(new Rect(100, 150, 100, 40), "yoohooo");
        GUI.Button(new Rect(100, 200, 500, 50), this.directoryPath);
        GUI.Button(new Rect(100, 300, 100, 40), "yoohooo");
        GUI.Button(new Rect(100, 350, 500, 50), this.directoryPath);
        GUI.Button(new Rect(100, 400, 100, 40), "yoohooo");
       // GUI.Button(new Rect(100, 450, 500, 50), this.directoryPath);
       // GUI.Button(new Rect(100, 500, 100, 40), "yoohooo");
        //GUI.Button(new Rect(100, 550, 500, 50), this.directoryPath);*/

        if (outputMessage.Contains("ERROR: "))
        {

            GUI.Label(new Rect(25, Screen.height - 50, Screen.width, 100), this.outputMessage);

            return;
        }


        GUI.Label(new Rect(25, 25, Screen.width, 100), "Directory: " + this.directoryPath + "   Files found: " + this.fileNames.Count);
        GUILayout.BeginArea(new Rect(25, 50, Screen.width - 50, Screen.height - 100));

        this.scrollPosition = GUILayout.BeginScrollView(this.scrollPosition, GUILayout.Width(Screen.width - 50), GUILayout.Height(Screen.height - 100));

        GUILayout.TextArea(this.dirOutputString);

        GUILayout.EndScrollView();

        GUILayout.EndArea();


        GUI.Label(new Rect(25, Screen.height - 40, 250, 30), "Input a file number:");


        this.fileNumberString = GUI.TextField(new Rect(140, Screen.height - 40, 60, 30), this.fileNumberString, 5);


        if (GUI.Button(new Rect(210, Screen.height - 40, 150, 30), "Select file!"))
        {

            int fileIndex = int.Parse(this.fileNumberString);


            if (fileIndex >= this.fileNames.Count)
            {

                this.outputMessage = "Index out of range. Please enter a number between 0 and " + (this.fileNames.Count - 1).ToString();
                return;
            }


            this.fullFilePath = this.directoryPath + @"\" + this.fileNames[fileIndex];


            if (File.Exists(this.fullFilePath))
            {

                this.outputMessage = "Selected file:  " + this.fullFilePath;
            }
            else
            {

                this.outputMessage = "ERROR: FILE NOT FOUND!";
            }
        }


        GUI.Label(new Rect(380, Screen.height - 40, Screen.width, 300), this.outputMessage);
    }
}
