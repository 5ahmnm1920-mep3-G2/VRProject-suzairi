using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAppear : MonoBehaviour {

 [SerializeField]
private Text winText; // Insert your text object inside unity inspector
 
void Start()
{
    winText.enabled = false; // You may need to use .SetActive(false);
}
 
 
void OnCollisionEnter(Collision collision)
{
   if(collision.gameObject.tag == "BlueBall")
{
// This is where you make your text object appear on screen
    winText.enabled = true; // May need to use .SetActive(true);
}
}
 
void OnCollisionExit(Collision collision)
{
     // Here is where you make the text disappear off screen
      if(collision.gameObject.tag == "BlueBall")
{
   winText.enabled = false; // May need to use .SetActive(false);
}
}
}