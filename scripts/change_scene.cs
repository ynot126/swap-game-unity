using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class change_scene : MonoBehaviour
{
    [SerializeField] private Image black_scene;
    public void switch_title()
    {
        StartCoroutine(changescene(name: "title"));
    }
    public void switch_menu()
    {
        StartCoroutine(changescene(name:"menu"));
    }
    public void switch_level(int num)
    {
        StartCoroutine(changescene(num));
    }
    public void restart()
    {
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        StartCoroutine(changescene(SceneManager.GetActiveScene().buildIndex));
    }
    private IEnumerator changescene( int buildindex=0, string name="default")
    {
        if (name== "default")
        {
            black_scene.GetComponent<Animator>().Play("end scene");
            yield return new WaitForSeconds(0.25f);
            SceneManager.LoadScene(buildindex);
            yield return new WaitForSeconds(0.25f);
        }
        else
        {
            black_scene.GetComponent<Animator>().Play("end scene");
            yield return new WaitForSeconds(0.25f);
            SceneManager.LoadScene(name);
            yield return new WaitForSeconds(0.25f);
        }
    }
}
