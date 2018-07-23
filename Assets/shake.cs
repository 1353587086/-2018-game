using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class shake : MonoBehaviour {
    Sequence a;
    public bool tri = true;
	// Use this for initialization
	void Start () {
        tri = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (tri)
        {
            tri = false;
            var b = transform.position.y;
            a = DOTween.Sequence().Append(transform.DOMoveY(b + 0.1f, 0.5f))
                .Append(transform.DOMoveY(b - 0.1f, 1f))
                .Append(transform.DOMoveY(b,0.5f)).AppendCallback(() => { tri = true; });
            
        }
        
        
        
    }
    
}
