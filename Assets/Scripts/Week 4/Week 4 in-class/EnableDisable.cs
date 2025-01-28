using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public AudioSource audioS;
    public GameObject go;
    public SpriteRenderer circleSR;
    public EnableDisable script;
    public Transform circleTransform;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            circleSR.enabled = false;
            go.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            circleSR.enabled = true;
            go.SetActive(true);

            //go.activeInHierarchy
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (!audioS.isPlaying)
            {
                //audioS.Play();
                audioS.PlayOneShot(audioS.clip);
            }
            //audioS.clip.length
        }
    }
}
