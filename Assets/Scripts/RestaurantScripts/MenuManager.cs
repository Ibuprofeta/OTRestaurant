using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Level1()
    {
        PlayerPrefs.SetInt("Recipes", 1);
        SceneManager.LoadScene("Kitchen");
    }
    public void Level2()
    {
        PlayerPrefs.SetInt("Recipes", 2);
        SceneManager.LoadScene("Kitchen");
    }
    public void Level3()
    {
        PlayerPrefs.SetInt("Recipes", 3);
        SceneManager.LoadScene("Kitchen");
    }
    public void Level4()
    {
        PlayerPrefs.SetInt("Recipes", 4);
        SceneManager.LoadScene("Kitchen");
    }
    public void Level5()
    {
        PlayerPrefs.SetInt("Recipes", 5);
        SceneManager.LoadScene("Kitchen");
    }
    public void Level6()
    {
        PlayerPrefs.SetInt("Recipes", 6);
        SceneManager.LoadScene("Kitchen");
    }
    public void Level7()
    {
        PlayerPrefs.SetInt("Recipes", 7);
        SceneManager.LoadScene("Kitchen");
    }
    public void Level8()
    {
        PlayerPrefs.SetInt("Recipes", 8);
        SceneManager.LoadScene("Kitchen");
    }
    public void Level9()
    {
        PlayerPrefs.SetInt("Recipes", 9);
        SceneManager.LoadScene("Kitchen");
    }
    public void Level10()
    {
        PlayerPrefs.SetInt("Recipes", 10);
        SceneManager.LoadScene("Kitchen");
    }
}
