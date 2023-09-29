using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class perfab_test : MonoBehaviour {

    private string jsonString;
    public GameObject myPrefab;

   //public object JsonHelper { get; private set; }

    // Use this for initialization
    void Start()
    {
        jsonString = File.ReadAllText("Assets/Resources/Apply.json");

        ClassObject[] cos = JsonHelper.getJsonArray<ClassObject>(jsonString);
          

        foreach (ClassObject co in cos)
        {
            // Generate prefab
            GameObject card = (GameObject)Instantiate(myPrefab, transform.position, transform.rotation);

            // Add data to prefab
        }
    }
}

[System.Serializable]
public class ClassObject
{
    public float m_X;
    public float m_Y;
    public float m_Z;
    public float m_Width;
    public float m_Height;
    public string m_Name;
}

