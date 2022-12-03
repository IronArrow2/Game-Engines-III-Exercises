using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{
    [SerializeField]
    Canvas battleScreen;

    // Start is called before the first frame update
    void Start()
    {
        battleScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FleeButtonClicked()
    {
        //do any required cleanup, then close screen
        battleScreen.gameObject.SetActive(false);
    }

    public void BattleTriggered()
    {
        Debug.Log("Battle time!");
        battleScreen.gameObject.SetActive(true);
    }
}
