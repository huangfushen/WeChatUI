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
        
    }

    // Update is called once per frame
    void Update()
    {
        btn.onClick.AddListener(CheckedOne);
    }

    public void CheckedOne()
    {
        Transform checken = btn.transform.parent;
        Transform item_friendO = checken.parent;
        item_friendO.GetChild(1);
        // string nickname = PlayerPrefs.GetString("loginUser");
        checken.GetChild(0);
        // Image img1 = btn.GetComponentInParent<Image>();
    }
}
