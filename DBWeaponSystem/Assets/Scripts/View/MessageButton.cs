using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageButton : MonoBehaviour
{
    public int btnNum;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(HitNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HitNum()
    {
        Function.Instance.HitNum(btnNum);
    }
}
