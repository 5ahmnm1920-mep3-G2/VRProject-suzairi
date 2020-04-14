using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverText : MonoBehaviour {

    public GameObject winText;
    public GameObject buttonText;

    public void Start() {

        winText.SetActive(false);
        buttonText.SetActive(false);
    }

    public void OnMouseOver() {

        winText.SetActive(true);
	buttonText.SetActive(true);
    }
    
 }