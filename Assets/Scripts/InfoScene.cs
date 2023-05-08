using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoScene : MonoBehaviour
{
    public GameObject towerStack;
    public GameObject enemiesStack;
    public SceneFader sceneFader;


    public void Return()
    {
        sceneFader.FadeTo("Menu");
    }
    public void Tower()
    {
        towerStack.SetActive(true);
        enemiesStack.SetActive(false);
    }

    public void Enemies()
    {
        towerStack.SetActive(false);
        enemiesStack.SetActive(true);
    }
}
