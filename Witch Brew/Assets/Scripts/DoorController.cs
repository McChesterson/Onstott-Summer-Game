using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{

    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" && SceneManager.GetActiveScene().name == "House")
        {
            SceneManager.LoadScene("Outside");
        }
        else
        {
            SceneManager.LoadScene("House");
        }
    }
}
