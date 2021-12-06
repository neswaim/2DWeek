using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(changeScene());
        }
    }

    public IEnumerator changeScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}
