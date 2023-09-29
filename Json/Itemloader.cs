using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using LitJson;



public class Itemloader : MonoBehaviour
{



    public Item myItem;

    public GameObject btn;

    public string JasonFileName;
    public string Jsonstring;
    public dynamic testdy;
    public string Pjson;

    private JsonData ItemData;

    private void Start()
    {
        /*  Jsonstring = File.ReadAllText(Application.dataPath + "/Resources/json1.json");
          //Debug.Log(Jsonstring);
           ItemData = JsonMapper.ToObject(Jsonstring);
           Debug.Log(ItemData["test"][1]["name"]);
       */

        Jsonstring = File.ReadAllText(Application.dataPath + "/Resources/workflow_example.json");
        //Debug.Log(Jsonstring);
        ItemData = JsonMapper.ToObject(Jsonstring);
        Debug.Log(ItemData["$values"][0]["m_Name"]);

    }



    //  public string djason;


    //void Awake() {




    // string JasonFileName;


    ///sonFileName = btn.GetComponentInChildren<Text> ().text + ".json";
    //btn.GetComponentInChildren<Text>().text = "la di da";

    ///ring myloadedItem = jsonFileReader.LoadJsonAsResource (JasonFileName);
    //dynamic	test = JsonFileReader.loadJsonAsResource (JasonFileName);
    ///Item = JsonUtility.FromJson<Item> (myloadedItem);




    ///ondata = File.ReadAllText("Assets/Resources/workflow_example.json");




    //damic datajson =jsonFileReader.LoadJsonAsResource (Jsondata);
    //dynamic pjason = datajson.m_AssemblyZoneLayout;


    // get name token of first person and convert to a string
    //Pjson = (string)datajson.m_AssemblyZoneLayout;

    // Pjson = Convert.ToString(datajson.m_AssemblyZoneLayout);


    //Console.WriteLine(datajson.m_AssemblyZoneLayout);




    //}
}
