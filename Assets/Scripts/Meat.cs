﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meat : MonoBehaviour
{

    public float maxMeatLife = 100;
    public float curMeatLife;
    float MeatDrain = 1f;
    public Slider meatUI;
   
    // Start is called before the first frame update
    void Start()
    {
        curMeatLife = maxMeatLife;
    }

    // Update is called once per frame
    void Update()
    {
        if (curMeatLife > 0)
        {
            curMeatLife -= MeatDrain * Time.deltaTime;
        }

        if (curMeatLife <= 0)
        {
            curMeatLife = 0;
        }

        meatUI.transform.localScale = new Vector3(
    curMeatLife / maxMeatLife,
    meatUI.transform.localScale.y,
    meatUI.transform.localScale.z
    );
        if (curMeatLife <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}