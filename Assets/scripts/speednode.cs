using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class speednode : MonoBehaviour
{
    public float moveSpeed;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("speednode"))
        {
            moveSpeed+=5f;
        }
    }
}
