using System.Collections;
using System.Collections.Generic;
using Script;
using UnityEngine;
using UnityEngine.UI;
public class LoginButton : MonoBehaviour
{
    private string username;
    private string password;

    public Image loginPage;
    //定义提示语
    public Text text_new;
    public void OnMouseUpAsButton()
    {
        PlayerPrefs.DeleteKey("loginUser");
        // PlayerPrefs.SetString("huangfs","123456");
        username = GameObject.Find("UserName").GetComponent<InputField>().text;
        password = GameObject.Find("PassWord").GetComponent<InputField>().text;

        if (username == "" && password == "")
        {
            text_new.text = "请输入用户名或密码";
            Debug.Log("请输入用户名或密码！");
        }
        string successPassword = PlayerPrefs.GetString(username);
        if (password == successPassword)
        {
            Vector2 site = new Vector2(5000,0);
            loginPage.transform.position = site;
            PlayerPrefs.SetString("loginUser",username);
            Image IndexPage = GameObject.Find("IndexPage").GetComponent<Image>();
            IndexPage.transform.position = new Vector2(375,667);
            Debug.Log("登录成功");
        }
        else
        {
            Debug.Log("用户名或密码错误！");
        }

    }

    public void OnInputTextClear()
    {
        text_new.text = "";
    }
    
}
