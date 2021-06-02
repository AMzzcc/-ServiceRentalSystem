using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyPanel : MonoBehaviour
{
    public Text buyNum;
    public Button confirmBtn;
    public Button cancelBton;
    void Start()
    {
        confirmBtn.onClick.AddListener(Buy);
        cancelBton.onClick.AddListener(Cancel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Buy()
    {
        Function.Instance.Buy(int.Parse(buyNum.text));
        this.gameObject.SetActive(false);
    }

    public void Cancel()
    {
        this.gameObject.SetActive(false);
    }

}
