using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBalancePanel : MonoBehaviour
{
    public Text changeNum;
    public Text weixinNum;
    public Text choose;
    public Button confirmBtn;
    public Button cancelBton;
    void Start()
    {
        confirmBtn.onClick.AddListener(ChangeBalance);
        cancelBton.onClick.AddListener(Cancel);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeBalance()
    {
        Function.Instance.ChangeBalance(float.Parse(changeNum.text),choose.text);
        Function.Instance.BackChoose();
    }

    public void Cancel()
    {
        Function.Instance.BackChoose();
    }
}
