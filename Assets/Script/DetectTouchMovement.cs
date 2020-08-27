using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DetectTouchMovement : MonoBehaviour
{

   private float initialFingersDistance;
   private Vector3 initialScale;


    void Update()
    {
        int fingersOnScreen = 0;
  
        foreach (Touch touch in Input.touches)
        {
            fingersOnScreen++;

            if (fingersOnScreen == 2)
            {
              
                if (touch.phase == TouchPhase.Began)
                {
                    initialFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);
                    initialScale = transform.position;

                }
                else
                {
                    var currentFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);
                    var scaleFactor = currentFingersDistance / initialFingersDistance;
                    transform.position = new Vector3(transform.position.x, initialScale.y * scaleFactor, transform.position.z);
              
                }
            }

        }

        if (transform.localPosition.y < 4.0f)
        {
           
            transform.localPosition = new Vector3(transform.localPosition.x, 4.0f, transform.localPosition.z);

        }

        if (transform.localPosition.y >80.0f)
        {
           
            transform.localPosition = new Vector3(transform.localPosition.x, 80.0f, transform.localPosition.z);
           
        }
   
    }  
}