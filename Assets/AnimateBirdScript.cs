using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateBirdScript : MonoBehaviour
{

    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!(logic.gameIsPaused))
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)
                || Input.touchCount > 0)
            {
                GetComponent<Animator>().SetTrigger("BirdFlap");
            }
        }
    }
}
