using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum function
{
    selectUser,
    selectWeapon,
    selectSold,
    selectOrder,
    manageSold,
    selectShelfRecord,
    changeBalance
}

public class Function : SingletonB<Function>
{
    //查询用户信息
    //public List<Button> functionBtns = new List<Button>();
    public Button backBtn;
    public GameObject choosePanel;
    public GameObject uPanel;
    public UniversalPanel uPanelSt;

    public GameObject upWeaponPanel;
    public GameObject noticePanel;
    public GameObject changeBalancePanel;
    public List<string> message = new List<string>();
    //private GameObject noticePanelPre;
    //public Transform canvasTf;


    void Start()
    {
        uPanelSt = uPanel.GetComponent<UniversalPanel>();
        backBtn.onClick.AddListener(BackStart);
        //noticePanelPre = Resources.Load("Prefabs/NoticePanel") as GameObject;
        //canvasTf=GameObject.Find("Canvas").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FunctionChoose(function func)
    {
        choosePanel.SetActive(false);
        switch (func)
        {
            case function.selectUser:
                uPanel.SetActive(true);
                uPanelSt.Init(PanelType.userlist);
                break;
            case function.selectWeapon:
                uPanel.SetActive(true);
                uPanelSt.Init(PanelType.weaponlist);
                break;
            case function.selectSold:
                uPanel.SetActive(true);
                uPanelSt.Init(PanelType.soldlist);
                break;
            case function.selectOrder:
                uPanel.SetActive(true);
                uPanelSt.Init(PanelType.orderlist);
                break;
            case function.selectShelfRecord:
                uPanel.SetActive(true);
                uPanelSt.Init(PanelType.shelfrecordlist);
                break;
            case function.manageSold:
                uPanel.SetActive(true);
                uPanelSt.Init(PanelType.managesold);
                break;
            case function.changeBalance:
                changeBalancePanel.SetActive(true);
                break;


        }
    }

    public void BackChoose()
    {
        uPanel.SetActive(false);
        upWeaponPanel.SetActive(false);
        changeBalancePanel.SetActive(false);
        choosePanel.SetActive(true);
        message.Clear();
    }


    public void BackStart()
    {
        SceneManager.LoadScene(0);
    }

    public void UpWeaponlist()
    {
        uPanel.SetActive(false);
        upWeaponPanel.SetActive(true);
        upWeaponPanel.GetComponent<UpWeaponPanel>().isUpdate = false;
    }

    public void HitNum(int num)
    {
        uPanelSt.HitButton(num);
    }

    public void Buy(int buyNum)
    {
        uPanel.GetComponent<UniversalPanel>().BuyConfirm(buyNum);
    }


    public float GetUserBalance()
    {
        message.Clear();
        message = SqlOperator.SelectSQL("userlist",null, "uno='" + AppMgr.Instance.userno + "'", "ubalance");
        return float.Parse(message[0]);

    }

    public void ChangeBalance(float changeNum,string choose)
    {
        if (changeNum > 0)
        {
            if(choose=="充值")
            {
                Notice("充值成功");
                SqlOperator.UpdateSQL("userlist", "ubalance = " + (GetUserBalance() + changeNum), "uno='" + AppMgr.Instance.userno + "'");
            }
            else
            {
                if(GetUserBalance()>= changeNum)
                {
                    Notice("提现成功");
                    SqlOperator.UpdateSQL("userlist", "ubalance = " + (GetUserBalance() - changeNum), "uno='" + AppMgr.Instance.userno + "'");
                }
                else
                {
                    Notice("提现失败");
                }
            }
            
        }
        else
        {
            if (choose == "充值")
            {
                Notice("充值失败");
            }
            else
            {
                Notice("提现失败");
            }
        }
    }

    public void Notice(string str)
    {
        noticePanel.SetActive(true);
        //GameObject noticePanel = Instantiate(noticePanelPre);
        noticePanel.GetComponent<NoticePanel>().Notice(str);
        //noticePanel.transform.parent = canvasTf;

    }

}
