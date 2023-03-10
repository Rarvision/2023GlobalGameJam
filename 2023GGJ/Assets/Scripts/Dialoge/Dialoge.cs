using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialoge : MonoBehaviour
{
    [SerializeField] private GameObject Button;
    [SerializeField] private GameObject talkUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Button.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Button.SetActive(false);
    }

    private void Update()
    {
        if (Button.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            talkUI.SetActive(true);
        }
    }

}   