using UnityEngine;
#if PLATFORM_ANDROID
using UnityEngine.Android;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
#endif

public class CameraTest : MonoBehaviour
{
    GameObject dialog = null;

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
            StartCoroutine(NextTutorial());
        }

#endif
    }

    IEnumerator NextTutorial()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}