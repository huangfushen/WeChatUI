using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class IPanel : MonoBehaviour
{
    public Action<MyToggle> onClick;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetActive(bool active){
        Vector2 show = new Vector3(0,0,0);
        Vector2 hidden = new Vector3(5000,0,0);
        if(active)
        {
            transform.localPosition = show;
        }else{
            transform.localPosition = hidden;
        }
    }

}
