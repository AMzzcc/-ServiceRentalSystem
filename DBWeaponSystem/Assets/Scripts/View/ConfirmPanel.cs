using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmPanel : MonoBehaviour
{
    public Text notice;
    public Button rightBtn;
    public Button noBtn;
    public bool isRight;
    // Start is called before the first frame update
    void Start()
    {
        rightBtn.onClick.AddListener(Right);
        noBtn.onClick.AddListener(No);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Right()
    {
        Function.Instance.uPanelSt.DownWeapon(true);
    }
    public void No()
    {
        Function.Instance.uPanelSt.DownWeapon(false);
    }
}
