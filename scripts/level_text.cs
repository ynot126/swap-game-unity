using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_text : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = SceneManager.GetActiveScene().name;
    }
}
