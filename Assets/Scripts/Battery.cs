using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Battery : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void UseBattery()
    {
        player.GetComponentInChildren<FlashLights>().AddEnergy();
        Destroy(gameObject);
    }

    void Update()
    {

    }
}
