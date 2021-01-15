using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanoSphere : MonoBehaviour
{

    // Attach to an empty object, put all panoramic sphere here in the showing sequence

    [Header("Change number, drop panospheres here")]

    public GameObject[] panoSphere;

    [Header("Press key 'space' to switch spheres")]

    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        // On start, Only keep the first panosphere active
        for (int j =1; j < panoSphere.Length; j++ )
        {
            panoSphere[j].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // for Quiting the application
        {
            if (Input.GetKeyDown(KeyCode.Escape))
                Application.Quit();
        }


        // for switching the pano spheres
        if (Input.GetKeyDown("space"))
        {
            // Close all panosphere
            for (int j = 0; j < panoSphere.Length; j++)
            {
                panoSphere[j].SetActive(false);
            }
            // turn on the i panosphere
            panoSphere[i].SetActive(true);
            Camera.main.transform.position = panoSphere[i].transform.position;
            if (i < panoSphere.Length)
            {
                i++;
            }

            if (i >= panoSphere.Length)
            {
                i = 0;
            }
                
        }
    }
}
    