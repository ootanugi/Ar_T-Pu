using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Theme_Sound : MonoBehaviour
{


    public static Theme_Sound Sound_Instance;


    private void Awake()
    {
        if(Sound_Instance == null)
        {
            Sound_Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }


        DontDestroyOnLoad(gameObject);

    }
}

