using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class support : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void UseBattery()
    {
        player.GetComponentInChildren<water>().AddWater();
        Destroy(gameObject);
    }

    void Update()
    {

    }
}
