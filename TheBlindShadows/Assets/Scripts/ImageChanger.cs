using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ImageChanger : MonoBehaviour
{

    [SerializeField] private Image[] _allSprites;
    private int i = 0; 

    public void ReplaceImage()
    {
        if(i == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
        _allSprites[i].gameObject.SetActive(false);
        i++;
        _allSprites[i].gameObject.SetActive(true);

       
    }
}
