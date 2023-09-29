
using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.SceneManagement;
using LitJson;
using UnityEngine.UI;


public class Workflow_loader : MonoBehaviour {



    public GameObject btn;

    //public Input test;

    //public string JasonFileName;
    public static json_dynamic_instantiation JDinstantiation;
    public static ScrollView scrollView;


    public static void WorkeFlowLOder(string FileName)
    {
        string SceneName = "Scn_" + FileName;
      

        if (SceneManager.GetSceneByName(SceneName).isLoaded)
            {
            //Loaded Scene
            SceneManager.LoadScene(SceneName, LoadSceneMode.Additive);

        }
        else
            { 
            //Creat eScene
            Scene newScene = SceneManager.CreateScene(SceneName);

            // Call json_dynamic_instantiation.LoadJsonFromFile 
            JDinstantiation.LoadJsonFromFile(FileName);

            // Call ScrollView 
            ScrollView scroll = scrollView;

            scroll.Button_Template.GetComponentInChildren<Text>().text = ("Start Workflow " + FileName);

            scroll.enabled = false;

        }






    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
