using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Painelpause;
    public bool IsPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause()
    {
        if (IsPause)
        {
            Painelpause.SetActive(false);
            IsPause = false;
        }
        else 
        {
            Painelpause.SetActive(true);
            IsPause = true;
        }

        Painelpause.SetActive(true);
    }
}
