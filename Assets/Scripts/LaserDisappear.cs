using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDisappear : MonoBehaviour {

 public GameObject laser;
 public GameObject button;
 public GameObject laser1;
 public GameObject laser2;
 public GameObject laser3;
 public GameObject laser4;
 public GameObject laser5;
 public GameObject laser6;
 
 void Start () {

       button.SetActive (true);
       laser.SetActive  (true);
       laser1.SetActive (true);
       laser2.SetActive (true);
       laser3.SetActive (true);
       laser4.SetActive (true);
       laser5.SetActive (true);
       laser6.SetActive (true);
 }
 
 public void clickThisButton() {

       button.SetActive (false);
       laser.SetActive  (false);
       laser1.SetActive (false);
       laser2.SetActive (false);
       laser3.SetActive (false);
       laser4.SetActive (false);
       laser5.SetActive (false);
       laser6.SetActive (false);
 }

}