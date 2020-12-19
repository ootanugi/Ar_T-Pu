using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJ_Button : MonoBehaviour
{
  public LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit hit;


        if(Physics.Raycast(ray,out hit,layerMask))
        {
            if(layerMask == 8)
            {
                Debug.LogError("8");
            }
            if (layerMask == 9)
            {
                Debug.LogError("9");
            }
            if (layerMask == 10)
            {
                Debug.LogError("10");
            }
                Debug.LogError(hit.transform.name);
        }
        
    }
}
