using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using LitJson;

[System.Serializable]

public class ItemManagement : MonoBehaviour
{

    // Use this for initialization




    public Item myItem;

    public GameObject btn;

    string JasonFileName;
    string Jsonstring;
    string Pjson;

    string id;
    string CubeName;



    private JsonData ItemData;


    private void Start()
    {

        // Jsonstring = File.ReadAllText(Application.dataPath + "/Resources/json2.json");
        //Debug.Log(Jsonstring);
        //ItemData = JsonMapper.ToObject(Jsonstring);
        //Debug.Log(ItemData["test"][1]["name"]);

        return;
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




        for (int i = 1; i < 7; i++)

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


                        id = n[0];
                        CubeName = "cube_" + id;


                        if (FindObject(CubeName))

                        {

                            //Make cube

                            btn.GetComponentInChildren<Text>().text = Pjson;
                            GameObject cube_17 = GameObject.CreatePrimitive(PrimitiveType.Cube);

                            Vector3 rawPosition = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));
                            cube_17.transform.position = Util_World.GetRelativePositionInWorld(rawPosition, Camera.main, true);
                            Debug.Log("Resulting Position = " + cube_17.transform.position + ", OriginalPosition = " + rawPosition);
                            cube_17.name = CubeName;

                            //Add to sceneitem

                            ItemDictionary.sceneitem.Add(id, CubeName);



                        }



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


                        id = n[0];
                        CubeName = "cube_" + id;



                        if (FindObject(CubeName))

                        {


                            //Make cube

                            btn.GetComponentInChildren<Text>().text = Pjson;
                            GameObject cube_16 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            //cube_16.transform.position = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));
                            Vector3 rawPosition = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));
                            cube_16.transform.position = Util_World.GetRelativePositionInWorld(rawPosition, Camera.main, true);
                            cube_16.name = CubeName;

                            //Add to sceneitem

                            ItemDictionary.sceneitem.Add(id, CubeName);


                        }


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

                        id = n[0];
                        CubeName = "cube_" + id;



                        if (FindObject(CubeName))

                        {

                            //Make cube

                            btn.GetComponentInChildren<Text>().text = Pjson;
                            GameObject cube_18 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            //cube_18.transform.position = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));
                            Vector3 rawPosition = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));
                            cube_18.transform.position = Util_World.GetRelativePositionInWorld(rawPosition, Camera.main, true);
                            cube_18.name = CubeName;

                            //Add to sceneitem

                            ItemDictionary.sceneitem.Add(id, CubeName);
                        }


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


                        id = n[0];
                        CubeName = "cube_" + id;

                        if (FindObject(CubeName))

                        {

                            //Make cube

                            btn.GetComponentInChildren<Text>().text = Pjson;
                            GameObject cube_16 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            //cube_16.transform.position = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));
                            Vector3 rawPosition = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));
                            cube_16.transform.position = Util_World.GetRelativePositionInWorld(rawPosition, Camera.main, true);
                            cube_16.name = CubeName;

                            //Add to sceneitem

                            ItemDictionary.sceneitem.Add(id, CubeName);
                        }



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



                        id = n[0];
                        CubeName = "cube_" + id;


                        if (FindObject(CubeName))

                        {

                            //Make cube

                            btn.GetComponentInChildren<Text>().text = Pjson;
                            GameObject cube_19 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            //cube_19.transform.position = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));
                            Vector3 rawPosition = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));
                            cube_19.transform.position = Util_World.GetRelativePositionInWorld(rawPosition, Camera.main, true);
                            cube_19.name = CubeName;

                            //Add to sceneitem

                            ItemDictionary.sceneitem.Add(id, CubeName);
                        }



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

                        id = n[0];
                        CubeName = "cube_" + id;


                        if (FindObject(CubeName))

                        {

                            //Make cube

                            btn.GetComponentInChildren<Text>().text = Pjson;
                            GameObject cube_20 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            //cube_20.transform.position = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));
                            Vector3 rawPosition = new Vector3(float.Parse(n[1]), float.Parse(n[2]), float.Parse(n[3]));
                            cube_20.transform.position = Util_World.GetRelativePositionInWorld(rawPosition, Camera.main, true);
                            cube_20.name = CubeName;

                            //Add to sceneitem

                            ItemDictionary.sceneitem.Add(id, CubeName);
                        }


                        break;
                    }
            }

        // print All Item in Dictionary
        foreach (string k in ItemDictionary.sceneitem.Keys)
            Debug.Log(k);




    }



    void Update()
    {




        //  Instantiate(cube, transform.position, transform.rotation);
    }
    public bool FindObject(string test)
    {
        foreach (GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())

            if (gameObj.name == CubeName)
            {

                this.gameObject.SetActive(true);
                return false;
            }

        return true;

    }
}
