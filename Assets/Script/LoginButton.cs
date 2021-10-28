using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;
using UnityEngine.UI;
public class LoginButton : MonoBehaviour
{
    private string _username;
    private string _password;

    public Image loginPage;
    //定义提示语
    public Text text_new;
    public void OnMouseUpAsButton()
    {
        PlayerPrefs.DeleteKey("loginUser");
        // PlayerPrefs.SetString("huangfs","123456");
        _username = GameObject.Find("UserName").GetComponent<InputField>().text;
        _password = GameObject.Find("PassWord").GetComponent<InputField>().text;
        if (_username == "" && _password == "")
        {
            text_new.text = "请输入用户名或密码";
        }
        string successPassword = PlayerPrefs.GetString(_username);
        if (_password == successPassword)
        {
            PlayerPrefs.SetString("loginUser",_username);
            SetPage();
        }
        else
        {
            text_new.text = "用户名或密码错误！";
        }

    }

    public void OnInputTextClear()
    {
        text_new.text = "";
    }

    private void SetPage()
    {
        Vector2 site = new Vector2(5000,0);
        Image IndexPage = GameObject.Find("IndexPage").GetComponent<Image>();
        Image BottomNavBar = GameObject.Find("BottomNavBar").GetComponent<Image>();
        RectTransform BottomNavBar_Rt =  BottomNavBar.GetComponent<RectTransform>();
        loginPage.transform.position = site;
        IndexPage.transform.localPosition = new Vector2(0,0);
        BottomNavBar_Rt.anchoredPosition = new Vector2(0,65);
    }
    
}
