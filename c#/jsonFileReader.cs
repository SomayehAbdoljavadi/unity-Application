using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class jsonFileReader  {
   // public string filepath;

    public static string LoadJsonAsResource(string path)
    {
        string jsonFilePath = path.Replace(".json", "");
        TextAsset loadedJsonfile = Resources.Load<TextAsset>(jsonFilePath);
        
        return loadedJsonfile.text;
    }
}
