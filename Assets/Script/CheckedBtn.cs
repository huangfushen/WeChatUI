using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CheckedBtn : MonoBehaviour
{
    public Button btn; 
    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(CheckedOne);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void CheckedOne()
    {
        Transform checken = btn.transform.parent;
        Transform item_friendO = checken.parent;
        string friend = item_friendO.GetChild(1).GetComponent<Text>().text;
        Text check_text = checken.GetChild(1).GetComponent<Text>();
        Image check_img = checken.GetChild(0).GetComponent<Image>();
        string nickname = PlayerPrefs.GetString("loginUser");
        string users = PlayerPrefs.GetString(friend+"_friend");
        if (users.IndexOf(nickname) == -1)
        {
            if (users == "")
            {
                users = nickname;
            }
            else
            {
                users = users + "," + nickname;
            }

            check_img.sprite = Resources.Load("like", typeof(Sprite)) as Sprite;
        }
        else
        {
            string[] user_arr = users.Split(',');
            string user_str = "";
            foreach (var item in user_arr)
            {
                if (nickname == item)
                {
                    continue;
                }

                if (user_str == "")
                {
                    user_str += item;
                }
                else
                {
                    user_str += ","+item;
                }
            }
            check_img.sprite = Resources.Load("checked", typeof(Sprite)) as Sprite;
            users = user_str;
        }

        Debug.Log(users);
        PlayerPrefs.SetString(friend+"_friend",users);
  
        check_text.text = users;
    }
}
