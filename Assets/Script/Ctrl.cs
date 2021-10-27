using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;


public class Ctrl : MonoBehaviour
{
    public MyToggle[] toggle;
    public IPanel[] panel;
    private MyToggle lastToggle;
    private IPanel lastPanel;
    // Start is called before the first frame update
    void Start()
    {
        for(var i = 0;i < toggle.Length;i++){
            toggle[i].onClick = OnClickToggle;
            toggle[i].index = i;
        }
    }

    // Update is called once per frame

    void OnClickToggle(MyToggle toggle){
        // 按钮切换
        if(lastToggle){
            lastToggle.SetActive(false);
        }
        lastToggle = toggle;
        lastToggle.SetActive(true);
        
        // 页面切换
        if(lastPanel != null){
            lastPanel.SetActive(false);
        }
        lastPanel = panel[toggle.index];
        lastPanel.SetActive(true);
    }
}