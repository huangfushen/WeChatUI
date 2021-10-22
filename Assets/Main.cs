using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<IndexScrollView>().SetData(0,10,OnCreateItem,OnDelItem);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<IndexScrollView>().SetData(0,10,OnCreateItem,OnDelItem);
        }
    }

    void OnCreateItem(GameObject go)
    {
        
    }

    void OnDelItem(GameObject go)
    {
        
    }
}
