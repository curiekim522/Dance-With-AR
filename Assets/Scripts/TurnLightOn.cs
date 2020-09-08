using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightOn : MonoBehaviour
{
    Light spotLight;
    Light pointLight;
    // Start is called before the first frame update
    void Start()
    {
        spotLight = GameObject.Find("Spot Light").GetComponent<Light>();
        pointLight = GameObject.Find("Point Light").GetComponent<Light>();
        spotLight.enabled = false;
        pointLight.enabled = false;
        StartCoroutine(TurnOnLight());
    }

    // Update is called once per frame
    private IEnumerator TurnOnLight()
    {
        yield return new WaitForSeconds(1f);
        spotLight.enabled = true;
        pointLight.enabled = true;
    }
}
