using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.Events;

public class TilemapTriggerController : MonoBehaviour
{
    [SerializeField]
    TilemapCollider2D tilemapCollider;

    public UnityEvent battleTriggered;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided with " + collision.name);
        StartCoroutine(CheckTriggerBattleScene());
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log(":3");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("No longer colliding with " + collision.name);
        StopCoroutine(CheckTriggerBattleScene());
    }

    IEnumerator CheckTriggerBattleScene()
    {
        while(true)
        {
            int rand = Random.Range(1, 20);

            if (rand == 1)
            {
                //Debug.Log("Battle triggered");
                battleTriggered.Invoke();
                yield break;
            }
            else
            {
                Debug.Log("No battle yet");
                yield return new WaitForSeconds(1.0f);
            }
        }
    }
}
