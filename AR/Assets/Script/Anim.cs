using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Anim : MonoBehaviour
{


    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {

        transform.DOScale(1,Random.Range(0.3f,0.5f)).SetEase(Ease.OutBack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
