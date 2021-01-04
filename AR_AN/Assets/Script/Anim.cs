using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Anim : MonoBehaviour
{
    public Image Start_Panel;
    // Start is called before the first frame update
    void Start()
    {
        Start_Panel.color = new Color(1, .9f, .7f, 1);
        Start_Panel.DOColor(new Color(1, .9f, .7f, 0),1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
