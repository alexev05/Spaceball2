using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet : MonoBehaviour
{
    public float distance;
    public int rate;
    public GameObject player;


    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }


    void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);
    }
}
