using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckedBtn : MonoBehaviour
{
    public Button btn; 
    // Start is called before the first frame update
    void Start()
    {
        
        btn.onClick.AddListener(CheckedOne);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void CheckedOne()
    {
        Transform checken = btn.transform.parent;
        Transform item_friendO = checken.parent;
        string friend = item_friendO.GetChild(1).GetComponent<Text>().text;
        Debug.Log(friend);
        // string nickname = PlayerPrefs.GetString("loginUser");
        // checken.GetChild(0);
        // Image img1 = btn.GetComponentInParent<Image>();
    }
}
