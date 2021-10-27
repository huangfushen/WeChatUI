using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMgr 
{
    
    static string [,] data = new string [10,4] {
        {"1296DCFF","小黄","11","上午 00:00"} ,  
        {"1426DCFF","小红","22","上午 01:00"} ,  
        {"1296ACFF","小白","33","上午 02:00"} ,
        {"1296ACFF","小黑","44","上午 03:00"} ,
        {"1216ACFF","小绿","55","上午 04:00"} ,
        {"1296AAFF","小橙","66","上午 05:00"} ,
        {"1296ACFF","小灰","77","上午 06:00"} ,
        {"1210ACFF","大白","88","上午 07:00"} ,
        {"1222ACFF","大黑","99","上午 08:00"} ,
        {"1222ACFF","大黑","10","上午 08:00"} 
    };
    
    static string [,] data_friend = new string [10,2] {
        {"1296DCFF","小黄"} ,  
        {"1426DCFF","小红"} ,  
        {"1296ACFF","小白"} ,
        {"1296ACFF","小黑"} ,
        {"1216ACFF","小绿"} ,
        {"1296AAFF","小橙"} ,
        {"1296ACFF","小灰"} ,
        {"1210ACFF","大白"} ,
        {"1222ACFF","大黑"} ,
        {"1222ACFF","大黑"} 
    };

    static string [,] data_find = new string [10,2] {
        {"10","小程序"} ,  
        {"2","视频号"} ,  
        {"3","扫一扫"} ,
        {"4","摇一摇"} ,
        {"5","看一看"} ,
        {"6","搜一搜"} ,
        {"7","直播和附近"} ,
        {"8","购物"} ,
        {"9","游戏"} ,
        {"1","朋友圈"} 
    };
    
    static string [,] data_me = new string [6,2] {
        {"pay","支付"} ,
        {"collect","收藏"} ,  
        {"img_o","朋友圈"} ,  
        {"card_bag","卡包"} ,
        {"exp","表情"} ,
        {"setting","设置"}
    };
    
    static string [,] data_friendO = new string [10,3] {
        {"1296DCFF","小黄","1今天天气挺好！"} ,  
        {"1426DCFF","小红","2今天天气挺好！"} ,  
        {"1296ACFF","小白","3今天天气挺好！"} ,
        {"1296ACFF","小黑","4今天天气挺好！"} ,
        {"1216ACFF","小绿","5今天天气挺好！"} ,
        {"1296AAFF","小橙","6今天天气挺好！"} ,
        {"1296ACFF","小灰","7今天天气挺好！"} ,
        {"1210ACFF","大白","8今天天气挺好！"} ,
        {"1222ACFF","大黑","9今天天气挺好！"} ,
        {"1222ACFF","大黑","10今天天气挺好！"} 
    };
    
    static string [,] data_navbar = new string [4,3] {
        {"message","微信","message_check"} ,  
        {"addressbook","联系人","addressbook_check"} ,  
        {"find","发现","find_check"} ,
        {"me","我的","me_check"} 
    };
    
    public static string GetData(int x, int y)
    {
        return data[x, y];
    }
    
    public static string GetFriendData(int x, int y)
    {
        return data_friend[x, y];
    }
    
    public static string GetFindData(int x, int y)
    {
        return data_find[x, y];
    }

    public static string GetMePageData(int x, int y)
    {
        return data_me[x, y];
    }
    public static string GetFriendOData(int x, int y)
    {
        return data_friendO[x, y];
    }
    public static string GetNavBarData(int x, int y)
    {
        return data_navbar[x, y];
    }
}
