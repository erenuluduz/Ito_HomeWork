using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    GameObject[] normalSlot;
    GameObject[] selectedSlot;
    GameObject buttonSelected;
    GameObject buttonActive;
    public float aTimer = 1f;
    public float bTimer = 1f;
    public bool a = false;
    public bool b = false;
    private void Update()
    {
        if(a && aTimer > 0)
        {
            aTimer -= Time.deltaTime;
        }
        if (aTimer < 0)
        {
            a = false;
            normalSlot[0].SetActive(false);
            normalSlot[1].SetActive(false);
            normalSlot[2].SetActive(false);
            normalSlot[3].SetActive(false);
            normalSlot[4].SetActive(false);
        }
        if (b && bTimer > 0)
        {
            bTimer -= Time.deltaTime;
        }
        if (bTimer < 0)
        {
            a = false;
            buttonActive.SetActive(false);
        }

    }
    void Start()
    {
        normalSlot = GameObject.FindGameObjectsWithTag("normal");
        selectedSlot = GameObject.FindGameObjectsWithTag("selected");
        buttonSelected = GameObject.FindGameObjectWithTag("buttonSelected");
        buttonActive = GameObject.FindGameObjectWithTag("buttonActive");
        selectedSlot[0].SetActive(false);
        selectedSlot[1].SetActive(false);
        selectedSlot[2].SetActive(false);
        selectedSlot[3].SetActive(false);
        selectedSlot[4].SetActive(false);
        buttonSelected.SetActive(false);
        buttonActive.SetActive(false);

    }
    public void OnClickItem()
    {
        a = true;

        selectedSlot[0].SetActive(true);
        selectedSlot[1].SetActive(true);
        selectedSlot[2].SetActive(true);
        selectedSlot[3].SetActive(true);
        selectedSlot[4].SetActive(true);
        buttonActive.SetActive(true);
    }

    public void OnClickCraft() 
    {
        b = true;
        buttonSelected.SetActive(true);
        
    }
}
