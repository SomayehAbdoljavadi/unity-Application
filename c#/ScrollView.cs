using System.Collections.Generic;
using UnityEngine;
using System.IO;




public class ScrollView : MonoBehaviour
{
	public GameObject Button_Template;
	//private List<string> NameList = new List<string> ();


	public string directoryPath;
	private List<string> fileNames;
	private string fullFilePath;
	private string outputMessage = "";
	private string dirOutputString = "";
	private Vector2 scrollPosition = Vector2.zero;
	private string fileNumberString = "0";

    public static Workflow_loader workflow_Loader; 

	// Use this for initialization
	void Start ()
	{

        this.directoryPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/kbl_workflows";//@"c:\temp" ;

		try
		{

			this.fileNames = new List<string>(Directory.GetFiles(this.directoryPath));


			for (int i = 0; i < this.fileNames.Count; i++)
			{

				this.fileNames[i] = Path.GetFileName(this.fileNames[i]);

				//this.dirOutputString += i.ToString("D5") + "\t-\t" + this.fileNames[i] + "\n";
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





		foreach (string str in fileNames) {
			GameObject go = Instantiate (Button_Template) as GameObject;
			go.SetActive (true);
			Button TB = go.GetComponent<Button> ();
			TB.SetName (str);
			go.transform.SetParent (Button_Template.transform.parent);
            go.transform.localScale = Button_Template.transform.localScale;
		}


	}

	public void ButtonClicked (string str)
	{
		Debug.Log (str + " button clicked.");
        Workflow_loader.WorkeFlowLOder(str);
       

	}
}
