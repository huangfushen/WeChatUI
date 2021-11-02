using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendOScrollView : MonoBehaviour
{
    // Start is called before the first frame update
    // 消息item
    private GameObject message_item;
    // 滚动视图框
    private GameObject content_view;
    // 上一次滚动距离是几个item
    private int last_num;
    // 顶部下标
    public int upIndex = 0;
    // 底部下标
    public int downIndex = 0;
    // item 高度
    public float itemHeight = 300;
    // 最多item个数
    private int maxItemCount = 0;
    // 数据长度
    private int dataLength;

    private RectTransform rectTr;
    
    // 委托
    public Action<GameObject> onAdd;
    public Action<GameObject> onDel;

    private void Awake()
    {
        // 滚动视图框
        content_view =  GameObject.Find("Content_friendO");
        
        // 消息item
        message_item = (GameObject)Resources.Load("Prefabs/item_friendO");
        
        // 获取滚动框高度
        var viewHeight = GameObject.Find("Content_five").GetComponent<RectTransform>().sizeDelta.y;
        // 计算出页面初始化需要放几个
        maxItemCount = Mathf.CeilToInt(viewHeight/itemHeight)+1;
        
        rectTr = content_view.GetComponent<RectTransform>();
    }

    void Start()
    {
 
    }

    public void SetData(int type,int _dataLength)
    {
        // 数据长度
        dataLength = _dataLength;
        //初始化
        // ClearAll();
        last_num = 0;
        upIndex = 0;
        downIndex = maxItemCount;
        
        content_view.GetComponentInParent<ScrollRect>().normalizedPosition = Vector2.zero;
        content_view.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        for (var i = 0; i < downIndex; i++)
        {
            AddItem(i);
        }
    }
    /**
     * 清理原有item
     */
    public void ClearAll()
    {
        for(var i =0 ;i<content_view.transform.childCount;i++)
        {
            Destroy(content_view.transform.GetChild(i).gameObject);
        }
    }
    /**
     * 滚动时调用
     */
    public void OnScroll()
    {

        //判断item个数
        if(content_view.transform.childCount == 0)
            return;
        //父物体滚动条的位置坐标
        var localPosition = rectTr.anchoredPosition.y;
        //计算出滚动了几个物体的距离
        var len = (int)Math.Floor(localPosition/ itemHeight);
        //计算出本次滚动的了几个物体的距离（如果不为0）
        while (Math.Abs(len - last_num) != 0)
        {
            //向上滑动，加载下方更多
            if (len > last_num)
            {
                if (localPosition >= 900)
                {
                    DelItem(upIndex++);
                }
                
                AddItem(downIndex++);
                last_num++; 
            }
            //向下滑动，加载上方更多
            else if ( len < last_num)
            {
                
                if (localPosition >= 600)
                {
                    AddItem(--upIndex);
                }
                else
                {
                    --upIndex;
                }

                DelItem(--downIndex);  
                last_num--;
            }
        }
    }

    void DelItem(int index)
    {
        
        var go = content_view.transform.Find(index.ToString()).gameObject;
        if (go != null)
        {
            // 删除item
            Destroy(go);
        }
    }
    void AddItem(int index)
    {
        var dataIndex = index > 0 ? (index % dataLength):((dataLength-1)-(-index%dataLength));
        // 生成预制体
        GameObject message = Instantiate(message_item);
        //为预制体添加父级
        message.transform.parent = content_view.transform;
        
        var item  = message.GetComponent<NewFriendOScript>();
        var position = new Vector3(0, index * -itemHeight-600);
        //更新Item上的位置
        item.SetPos(position);
        
        //更新Item上的表现
        item.SetData(index,dataIndex);
 

    }
}
