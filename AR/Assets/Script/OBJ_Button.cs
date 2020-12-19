using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OBJ_Button : MonoBehaviour
{
    string OBJ_Name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit hit;


        if(Physics.Raycast(ray,out hit)&&Input.touches[0].phase == TouchPhase.Began)
        {
            OBJ_Name = hit.transform.name;
            switch (OBJ_Name)
            {
                case "Test1":
                    Debug.LogError("Click1");
                    GameManager.GetInstance().Content_View.DOLocalMoveY(-450, 1).SetEase(Ease.OutBack).OnComplete(()=> GameManager.GetInstance().Content_image.sprite = GameManager.GetInstance().Content_Sprite[0]);
                    
                 
                    break;
                case "Test2":
                    Debug.LogError("Click2");
                    GameManager.GetInstance().Content_View.DOLocalMoveY(-450, 1).SetEase(Ease.OutBack).OnComplete(() => GameManager.GetInstance().Content_image.sprite = GameManager.GetInstance().Content_Sprite[1]);
                    break;
                case "Test3":
                    Debug.LogError("Click3");
                    GameManager.GetInstance().Content_View.DOLocalMoveY(-450, 1).SetEase(Ease.OutBack).OnComplete(() => GameManager.GetInstance().Content_image.sprite = GameManager.GetInstance().Content_Sprite[2]);
                    break;

            }
                   DOVirtual.DelayedCall(1.5f,()=> GameManager.GetInstance().Content_View.DOLocalMoveY(0, 1).SetEase(Ease.OutBack));

        }
        
    }

    
}
