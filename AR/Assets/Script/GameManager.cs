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
    public GameObject All_ContentDataOBJ;
    public List<Image> Content_image;
    public List<ContentDataSprite> Content_Data_Sprite;

    public Image Panel;
    public int What_Content;

    public int Img_Now = 0;
    public int Current_Img;

    public bool open = false;

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
        
    }
    public void Close_Button()
    {
        Content_View.DOLocalMoveY(-1500, 1).SetEase(Ease.InBack);
        open = false;
        Panel.DOColor(new Color(0, 0, 0, 0), .5f);
    }

    public void Next_B()
    {
       if (Img_Now < Current_Img)
        {

            Img_Now++;
            All_ContentDataOBJ.transform.DOLocalMoveX(All_ContentDataOBJ.transform.localPosition.x - 1400, .5f);
        }
    }
    public void Back_B()
    {
        if (Img_Now > 0)
        {

            All_ContentDataOBJ.transform.DOLocalMoveX(All_ContentDataOBJ.transform.localPosition.x + 1400, .5f);
            Img_Now--;
        }
    }

}

[Serializable]
public class ContentDataSprite
    {
   public List<Sprite> Data;
}
