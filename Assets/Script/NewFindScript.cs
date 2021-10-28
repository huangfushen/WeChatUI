using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewFindScript : MonoBehaviour
{
    private GameObject message;
    public Button btn; 
    // Start is called before the first frame update
    void Awake()
    {
        message = gameObject;
    }

    public void SetPos(Vector2 position)
    {
        var rt = message.GetComponent<RectTransform>();
        rt.anchoredPosition = position;
    }
    public void SetData(int index,int dataIndex)
    {
        message.name = index.ToString();
        GameObject mess_head =  message.transform.Find("Image_header").gameObject;
        Image mess_head_img = mess_head.GetComponent<Image>();
        mess_head_img.sprite = Resources.Load(DataMgr.GetFindData(dataIndex,0), typeof(Sprite)) as Sprite;
        
        GameObject mess_text_name =  message.transform.Find("Text_item").gameObject;
        Text mess_text = mess_text_name.GetComponent<Text>();
        mess_text.text = DataMgr.GetFindData(dataIndex,1);
        string findTitle = DataMgr.GetFindData(dataIndex,1);
        if (findTitle == "朋友圈")
        {
            btn.onClick.AddListener(trunFriendO);
        }
    }
    
    private Color HexToColor(string hex)
    {
        byte br = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
        byte bg = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
        byte bb = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
        byte cc = byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);
        
        float r = br / 255f;
        float g = bg / 255f;
        float b = bb / 255f;
        float a = cc / 255f;
  
        return new Color(r, g, b, a);
    }
    
    private void trunFriendO()
    {
        Debug.Log("我被点击了");
    }
}
