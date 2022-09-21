using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useHeart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void use()
    {
        if(stm.heart > 0)
        {
            stm.heart--;
            PlayerPrefs.SetInt("heart", stm.heart);
            PlayerPrefs.Save();
            stm.min = 4;
            stm.sec = 60;
        }
    }
}
