using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public static Main Instance;
    
    private void Awake()
    {
        DataObj.InitData();
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ToLogin();
        GetComponent<FriendOScrollView>().SetData(0,10);
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

    public void ToLogin()
    {
        Image LoginPage = GameObject.Find("LoginPage").GetComponent<Image>();
        LoginPage.transform.localPosition = new Vector3(0, 0);
        
    }

    public void IntoGame()
    {
        GetComponent<Ctrl>().SetDefIndex(0);
        GetComponent<IndexScrollView>().SetData(0,10,OnCreateItem,OnDelItem);
        GetComponent<FriendScrollView>().SetData(0,10,OnCreateItem,OnDelItem);
        GetComponent<FindScrollView>().SetData(0,10,OnCreateItem,OnDelItem);
        GetComponent<MeScrollView>().SetData(0,6,OnCreateItem,OnDelItem);
 
    }

}
