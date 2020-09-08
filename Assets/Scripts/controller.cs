using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controller : MonoBehaviour
{
    public static string genre = "Hip Hop";
    public AudioSource music;
    public Text noSelection;
    // Start is called before the first frame update
    public void exit() {
        Application.Quit();
    }

    public void setScene(string scene) {
        if (scene == "Main" && genre == null) {
            noSelection.text = "**You need to select a genre to begin**";
        } else {
            SceneManager.LoadScene(scene);
        }
    }
}
