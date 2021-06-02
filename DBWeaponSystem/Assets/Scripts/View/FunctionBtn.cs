using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FunctionBtn : MonoBehaviour
{
    public function fun;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(FunctionChoose);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FunctionChoose()
    {
        Function.Instance.FunctionChoose(fun);
    }
}
