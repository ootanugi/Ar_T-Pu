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


        if (Physics.Raycast(ray, out hit) /*&& Input.touches[0].phase == TouchPhase.Began*/)
        {
            OBJ_Name = hit.transform.name;
            GameManager.GetInstance().Content_View.DOLocalMoveY(-600, 0.5f).SetEase(Ease.InBack);
           
            GameManager.GetInstance().Img_Now = 0;
            //Case();
            DOVirtual.DelayedCall(.8f, Case);
            DOVirtual.DelayedCall(1f, () => GameManager.GetInstance().Content_View.DOLocalMoveY(0, 1).SetEase(Ease.OutBack));

        }

    }
    public void Case()
    {
        for (int i = 0; i < GameManager.GetInstance().All_ContentData[GameManager.GetInstance().Content_Now].Data.Count ; i++)
        {
            if (i != 0)
            {
                GameManager.GetInstance().All_ContentData[GameManager.GetInstance().Content_Now].Data[i].transform.DOLocalMoveX(800, .5f);
            }
        }
        switch (OBJ_Name)
         {
             case "Test1":
                 Debug.LogError("Click1");
                GameManager.GetInstance().Content_Now = 0;
                 GameManager.GetInstance().Content_image[0].sprite = GameManager.GetInstance().Content_Data1[0];
                 GameManager.GetInstance().Content_image[1].sprite = GameManager.GetInstance().Content_Data1[1];
                 GameManager.GetInstance().Content_image[2].sprite = GameManager.GetInstance().Content_Data1[2];
                 GameManager.GetInstance().Content_image[3].sprite = GameManager.GetInstance().Content_Data1[3];
                break;

             case "Test2":
                 Debug.LogError("Click2");
                GameManager.GetInstance().Content_Now = 1;
                GameManager.GetInstance().Content_image[0].sprite = GameManager.GetInstance().Content_Data2[0];
                 GameManager.GetInstance().Content_image[1].sprite = GameManager.GetInstance().Content_Data2[1];
                 break;

             case "Test3":
                 Debug.LogError("Click3");
                GameManager.GetInstance().Content_Now = 2;
                 GameManager.GetInstance().Content_image[0].sprite = GameManager.GetInstance().Content_Data3[0];
                 GameManager.GetInstance().Content_image[1].sprite = GameManager.GetInstance().Content_Data3[1];
                 GameManager.GetInstance().Content_image[2].sprite = GameManager.GetInstance().Content_Data3[2];
                 break;
         }

    }

   
    
}
