using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jāieimportē, lai varētu strādāt ar UI elementiem
using UnityEngine.UI;

public class vards : MonoBehaviour
{
    //Mainīgajā saglabās tekstu, ko raksta teksta laukā
    public string teksts;
    public string gads;
    //Lauks, kura ieraksta tekstu
    public GameObject ievadeslauks1;
    public GameObject ievadeslauks2;
    //attēlo tekstu
    public GameObject tekstaAtteloshana;

    //Funkcija tiek izsaukta nospiežot pogu
    public void uzglabatTekstu()
    {
        teksts = ievadeslauks1.GetComponent<Text>().text;
        gads = ievadeslauks2.GetComponent<Text>().text;
        tekstaAtteloshana.GetComponent<Text>().text = "Sveiks, " + teksts.ToUpper() + "tu esi " + gads + " gadus vecs!";
    }

}