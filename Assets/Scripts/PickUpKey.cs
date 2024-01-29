using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PickUpKey : MonoBehaviour
{
    public GameObject Key;
    public GameObject keyimage;
    public GameObject keyistrue;
    public GameObject E;
    public bool isplayer;
    void Start()
    {
        isplayer = false;

        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            isplayer=true;
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
        if (isplayer) 
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                keyimage.SetActive(true);
                keyistrue.SetActive(true);
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                E.GetComponent<SpriteRenderer>().enabled = false;

            }
        }
    }
}
