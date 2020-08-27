using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerCol : MonoBehaviour
{

    public List<GameObject> TriggerList = new List<GameObject>();
    public List<GameObject> TriggerList2 = new List<GameObject>();



    public void OnTriggerEnter(Collider other)
    {
    
        var go = other.gameObject;
        TriggerList.Add(go);

        foreach (GameObject x in TriggerList)
        {
            x.transform.GetChild(0).gameObject.SetActive(false);

        }

        TriggerList = TriggerList.OrderBy(e => e.GetComponent<planet>().distance).Take(50).ToList();
        TriggerList2 = TriggerList.OrderByDescending(e => e.GetComponent<planet>().rate).Take(10).ToList();

        foreach (GameObject x in TriggerList2)
        {
            x.transform.GetChild(0).gameObject.SetActive(true);

        }

    }



    public void OnTriggerExit(Collider other)
    {
            var go = other.gameObject;
       
            go.transform.GetChild(0).gameObject.SetActive(false);

        
        TriggerList.Remove(go);

      
    }

   
}
