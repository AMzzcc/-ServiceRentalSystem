using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppMgr : Singleton<AppMgr>
{
    public string userName="";
    public string userno = "";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void find()
    {

    }


    /// <summary>
    /// 退出软件
    /// </summary>
    public void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;

#else
         Application.Quit();
#endif

    }
}
