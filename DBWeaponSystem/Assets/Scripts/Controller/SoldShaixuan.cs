using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoldShaixuan : MonoBehaviour
{
    public Text upDowntext;
    public Text type;
    public Button confirmBtn;
    void Start()
    {
        confirmBtn.onClick.AddListener(Shaixuan);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shaixuan()
    {
        Function.Instance.uPanelSt.SoldShaixuan(upDowntext.text, type.text);
    }
  
}
