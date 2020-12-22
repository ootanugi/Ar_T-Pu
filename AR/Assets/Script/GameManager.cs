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
    public List<Image> Content_image;
    public List<Sprite> Content_Data1, Content_Data2, Content_Data3;
    public List<ContentDataOBJ> All_ContentData;
   public int Content_Now=0;
    public int Img_Now = 0;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Content_Down()
    {
        GameManager.GetInstance().Content_View.DOLocalMoveY(-600, 1).SetEase(Ease.InBack);
    }

    public void Next_B()
    {
        if (Img_Now < All_ContentData[Content_Now].Data.Count - 1)
        {

            Img_Now++;
            All_ContentData[Content_Now].Data[Img_Now].transform.DOLocalMoveX(0, .5f);
        }
    }
    public void Back_B()
    {
        if (Img_Now > 0)
        {

            All_ContentData[Content_Now].Data[Img_Now].transform.DOLocalMoveX(800, .5f);
            Img_Now--;
        }
    }

}

[Serializable]
public class ContentDataOBJ
    {
   public List<GameObject> Data;
}
