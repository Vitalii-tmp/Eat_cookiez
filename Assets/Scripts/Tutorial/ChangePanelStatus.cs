using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangePanelStatus : MonoBehaviour
{

    public GameObject ImageSwipeRight;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ImageSwipeRight.SetActive(true);
            Time.timeScale = 0;
        }
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            ImageSwipeRight.SetActive(false);
            Time.timeScale = 1;
        }
    }





}
