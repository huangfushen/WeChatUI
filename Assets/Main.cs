using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    private void Awake()
    {
        DataObj.InitData();
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<IndexScrollView>().SetData(0,10,OnCreateItem,OnDelItem);
        GetComponent<FriendScrollView>().SetData(0,10,OnCreateItem,OnDelItem);
        GetComponent<FindScrollView>().SetData(0,10,OnCreateItem,OnDelItem);
        GetComponent<MeScrollView>().SetData(0,6,OnCreateItem,OnDelItem);
        GetComponent<FriendOScrollView>().SetData(0,10,OnCreateItem,OnDelItem);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<IndexScrollView>().SetData(0,10,OnCreateItem,OnDelItem);
            GetComponent<FriendScrollView>().SetData(0,10,OnCreateItem,OnDelItem);
            GetComponent<FindScrollView>().SetData(0,10,OnCreateItem,OnDelItem);
            GetComponent<MeScrollView>().SetData(0,6,OnCreateItem,OnDelItem);
        }
    }

    void OnCreateItem(GameObject go)
    {
        
    }

    void OnDelItem(GameObject go)
    {
        
    }
}
