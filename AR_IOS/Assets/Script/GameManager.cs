using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    #region Singleton
    private static GameManager Instant;
    public static GameManager GetInstance() { return Instant; }
    #endregion
    public Transform Content_View;
    public GameObject All_ContentDataOBJ/*,WaitTargetParnnel*/;
    //public List<GameObject> Target;

    
    public List<Image> Content_image;
    public List<ContentDataSprite> Content_Data_Sprite;

    public Image Panel;
    public int What_Content;
    public SpriteRenderer _Target;
    public List<int> ContentDataOBJ_Pos;
    public int Img_Now = 0;
    public int Current_Img;
    public bool open = false;


    public GameObject WaitForMarker;
    // Start is called before the first frame update
    void Start()
    {
        #region Singleton
        if (Instant == null)
        {
            Instant = this;
        }
        else
        {
            Destroy(gameObject);
        }
        #endregion
        Img_Now = 0;
        Panel.DOColor(new Color(0, 0, 0, 0), .5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(_Target.enabled == false)
        {
            WaitForMarker.SetActive(true);
        }
        else
        {
            WaitForMarker.SetActive(false);
        }



        All_ContentDataOBJ.transform.DOLocalMoveX(ContentDataOBJ_Pos[Img_Now], .5f);

        /*if(Target[0].activeSelf == true)
        {
            WaitTargetParnnel.SetActive(false);
        }
        else
        {
            WaitTargetParnnel.SetActive(true);
        }*/

    }
    public void Close_Button()
    {
        Content_View.DOLocalMoveY(-1500, 1).SetEase(Ease.InBack);
      DOVirtual.DelayedCall(.5f,()=>  open = false);       
        Panel.DOColor(new Color(0, 0, 0, 0), .5f);
    }

    public void Next_B()
    {
       if (Img_Now < Current_Img)
        {
            Img_Now++;
        }
    }
    public void Back_B()
    {
        if (Img_Now > 0)
        {
            Img_Now--;
        }
    }

}

[Serializable]
public class ContentDataSprite
    {
   public List<Sprite> Data;
}
