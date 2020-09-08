using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SwitchDance : MonoBehaviour
{
    public GameObject dancer;
    private string[] dances;
    private Color[] colors;
    public int danceIndex;
    public Light spotLight;
    private AudioSource[] audios;
    public Text genre;
    public Text instruction;
    public Text noSelection;

    // Start is called before the first frame update
    void Start()
    {
        dances = new string[transform.childCount];
        colors = new Color[transform.childCount];
        audios = GetComponents<AudioSource>();
        for (int i = 0; i < transform.childCount; i++) {
            dances[i] = transform.GetChild(i).gameObject.name;
            colors[i] = UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }

    
    public void incrementVal() {
        noSelection.enabled = false;
        instruction.enabled = false;
        audios[danceIndex].Stop();
        danceIndex++;
        if (danceIndex > dances.Length -1) {
            danceIndex = 0;
        }
        controller.genre = dances[danceIndex];
        spotLight.color = colors[danceIndex];
        genre.text = dances[danceIndex];
        audios[danceIndex].Play();
        dancer.GetComponent<Animator>().Play(dances[danceIndex]);
    }
    public void decrementVal() {
        noSelection.enabled = false;
        instruction.enabled = false;
        audios[danceIndex].Stop();
        danceIndex--;
        if (danceIndex < 0) {
            danceIndex = dances.Length-1;
        }
        controller.genre = dances[danceIndex];
        spotLight.color = colors[danceIndex];
        genre.text = dances[danceIndex];
        audios[danceIndex].Play();
        dancer.GetComponent<Animator>().Play(dances[danceIndex]);
    }
}
