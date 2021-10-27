using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewToggleScript : MonoBehaviour
{
    private GameObject _navBar;
    private void Awake()
    {
        _navBar = gameObject;
    }
    
    public void setActive(int dataIndex)
    {
        GameObject imageBar =  _navBar.transform.Find("ImageBar").gameObject;
        Image imageBarImg = imageBar.GetComponent<Image>();
        imageBarImg.sprite = Resources.Load(DataMgr.GetNavBarData(dataIndex,2), typeof(Sprite)) as Sprite;
    }
}
