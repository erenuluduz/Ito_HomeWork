using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    Animator animator;
    public bool a = false;
    public float timer = 0.5f;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (a && timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer < 0)
        {
            a = false;
            SceneManager.LoadScene("Inventory");
            Debug.Log("aa");
        }
    }
    public void OnClickInventory()
    {
        a = true;
    }}
