using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cave : MonoBehaviour {
    public GameObject mist;
    public Color c1, c2;
	// Use this for initialization
	void Start () {
        
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "player") mist.GetComponent<SpriteRenderer>().color = c1;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "player") mist.GetComponent<SpriteRenderer>().color = c2;
    }

    // Update is called once per frame
    void Update () {
        if(!mist&& FindObjectOfType<Camera>()) mist = FindObjectOfType<Camera>().transform.Find("Mist").gameObject;

    }
}
