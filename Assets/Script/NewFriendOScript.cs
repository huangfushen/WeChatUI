using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewFriendOScript : MonoBehaviour
{
    private GameObject message;
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
        string nickname = PlayerPrefs.GetString("loginUser");
        message.name = index.ToString();
        GameObject mess_head =  message.transform.Find("Image_header").gameObject;
        Image mess_head_color = mess_head.GetComponent<Image>();
        mess_head_color.color = HexToColor(DataMgr.GetData(dataIndex,0));
            
        GameObject mess_text_name =  message.transform.Find("Text_item").gameObject;
        Text mess_text = mess_text_name.GetComponent<Text>();
        mess_text.text = DataMgr.GetData(dataIndex,1);
            
        GameObject mess_content =  message.transform.Find("Text_content").gameObject;
        Text mess_content_text = mess_content.GetComponent<Text>();
        mess_content_text.text = DataMgr.GetFriendOData(dataIndex);
        GameObject checken =  message.transform.Find("checken").gameObject;
        GameObject like = checken.transform.Find("check_btn").gameObject;
        GameObject users = checken.transform.Find("check_users").gameObject;
        Text user_text = users.GetComponent<Text>();
        string cache_data = PlayerPrefs.GetString(DataMgr.GetData(dataIndex,1)+"_friend");
        if(cache_data != "" && cache_data.IndexOf(nickname) == 0)
        {
            Image like_img = like.GetComponent<Image>();
            like_img.sprite = Resources.Load("like", typeof(Sprite)) as Sprite;
        }
        user_text.text = cache_data;
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
}
