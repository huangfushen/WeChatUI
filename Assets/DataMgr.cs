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
        {"1.png","朋友圈"} ,  
        {"2.png","视频号"} ,  
        {"3.png","扫一扫"} ,
        {"4.png","摇一摇"} ,
        {"5.png","看一看"} ,
        {"6.png","搜一搜"} ,
        {"7.png","直播和附近"} ,
        {"8.png","购物"} ,
        {"9.png","游戏"} ,
        {"10.png","小程序"} 
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
}
