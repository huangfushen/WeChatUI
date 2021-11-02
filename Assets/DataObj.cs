using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DataObj
    {
        public static void InitData()
        {
            // 初始化用户数据
            string[,] userInfo = new string[10, 3]
            {
                {"1","xiaohuang","123456"},
                {"2","xiaohon","123456"},
                {"3","xiaobai","123456"},
                {"4","xiaohei","123456"},
                {"5","xiaolv","123456"},
                {"6","xiaocheng","123456"},
                {"7","xiaohui","123456"},
                {"8","dabai","123456"},
                {"9","dahei","123456"},
                {"10","xiaolan","123456"}
            };
            for (int i=0; i<userInfo.GetLength(0); i++) {
                PlayerPrefs.SetString(userInfo[i,0],userInfo[i,1]);
                PlayerPrefs.SetString(userInfo[i,1],userInfo[i,2]);
            }
        }

    }
