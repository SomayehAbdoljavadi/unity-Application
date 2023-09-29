using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using LitJson;

[System.Serializable]
public class json_dynamic_instantiation : MonoBehaviour {

    public static json_dynamic_instantiation Instance;

	public Item myItem;

	// public GameObject btn;

	public string JasonFileName;
	public string Jsonstring;
	//  public dynamic testdy;
	public string Pjson;
	public string filename;
	private JsonData ItemData;

    public GameObject Prefab_Rect;

    public string CurrentJSONString = "";

    //constants
    private const string KEY_SCENE_ITEM_PROPERTIES = "SceneItemProperties";

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            if(Instance != this)
            {
                Destroy(this.gameObject);
            }
        }
    }


    private void Start() {
       // LoadJson();
	}

    IEnumerator CoroutineTest()
    {
        Debug.Log("CR WORKS!");
        yield return null;
    }

    public void CRFunctionTest()
    {
        StartCoroutine(CoroutineTest());
    }

    public void LoadJSON(string text)
    {
        if (!string.IsNullOrEmpty(text))
        {
            CurrentJSONString = text;
            //System.IO.StreamReader objReader;

            //objReader = new System.IO.StreamReader(filename, System.Text.Encoding.UTF8);
            //while (!objReader.EndOfStream)
            //{
                //Jsonstring = objReader.ReadLine();

                JsonReader r = new JsonReader(CurrentJSONString);

            if (r == null || !text.Contains("{"))
                return;

            ItemData = JsonMapper.ToObject(r);//JsonMapper.ToObject(Jsonstring);          

            if (!ItemData.Keys.Contains("CurrentWorkingStepNumber"))
                return;

            string CurrentWorkingStepNumber = Convert.ToString(ItemData["CurrentWorkingStepNumber"]);
            string SceneItemTyp = Convert.ToString(ItemData["SceneItemType"]);
            string WorkflowPath = Convert.ToString(ItemData["WorkflowPath"]);

            string m_SerVersionSceneItem = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_SerVersionSceneItem"]);
            string m_Id = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Id"]);
            string m_X = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_X"]);
            string m_Y = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Y"]);
            string m_Z = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Z"]);
            string m_Height = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Height"]);
            string m_Width = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Width"]);
            string m_Rotation = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Rotation"]);
            string m_Rx = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Rx"]);
            string m_Ry = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Ry"]);
            string m_Scale = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Scale"]);
            string m_Touchy = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Touchy"]);
            string m_Flash = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Flash"]);
            string m_FlashTimeOn = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_FlashTimeOn"]);
            string m_FlashTimeOff = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_FlashTimeOff"]);
            string m_IsAnimated = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_IsAnimated"]);
            string m_TargetX = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_TargetX"]);
            string m_TargetY = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_TargetY"]);
            string m_StartX = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_StartX"]);
            string m_StartY = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_StartY"]);
            string m_SerVersionSceneColor = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_SerVersionSceneColor"]);
            string m_Color = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Color"]);
            string m_ColorStart = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_ColorStart"]);
            string m_ColorEnd = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_ColorEnd"]);
            string m_IsColorPulsing = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_IsColorPulsing"]);
            string m_PluseTime = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_PluseTime"]);
            string m_SerVersion = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_SerVersion"]);


                if (ItemManager.HasKey(int.Parse(m_Id)))
                    return;


                String itemtype = SceneItemTyp.Remove(0, 23);
                Vector3 rawPosition = new Vector3(float.Parse(m_X), float.Parse(m_Y), float.Parse(m_Z));


                switch (itemtype)
                {
                    case "Rect":
                    GameObject cube_m17 = Instantiate(Prefab_Rect);//GameObject.CreatePrimitive(PrimitiveType.Cube);
                        //cube_m17.transform.position = new Vector3(float.Parse(m_X), float.Parse(m_Y), float.Parse(m_Z));

                        cube_m17.transform.position = Util_World.GetRelativePositionInWorld(rawPosition, Camera.main, true);
                        ItemManager.SetItem(cube_m17, int.Parse(m_Id));
                        cube_m17.name = "cube_" + m_Id;
                        break;
                    case "Circle":
                        GameObject sphere_m17 = Instantiate(Prefab_Rect);//GameObject.CreatePrimitive(PrimitiveType.Sphere);
                                                                         //sphere_m17.transform.position = new Vector3(float.Parse(m_X), float.Parse(m_Y), float.Parse(m_Z));
                    sphere_m17.transform.position = Util_World.GetRelativePositionInWorld(rawPosition, Camera.main, true);
                        ItemManager.SetItem(sphere_m17, int.Parse(m_Id));
                        sphere_m17.name = "sphere_" + m_Id;
                        break;

                    default:
                        GameObject g = Instantiate(Prefab_Rect);//GameObject.CreatePrimitive(PrimitiveType.Cube);
                                                                //cube_m17.transform.position = new Vector3(float.Parse(m_X), float.Parse(m_Y), float.Parse(m_Z));

                    g.transform.position = Util_World.GetRelativePositionInWorld(rawPosition, Camera.main, true);
                        ItemManager.SetItem(g, int.Parse(m_Id));

                        g.name = "default_cube_" + m_Id;
                        break;
                }
            //}

        }
    }

    public void LoadJsonFromFile(string text)
    {

        filename = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/kbl_workflows" + "/" + text;// workflow_000.json"; // Enter Json File Path here
        string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/kbl_workflows";
        if (Directory.Exists(dir))
        {
            Debug.Log("DIR EXISTS");
            string fname = dir + "/workflow_000.json";
            if (File.Exists(fname))
            {
                Debug.Log("FILE EXISTS!");
            }
            else
            {
                Debug.LogWarning("DIRECTORY EXISTS BUT FILE DOES NOT");
            }
        }
        else
        {
            Debug.Log("DIRECTORY DOES NOT EXIST");
        }

        if (System.IO.File.Exists(filename) == true)
        {
            System.IO.StreamReader objReader;

            objReader = new System.IO.StreamReader(filename, System.Text.Encoding.UTF8);
            while (!objReader.EndOfStream)
            {
                Jsonstring = objReader.ReadLine();

                JsonReader r = new JsonReader(Jsonstring);

                ItemData = JsonMapper.ToObject(new JsonReader(Jsonstring));//JsonMapper.ToObject(Jsonstring);                

                string CurrentWorkingStepNumber = Convert.ToString(ItemData["CurrentWorkingStepNumber"]);
                string SceneItemTyp = Convert.ToString(ItemData["SceneItemType"]);
                string WorkflowPath = Convert.ToString(ItemData["WorkflowPath"]);

                string m_SerVersionSceneItem = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_SerVersionSceneItem"]);
                string m_Id = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Id"]);
                string m_X = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_X"]);
                string m_Y = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Y"]);
                string m_Z = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Z"]);
                string m_Height = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Height"]);
                string m_Width = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Width"]);
                string m_Rotation = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Rotation"]);
                string m_Rx = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Rx"]);
                string m_Ry = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Ry"]);
                string m_Scale = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Scale"]);
                string m_Touchy = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Touchy"]);
                string m_Flash = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Flash"]);
                string m_FlashTimeOn = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_FlashTimeOn"]);
                string m_FlashTimeOff = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_FlashTimeOff"]);
                string m_IsAnimated = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_IsAnimated"]);
                string m_TargetX = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_TargetX"]);
                string m_TargetY = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_TargetY"]);
                string m_StartX = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_StartX"]);
                string m_StartY = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_StartY"]);
                string m_SerVersionSceneColor = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_SerVersionSceneColor"]);
                string m_Color = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_Color"]);
                string m_ColorStart = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_ColorStart"]);
                string m_ColorEnd = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_ColorEnd"]);
                string m_IsColorPulsing = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_IsColorPulsing"]);
                string m_PluseTime = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_PluseTime"]);
                string m_SerVersion = Convert.ToString(ItemData[KEY_SCENE_ITEM_PROPERTIES]["m_SerVersion"]);


                if (ItemManager.HasKey(int.Parse(m_Id)))
                    return;


                String itemtype = SceneItemTyp.Remove(0, 23);
                Vector3 rawPosition = new Vector3(float.Parse(m_X), float.Parse(m_Y), float.Parse(m_Z));


                switch (itemtype)
                {
                    case "Rect":
                        GameObject cube_m17 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        //cube_m17.transform.position = new Vector3(float.Parse(m_X), float.Parse(m_Y), float.Parse(m_Z));

                        cube_m17.transform.position = Util_World.GetRelativePositionInWorld(rawPosition, Camera.main, true);
                        ItemManager.SetItem(cube_m17, int.Parse(m_Id));
                        cube_m17.name = "cube_" + m_Id;
                        break;
                    case "Circle":
                        GameObject sphere_m17 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                        //sphere_m17.transform.position = new Vector3(float.Parse(m_X), float.Parse(m_Y), float.Parse(m_Z));
                        sphere_m17.transform.position = Util_World.GetRelativePositionInWorld(rawPosition, Camera.main, true);
                        ItemManager.SetItem(sphere_m17, int.Parse(m_Id));
                        sphere_m17.name = "sphere_" + m_Id;
                        break;

                    default:
                        GameObject g = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        //cube_m17.transform.position = new Vector3(float.Parse(m_X), float.Parse(m_Y), float.Parse(m_Z));

                        g.transform.position = Util_World.GetRelativePositionInWorld(rawPosition, Camera.main, true);
                        ItemManager.SetItem(g, int.Parse(m_Id));

                        g.name = "default_cube_" + m_Id;
                        break;
                }
            }

        }
    }

	void Update()
	{

	}
}
