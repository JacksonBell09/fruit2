using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flag : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("flag"))
        {
            SceneManager.LoadScene("start 1");
        }
    }
}
