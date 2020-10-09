﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pendars : MonoBehaviour
{
    public GameObject Panel;
    public ResourceProgressBar progressBar;

    public Sonde sonde;
    public Miner miner;
    public Colonie colonie;
    public Sonde cloneSonde;
    public Miner cloneMiner;
    public Colonie cloneColonie;
    public bool isColonise = false;

    void Start()
    {
    }

    private void OnMouseDown()
    {
        if (Panel != null && Panel.activeSelf == false)
        {
            Panel.SetActive(true);
        } else
        {
            Panel.SetActive(false);
        }
    }

    public void sendShipSonde()
    {
        cloneSonde = (Sonde)Instantiate(sonde, new Vector3(0.5f, 0.5f, 2), transform.rotation);
        if (cloneSonde.decreaseMoney())
        { 
            cloneSonde.setEndPos(new Vector2(transform.position.x, transform.position.y));
            cloneSonde.endPos.x = transform.position.x;
            cloneSonde.endPos.y = transform.position.y;
            cloneSonde.decreaseMoney();
        }
    }

    public void sendShipMiner()
    {
        cloneMiner = (Miner)Instantiate(miner, new Vector3(0.5f, 0.5f, 2), transform.rotation);
        cloneMiner.resource = progressBar;
        if (cloneMiner.isEnoughResource() && cloneMiner.decreaseMoney())
        {
            cloneMiner.setEndPos(new Vector2(transform.position.x, transform.position.y));
            cloneMiner.endPos.x = transform.position.x;
            cloneMiner.endPos.y = transform.position.y;
        }
    }
    public void sendShipColonie()
    {
        cloneColonie = (Colonie)Instantiate(colonie, new Vector3(0.5f, 0.5f, 2), transform.rotation);
        if (!isColonise && cloneColonie.decreaseMoney())
        {
            cloneColonie.setEndPos(new Vector2(transform.position.x, transform.position.y));
            cloneColonie.endPos.x = transform.position.x;
            cloneColonie.endPos.y = transform.position.y;
            isColonise = true;
        }
    }


}
