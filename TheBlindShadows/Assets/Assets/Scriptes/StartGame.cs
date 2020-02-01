using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;
using System;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField]
    [SerializeField]
   Text []texts;
    int curr = 0;
    void Start()
    {

        texts[curr].color = Color.yellow;
      

    }
    public void OnClickStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1,LoadSceneMode.Single);
    }
    public void OnClickQuit()
    {
        //Debug.Log("exit");
        Application.Quit();
        //EditorApplication.Exit(0);
       
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            texts[curr].color = Color.white;
            curr++;
            if (curr==texts.Length)
            {
                curr = 0;
            }

            texts[curr].color = Color.yellow;
        }  
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            texts[curr].color = Color.white;
            curr--;
            if (curr==-1)
            {
                curr = texts.Length-1;
            }

            texts[curr].color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            switch (curr)
            {
                case 0:
                    OnClickStart();
                        break;
                case 1:
                    break;
                case 2:
                    OnClickQuit();
                    break;

               
            }
        }
    }
}
