using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class SingletonB<T> : MonoBehaviour where T : SingletonB<T>
{
    public static T Instance { get; private set; }

    protected void Awake()
    {
        if (Instance == null)
        {
            Instance = (T)this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
