using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                    hit.transform.gameObject.SetActive(false);
                    break;
                case "Test2":
                    Debug.LogError("Click2");
                    hit.transform.gameObject.SetActive(false);
                    break;
                case "Test3":
                    Debug.LogError("Click3");
                    hit.transform.gameObject.SetActive(false);
                    break;

            }
            Debug.LogError(hit.transform.name);
        }
        
    }
}
