using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrangeController : MonoBehaviour
{
    public GameObject OrangeText;
    private int orangeCounter;

    private AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            orangeCounter++;

            OrangeText.GetComponent<Text>().text = "Orange : " + orangeCounter;
            audiosource.Play();
        }
    }
}
