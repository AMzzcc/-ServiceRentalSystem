using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpWeaponPanel : MonoBehaviour
{
    public Text wname;
    public Text wnumber;
    public Text wprice;
    public Text wattribute;
    public Text wtype;
    public Text wrarity;

    public string wno="";
    public Button confirmBtn;
    public Button cancelBtn;
    public bool isUpdate = false;

    
    void Start()
    {
        confirmBtn.onClick.AddListener(UpWeapon);
        cancelBtn.onClick.AddListener(BackChoose);
    }

   
    void Update()
    {
        
    }

    /// <summary>
    /// 上架武器时同时插入在售列表和武器表
    /// </summary>
    public void UpWeapon()
    {
        wno= DateTime.Now.TimeOfDay.ToString();
        Debug.Log("'" + wno + "','" + wname.text + "','" + wtype.text + "','" + wattribute.text + "','" + wrarity.text+"'");
        if (SqlOperator.InsertSQL("weaponlist", "'" + wno + "','" + wname.text + "','" + wtype.text + "','" + wattribute.text + "'," + wrarity.text + ""))
        {
            if (SqlOperator.InsertSQL(PanelType.soldlist.ToString(), "'" + wno + "','" + AppMgr.Instance.userno + "','" + wname.text + "','" + wtype.text + "'," + wnumber.text + "," + wprice.text + ""))
                BackChoose();
            else
                Debug.Log("在售列表插入失败");

        }
            
    }

    public void BackChoose()
    {
        Function.Instance.BackChoose();
    }
}
