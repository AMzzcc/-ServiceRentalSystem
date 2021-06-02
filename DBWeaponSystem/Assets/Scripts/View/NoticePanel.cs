using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoticePanel : MonoBehaviour
{
    public Text text;
    public Button confirmBtn;
    void Start()
    {
        confirmBtn.onClick.AddListener(Close);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Notice(string str)
    {
        text.text = str;
    }
    public void Close()
    {
        this.gameObject.SetActive(false);
    }
}
