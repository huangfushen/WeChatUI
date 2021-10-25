using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCheckdStatus : MonoBehaviour
{
    public int checkNum = 1;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = this.GetComponent<Button> ();
        btn.onClick.AddListener (OnClick);
    }

    // Update is called once per frame
     void OnClick()
    {
        Image img1 = GameObject.Find("ImageBar1").GetComponent<Image>();
        Text text1 = GameObject.Find("TextBar1").GetComponent<Text>();
        Image img2 = GameObject.Find("ImageBar2").GetComponent<Image>();
        Text text2 = GameObject.Find("TextBar2").GetComponent<Text>();
        Image img3 = GameObject.Find("ImageBar3").GetComponent<Image>();
        Text text3 = GameObject.Find("TextBar3").GetComponent<Text>();
        Image img4 = GameObject.Find("ImageBar4").GetComponent<Image>();
        Text text4 = GameObject.Find("TextBar4").GetComponent<Text>();
        if (checkNum == 1)
        {
            img1.sprite = Resources.Load("message_check", typeof(Sprite)) as Sprite;
            text1.color = new Color32(18, 150, 220,255);
            changeColor();
            turnPage();
        }else if (checkNum == 2)
        {
            img2.sprite = Resources.Load("addressbook_check", typeof(Sprite)) as Sprite;
            text2.color = new Color32(18, 150, 220,255);
            changeColor();
            turnPage();
        }else if (checkNum == 3)
        {
            img3.sprite = Resources.Load("find_check", typeof(Sprite)) as Sprite;
            text3.color = new Color32(18, 150, 220,255);
            changeColor();
            turnPage();
        }else if (checkNum == 4)
        {
            img4.sprite = Resources.Load("me_check", typeof(Sprite)) as Sprite;
            text4.color = new Color32(18, 150, 220,255);
            changeColor();
            turnPage();
        }
    }


     private void changeColor()
     {
         Image img1 = GameObject.Find("ImageBar1").GetComponent<Image>();
         Text text1 = GameObject.Find("TextBar1").GetComponent<Text>();
         Image img2 = GameObject.Find("ImageBar2").GetComponent<Image>();
         Text text2 = GameObject.Find("TextBar2").GetComponent<Text>();
         Image img3 = GameObject.Find("ImageBar3").GetComponent<Image>();
         Text text3 = GameObject.Find("TextBar3").GetComponent<Text>();
         Image img4 = GameObject.Find("ImageBar4").GetComponent<Image>();
         Text text4 = GameObject.Find("TextBar4").GetComponent<Text>();
         if (checkNum == 1)
         {
             img2.sprite = Resources.Load("addressbook", typeof(Sprite)) as Sprite;
             text2.color = new Color32(0,0,0,255);
             img3.sprite = Resources.Load("find", typeof(Sprite)) as Sprite;
             text3.color = new Color32(0,0,0,255);
             img4.sprite = Resources.Load("me", typeof(Sprite)) as Sprite;
             text4.color = new Color32(0,0,0,255);
         }else if (checkNum == 2)
         {
             img1.sprite = Resources.Load("message", typeof(Sprite)) as Sprite;
             text1.color = new Color32(0, 0, 0,255);
             img3.sprite = Resources.Load("find", typeof(Sprite)) as Sprite;
             text3.color = new Color32(0, 0, 0,255);
             img4.sprite = Resources.Load("me", typeof(Sprite)) as Sprite;
             text4.color = new Color32(0,0,0,255);
         }else if (checkNum == 3)
         {
             img2.sprite = Resources.Load("addressbook", typeof(Sprite)) as Sprite;
             text2.color = new Color32(0,0,0,255);
             img1.sprite = Resources.Load("message", typeof(Sprite)) as Sprite;
             text1.color = new Color32(0,0,0,255);
             img4.sprite = Resources.Load("me", typeof(Sprite)) as Sprite;
             text4.color = new Color32(0,0,0,255);
         }else if (checkNum == 4)
         {
             img2.sprite = Resources.Load("addressbook", typeof(Sprite)) as Sprite;
             text2.color = new Color32(0,0,0,255);
             img3.sprite = Resources.Load("find", typeof(Sprite)) as Sprite;
             text3.color = new Color32(0,0,0,255);
             img1.sprite = Resources.Load("message", typeof(Sprite)) as Sprite;
             text1.color = new Color32(0,0,0,255);
         }
     }

     private void turnPage()
     {
         Vector2 site = new Vector2(375,667);
         Vector2 site1 = new Vector2(5000,0);
         Image IndexPage = GameObject.Find("IndexPage").GetComponent<Image>();
         Image FriendPage = GameObject.Find("FriendPage").GetComponent<Image>();
         Image FindPage = GameObject.Find("FindPage").GetComponent<Image>();
         Image MePage = GameObject.Find("MePage").GetComponent<Image>();
         Debug.Log(IndexPage.transform.position);
         if (checkNum == 1)
         {
             IndexPage.transform.position = site;
             FriendPage.transform.position = site1;
             FindPage.transform.position = site1;
             MePage.transform.position = site1;
         }else if (checkNum == 2)
         {
             IndexPage.transform.position = site1;
             FriendPage.transform.position = site;
             FindPage.transform.position = site1;
             MePage.transform.position = site1;
         }else if (checkNum == 3)
         {
             IndexPage.transform.position = site1;
             FriendPage.transform.position = site1;
             FindPage.transform.position = site;
             MePage.transform.position = site1;
         }else if (checkNum == 4)
         {
             IndexPage.transform.position = site1;
             FriendPage.transform.position = site1;
             FindPage.transform.position = site1;
             MePage.transform.position = site;
             Text nickname = GameObject.Find("NickName").GetComponent<Text>();
             nickname.text = PlayerPrefs.GetString("loginUser");
         }
         
     }
}
