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
}
