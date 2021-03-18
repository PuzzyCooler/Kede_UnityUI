using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour {
    public GameObject cepure;
    public GameObject dzemperis;
    public GameObject bikses;
    public GameObject kurpe;


    public void hatatelosana(bool vertiba){
        cepure.SetActive(vertiba);
    }
    public void dzemperisatelosana(bool vertiba){
        dzemperis.SetActive(vertiba);
    }
    public void biksesatelosana(bool vertiba){
        bikses.SetActive(vertiba);
    }
    public void kurpeatelosana(bool vertiba){
        kurpe.SetActive(vertiba);
    }
}
