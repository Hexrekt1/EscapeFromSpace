using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad2 : MonoBehaviour
{
    [SerializeField] private SceneManager Load2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            SceneManager.LoadSceneAsync(2);
    }
}
