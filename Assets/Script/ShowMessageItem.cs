using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMessageItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(ColorToHex(new Color32(18, 150, 220,255)));
        GameObject parent =  GameObject.Find("Content_message");
        string [,] data = new string [9,4] {
            {"1296DCFF","小黄","11","上午 00:00"} ,  
            {"1426DCFF","小红","22","上午 01:00"} ,  
            {"1296ACFF","小白","33","上午 02:00"} ,
            {"1296ACFF","小黑","44","上午 03:00"} ,
            {"1216ACFF","小绿","55","上午 04:00"} ,
            {"1296AAFF","小橙","66","上午 05:00"} ,
            {"1296ACFF","小灰","77","上午 06:00"} ,
            {"1210ACFF","大白","88","上午 07:00"} ,
            {"1222ACFF","大黑","99","上午 08:00"} 
        };
        GameObject message_item = (GameObject)Resources.Load("Prefabs/item");
        for(int i = 0;i<data.GetLength(0);i++)
        {
            float y = 130 - i * 130;
            Vector2 position = new Vector2(375,y);
            GameObject message = Instantiate(message_item,position,Quaternion.identity);
            GameObject mess_head =  message.transform.Find("Image_header").gameObject;
            Image mess_head_color = mess_head.GetComponent<Image>();
            mess_head_color.color = HexToColor(data[i,0]);
            
            GameObject mess_text_name =  message.transform.Find("Text_item").gameObject;
            Text mess_text = mess_text_name.GetComponent<Text>();
            mess_text.text = data[i, 1];
            
            GameObject mess_content =  message.transform.Find("Text_content").gameObject;
            Text mess_content_text = mess_content.GetComponent<Text>();
            mess_content_text.text = data[i, 2];
            
            GameObject mess_time =  message.transform.Find("Text_time").gameObject;
            Text mess_time_text = mess_time.GetComponent<Text>();
            mess_time_text.text = data[i, 3];
            
            
            message.transform.parent = parent.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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
    
    public static string ColorToHex(Color color)
    {
        int r = Mathf.RoundToInt(color.r * 255.0f);
        int g = Mathf.RoundToInt(color.g * 255.0f);
        int b = Mathf.RoundToInt(color.b * 255.0f);
        int a = Mathf.RoundToInt(color.a * 255.0f);
        string hex = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}", r, g, b, a);
        return hex;
    }

}
