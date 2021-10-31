using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backBtn : MonoBehaviour
{
    public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(CheckBack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CheckBack()
    {
        Image friendOPage = GameObject.Find("friendOPage").GetComponent<Image>();
        friendOPage.transform.localPosition = new Vector2(5000,0);
        Image findOPage = GameObject.Find("FindPage").GetComponent<Image>();
        findOPage.transform.localPosition = new Vector2(0,0);
        Image BottomNavBar = GameObject.Find("BottomNavBar").GetComponent<Image>();
        RectTransform BottomNavBar_Rt =  BottomNavBar.GetComponent<RectTransform>();
        BottomNavBar_Rt.anchoredPosition = new Vector2(0,65);
    }
}
