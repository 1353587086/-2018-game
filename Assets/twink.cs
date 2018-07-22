using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class twink : MonoBehaviour {
    SpriteRenderer sp;
    // Use this for initialization
    void Start () {

         sp= GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        if (sp.color[3] == 1) 
            sp.DOFade(0, 1f);
        if (sp.color[3] == 0)
            sp.DOFade(1, 1f);
	}
}
