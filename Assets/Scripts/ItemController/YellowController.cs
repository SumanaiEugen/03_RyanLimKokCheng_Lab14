using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowController : MonoBehaviour
{
    public GameObject YellowText;
    private int yellowCounter;

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
            yellowCounter++;

            YellowText.GetComponent<Text>().text = "Yellow : " + yellowCounter;
            audiosource.Play();
        }
    }
}
