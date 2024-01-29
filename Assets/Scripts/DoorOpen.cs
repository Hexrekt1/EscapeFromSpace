using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject E;
    public GameObject iskeytrue;
    public bool isplayer;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        isplayer = false;
        animator = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isplayer = true;
            E.SetActive(true);


        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            isplayer = false;
            E.SetActive(false);


        }
    }

    // Update is called once per frame
    void Update()
    {
        if (iskeytrue.active)
        {
            if(isplayer)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    E.SetActive(false);
                    animator.enabled = true;
                }
            }
        }
    }
}
