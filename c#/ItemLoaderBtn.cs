﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemLoaderBtn : MonoBehaviour {

    public Item myItem;

    
    public GameObject btn;

    //public Input test;

    public string JasonFileName;
   

    void Awake()
    {
       //string JasonFileName;

        JasonFileName = btn.GetComponentInChildren<Text>().text +".json";
        //FilePath = JasonFileName;
        //btn.GetComponentInChildren<Text>().text = "la di da";

        string myloadedItem = jsonFileReader.LoadJsonAsResource(JasonFileName);
        myItem = JsonUtility.FromJson<Item>(myloadedItem);





    }

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


    }
}
