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
    public Image Content_image;
    public List<Sprite> Content_Sprite;
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
}
