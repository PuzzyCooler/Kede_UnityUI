using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teli : MonoBehaviour
{
    public GameObject mainigaisAttels;
    public Sprite[] attelumasivs;
    public void izkritosais(int skaitlis){
        if(skaitlis == 0){
            mainigaisAttels.GetComponent<Image>().sprite = attelumasivs[0];
        }else if(skaitlis == 1) {
            mainigaisAttels.GetComponent<Image>().sprite = attelumasivs[1];
        }
    }
}