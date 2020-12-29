using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class OBJ_Button : MonoBehaviour
{
    [SerializeField]
    private AudioClip ButtonSound;
    private AudioSource AuSr;
    string OBJ_Name;
    int T; //ใช้ใน Case()->Switch
    // Start is called before the first frame update
    void Start()
    {
        T = 0;
        AuSr = GetComponent<AudioSource>();
    }



    // Update is called once per frame
    void Update()
    {
       
         Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);            
         RaycastHit hit;
        


        if (Physics.Raycast(ray, out hit) && !GameManager.GetInstance().open /*&& Input.touches[0].phase == TouchPhase.Began*/)
        {
            OBJ_Name = hit.transform.name;
            GameManager.GetInstance().Img_Now = 0;
            Case();
            PlayButtonSound();
            GameManager.GetInstance().Content_View.DOLocalMoveY(0, 1).SetEase(Ease.OutBack);
            GameManager.GetInstance().Panel.DOColor(new Color(0, 0, 0, .6f), .5f);
        }

    }
    public void Case()
    {
        //ธรรมสวนะ  มาฆบูชา วิสาขบูชา ออกพรรษา อัฎฐมีบูชา อาสาฬหบูชา เข้าพรรษา
           
        switch (OBJ_Name)
         {
             case "ธรรมสวนะ"://0
                Content_Select(0,2);
                break;
            case "มาฆบูชา"://1
                Content_Select(1, 3);
                break;
            case "วิสาขบูชา"://2
                Content_Select(2, 3);
                break;
            case "ออกพรรษา"://3
                Content_Select(3, 2);
                break;
            case "อัฎฐมีบูชา"://4
                Content_Select(4, 3);
                break;
            case "อาสาฬหบูชา"://5
                Content_Select(5, 2);
                break;
            case "เข้าพรรษา"://6
                Content_Select(6, 2);
                break;
        }
        GameManager.GetInstance().open = true;

    }
    public void PlayButtonSound()
    {
        AuSr.PlayOneShot(ButtonSound);
    }

    public void Content_Select(int WC,int CI)
    {
       GameManager.GetInstance().What_Content = WC;
       GameManager.GetInstance().Current_Img = CI;

        for (int i = 0; i < GameManager.GetInstance().Content_Data_Sprite[GameManager.GetInstance().What_Content].Data.Count; i++)
        {
            GameManager.GetInstance().Content_image[i].sprite = GameManager.GetInstance().Content_Data_Sprite[GameManager.GetInstance().What_Content].Data[i];
            GameManager.GetInstance().Content_image[i].SetNativeSize();
        }
    }

   
    
}
