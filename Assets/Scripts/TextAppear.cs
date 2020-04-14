using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAppear : MonoBehaviour {

public GameObject winText;
public GameObject buttonText;
 
void Start() {

    winText.SetActive(false);
    buttonText.SetActive(false);
}
 
void OnCollisionEnter(Collision collision) {

   if(collision.gameObject.tag == "Power") {

    winText.SetActive(true);
    buttonText.SetActive(true);
}
}

void OnCollisionExit(Collision collision) {

      if(collision.gameObject.tag == "Power") {

   winText.SetActive(false);
   buttonText.SetActive(false);

	}

    }

}