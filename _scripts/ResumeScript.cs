using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResumeScript : MonoBehaviour
{
    public Button resumeButton;
    // Start is called before the first frame update
    void Start()
    {
        resumeButton.onClick.AddListener(ResumeGame);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ResumeGame()
    {
        Debug.Log("Resume Button Clicked");
        // Time.timeScale = 1f;
        // gameObject.SetActive(false);
    }
}
