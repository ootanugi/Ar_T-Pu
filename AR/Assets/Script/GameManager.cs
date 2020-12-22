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
    public Image Content_image1, Content_image2, Content_image3;
    public List<Sprite> Content_Data1, Content_Data2, Content_Data3;
    public List<GameObject> Img;
    int Img_Now = 0;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Content_Down()
    {
        GameManager.GetInstance().Content_View.DOLocalMoveY(-450, 1).SetEase(Ease.InBack);
    }

    public void Next_B()
    {
        if (Img_Now < Img.Count - 1)
        {

            Img_Now++;
            Img[Img_Now].transform.DOLocalMoveX(0, .5f);
        }
    }
    public void Back_B()
    {
        if (Img_Now > 0)
        {

            Img[Img_Now].transform.DOLocalMoveX(600, .5f);
            Img_Now--;
        }
    }

}
