using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class MyToggle : MonoBehaviour
{
    public Sprite activeSpr;
    public Sprite normalSpr;
    private Image _image;
    private Text _text;
    public Action<MyToggle> onClick;
    public int index;
    // Start is called before the first frame update
    void Awake()
    {
        _image = transform.GetChild(0).GetComponent<Image>();
        _text = transform.GetChild(1).GetComponent<Text>();
 
    }
    
    public void SetActive(bool active){
        if(active){
            _image.sprite = activeSpr;
            _text.color = new Color32(19, 150, 219,255);
        }else{
            _image.sprite = normalSpr;
            _text.color = new Color32(0, 0, 0,255);
        }
    }   

    public void Click(){
        onClick(this);
    }
}
