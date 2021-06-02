using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class StartPanel : BasePanel
{
    public Button loginBtn;
    public Button registerBtn;
    public Button exitBtn;
    public GameObject LoginOrRegisterPanel;

    private void Start()
    {
        loginBtn.onClick.AddListener(LoginButtonClick);
        registerBtn.onClick.AddListener(RegisterButtonClick);
        exitBtn.onClick.AddListener(ExitButtonClick);
    }

    private void LoginButtonClick()
    {
        LoginOrRegisterPanel.SetActive(true);
        LoginOrRegisterPanel.GetComponent<LoginRegisterPanel>().isRegister = false;
        //UIManager.Instance.PushPanel(PanelName.RoomList,PanelType.normalPanel);
    }

    private void RegisterButtonClick()
    {
        LoginOrRegisterPanel.SetActive(true);
        LoginOrRegisterPanel.GetComponent<LoginRegisterPanel>().isRegister = true;
    }

    private void ExitButtonClick()
    {
        AppMgr.Instance.Exit();
    }
    public override void OnEnter()
    {
        Enter();
    }

    public override void OnExit()
    {
        Exit();
    }

    public override void OnPause()
    {
        //Exit();
    }

    public override void OnRecovery()
    {
        Enter();
    }

    private void Enter()
    {
        gameObject.SetActive(true);
    }

    private void Exit()
    {
        gameObject.SetActive(false);
    }
}

