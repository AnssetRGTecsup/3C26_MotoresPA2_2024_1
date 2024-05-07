using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start1 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        AudioManagerController.Instance.PlayMusic(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
