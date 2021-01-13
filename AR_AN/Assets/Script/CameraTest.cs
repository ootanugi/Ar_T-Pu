
#if PLATFORM_ANDROID
using UnityEngine.Android;
using System.Collections;
using System.Collections.Generic;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class CameraTest : MonoBehaviour
{
    GameObject dialog = null;

    public GameObject Img1, Img2, HowtoPopup;
    public Image Fade_Img, howtoB;
    

    void Update()
    {
#if PLATFORM_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
          Permission.RequestUserPermission(Permission.Camera);
        }
        else
        {
            Debug.Log("Pass");
        }

#endif
    }

    public void Next_Scene(Image T)
    {
        T.DOColor(new Color(1, 1, 1, 0), 1).OnComplete(() => AnimBG()) ;
        howtoB.DOColor(new Color(1, 1, 1, 0), 1);
    }

    public void How_To_Button()
    {
        HowtoPopup.SetActive(true);
        HowtoPopup.transform.DOLocalMoveY(0, 1).SetEase(Ease.OutBack);
    }

    public void Close_Button()
    {
        HowtoPopup.transform.DOLocalMoveY(-1500, 1).SetEase(Ease.InBack).OnComplete(() => HowtoPopup.SetActive(false));
    }


    public void GetLink()
    {
        Application.OpenURL("https://drive.google.com/file/d/1b85tFMzrqfqMiFk77NWv45GkXpmSWJ50/view?usp=sharing");
    }

        public void AnimBG()
    {
        Img1.transform.DOMoveY(60, 1).SetEase(Ease.InBack);
        Img2.transform.DOMoveY(600, 1).SetEase(Ease.InBack).OnComplete(() => Fade_Img.DOColor(new Color(1, .9f, .7f, 1), 1).OnComplete(() => SceneManager.LoadScene(1))) ;
    }
}