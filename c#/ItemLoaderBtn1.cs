using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using LitJson;



[System.Serializable]
public class ItemLoaderBtn1 : MonoBehaviour
{



    public Item myItem;

    public GameObject btn;

    string JasonFileName;
    string Jsonstring;
    string Pjson;
    

    private JsonData ItemData;


    private void Start()
    {






        // Jsonstring = File.ReadAllText(Application.dataPath + "/Resources/json2.json");
        //Debug.Log(Jsonstring);
        //ItemData = JsonMapper.ToObject(Jsonstring);
        //Debug.Log(ItemData["test"][1]["name"]);


        Jsonstring = File.ReadAllText(Application.dataPath + "/Resources/workflow_example.json");
        //Debug.Log(Jsonstring);
        ItemData = JsonMapper.ToObject(Jsonstring);
        // Debug.Log(ItemData["m_WorkingsSteps"]["$values"][0]["m_Name"]);
        //Pjson = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_Name"]);
        //   Pjson = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Id"]);
        String[] n = new String[100];

        // ItemDictionary.MyDictionary.Add(1, "test");
        // Pjson = ItemDictionary.MyDictionary[1];
        //Debug.Log(ItemDictionary.MyDictionary[1]);




        for (int i = 1; i <= 6; i++)
            switch (i)
            {
                case 1:
                    {
                        //m17       Pjson = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Id"]);

                        n[0] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Id"]);
                        n[1] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_X"]);
                        n[2] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Y"]);
                        n[3] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Z"]);
                        n[4] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Height"]);
                        n[5] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Width"]);
                        n[6] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Rotation"]);
                        n[7] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Rx"]);
                        n[8] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Ry"]);
                        n[9] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Scale"]);
                        n[10] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Touchy"]);
                        n[11] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Flash"]);
                        n[12] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_FlashTimeOn"]);
                        n[13] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_FlashTimeOff"]);
                        n[14] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_IsAnimated"]);
                        n[15] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_TargetX"]);
                        n[16] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_TargetY"]);
                        n[17] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_StartX"]);
                        n[18] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_StartY"]);
                        n[19] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_SerVersion"]);

                        //Make cube
                        btn.GetComponentInChildren<Text>().text = Pjson;
                        GameObject cube_m17 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        cube_m17.transform.position = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));

                       
                        break;
                    }
                case 2:
                    {
                        //m16_01  Pjson = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Id"]);



                        n[0] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Id"]);
                        n[1] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_X"]);
                        n[2] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Y"]);
                        n[3] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Z"]);
                        n[4] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Height"]);
                        n[5] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Width"]);
                        n[6] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Rotation"]);
                        n[7] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Rx"]);
                        n[8] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Ry"]);
                        n[9] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Scale"]);
                        n[10] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Touchy"]);
                        n[11] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Flash"]);
                        n[12] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_FlashTimeOn"]);
                        n[13] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_FlashTimeOff"]);
                        n[14] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_IsAnimated"]);
                        n[15] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_TargetX"]);
                        n[16] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_TargetY"]);
                        n[17] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_StartX"]);
                        n[18] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_StartY"]);
                        n[19] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_SerVersion"]);


                        //Make cube
                        btn.GetComponentInChildren<Text>().text = Pjson;
                        GameObject cube_m16_01 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        cube_m16_01.transform.position = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));

                        
                        break;

                    }
                case 3:
                    {
                        //m18        Pjson = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Id"]);



                        n[0] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Id"]);
                        n[1] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_X"]);
                        n[2] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Y"]);
                        n[3] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Z"]);
                        n[4] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Height"]);
                        n[5] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Width"]);
                        n[6] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Rotation"]);
                        n[7] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Rx"]);
                        n[8] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Ry"]);
                        n[9] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Scale"]);
                        n[10] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Touchy"]);
                        n[11] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Flash"]);
                        n[12] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_FlashTimeOn"]);
                        n[13] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_FlashTimeOff"]);
                        n[14] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_IsAnimated"]);
                        n[15] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_TargetX"]);
                        n[16] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_TargetY"]);
                        n[17] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_StartX"]);
                        n[18] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_StartY"]);
                        n[19] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_SerVersion"]);

                        //Make cube
                        btn.GetComponentInChildren<Text>().text = Pjson;
                        GameObject cube_m18 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        cube_m18.transform.position = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));

                  
                        break;
                    }
                case 4:
                    {
                        //m16_02  Pjson = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_Id"]);



                        n[0] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_Id"]);
                        n[1] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_X"]);
                        n[2] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_Y"]);
                        n[3] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_Z"]);
                        n[4] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_Height"]);
                        n[5] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_Width"]);
                        n[6] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_Rotation"]);
                        n[7] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_Rx"]);
                        n[8] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_Ry"]);
                        n[9] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_Scale"]);
                        n[10] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_Touchy"]);
                        n[11] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_Flash"]);
                        n[12] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_FlashTimeOn"]);
                        n[13] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_FlashTimeOff"]);
                        n[14] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_IsAnimated"]);
                        n[15] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_TargetX"]);
                        n[16] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_TargetY"]);
                        n[17] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_StartX"]);
                        n[18] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_StartY"]);
                        n[19] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][0]["m_AdaptiveScenes"]["$values"][1]["m_Scene"]["m_Items"]["$values"][0]["m_SerVersion"]);


                        //Make cube
                        btn.GetComponentInChildren<Text>().text = Pjson;
                        GameObject cube_m16_02 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        cube_m16_02.transform.position = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));

                        
                        break;
                    }
                case 5:
                    {
                        //m19        Pjson = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Id"]);


                        n[0] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Id"]);
                        n[1] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_X"]);
                        n[2] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Y"]);
                        n[3] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Z"]);
                        n[4] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Height"]);
                        n[5] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Width"]);
                        n[6] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Rotation"]);
                        n[7] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Rx"]);
                        n[8] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Ry"]);
                        n[9] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Scale"]);
                        n[10] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Touchy"]);
                        n[11] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Flash"]);
                        n[12] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_FlashTimeOn"]);
                        n[13] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_FlashTimeOff"]);
                        n[14] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_IsAnimated"]);
                        n[15] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_TargetX"]);
                        n[16] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_TargetY"]);
                        n[17] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_StartX"]);
                        n[18] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_StartY"]);
                        n[19] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_SerVersion"]);



                        btn.GetComponentInChildren<Text>().text = Pjson;
                        GameObject cube_m19 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        cube_m19.transform.position = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));
                        

                        break;
                    }
                case 6:
                    {

                        //m20     Pjson = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Id"]);

                        n[0] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Id"]);
                        n[1] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_X"]);
                        n[2] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Y"]);
                        n[3] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Z"]);
                        n[4] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Height"]);
                        n[5] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Width"]);
                        n[6] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Rotation"]);
                        n[7] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Rx"]);
                        n[8] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Ry"]);
                        n[9] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Scale"]);
                        n[10] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Touchy"]);
                        n[11] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_Flash"]);
                        n[12] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_FlashTimeOn"]);
                        n[13] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_FlashTimeOff"]);
                        n[14] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_IsAnimated"]);
                        n[15] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_TargetX"]);
                        n[16] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_TargetY"]);
                        n[17] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_StartX"]);
                        n[18] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_StartY"]);
                        n[19] = Convert.ToString(ItemData["m_WorkingsSteps"]["$values"][1]["m_AdaptiveScenes"]["$values"][0]["m_Scene"]["m_Items"]["$values"][0]["m_SerVersion"]);


                        //Make cube
                        btn.GetComponentInChildren<Text>().text = Pjson;
                        GameObject cube_m20 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        cube_m20.transform.position = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));


              
                        break;
                    }
            }



    }
    void Update()
    {




        //  Instantiate(cube, transform.position, transform.rotation);
    }
}