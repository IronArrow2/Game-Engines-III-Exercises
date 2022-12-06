using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : CharacterTemplate
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeTurn()
    {
        StartCoroutine(Turn());
    }

    IEnumerator Turn()
    {
        yield return new WaitForSeconds(1.0f);

        //do things here
        PlayPhysicalAttackAnim();

        yield return new WaitForSeconds(1.0f);

        turnEnded.Invoke();
        yield break;
    }

    public override void PlayPhysicalAttackAnim()
    {
        base.PlayPhysicalAttackAnim();
    }

    public override void PlayMagicalAttackAnim()
    {
        base.PlayMagicalAttackAnim();
    }

    public override void PlayStatBoostAnim()
    {
        base.PlayStatBoostAnim();
    }

    public override void PlayUtilityAnim()
    {
        base.PlayUtilityAnim();
    }
}
