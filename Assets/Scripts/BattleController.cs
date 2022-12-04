using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleController : MonoBehaviour
{
    [SerializeField]
    Canvas battleScreen;

    [SerializeField]
    Image playerImage;

    [SerializeField]
    Image enemyImage;

    [SerializeField]
    Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        //battleScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackButtonClicked()
    {
        playerAnimator.Play("PlayerAttack1");
    }

    public void SpecialAttackButtonClicked()
    {
        playerAnimator.Play("PlayerAttack2");
    }

    public void DefendButtonClicked()
    {
        playerAnimator.Play("PlayerGuard");
    }

    public void FleeButtonClicked()
    {
        playerAnimator.Play("PlayerRun");
        playerImage.transform.Rotate(0, 180, 0);
        StartCoroutine(Flee());
    }

    public void BattleTriggered()
    {
        Debug.Log("Battle time!");
        battleScreen.gameObject.SetActive(true);
    }

    IEnumerator Flee()
    {
        Vector3 playerPos = playerImage.transform.position;
        for(float f = 0; f <= 1.0f; f += Time.deltaTime)
        {
            playerImage.transform.position -= new Vector3(500.0f * Time.deltaTime, 0, 0);
            yield return null;
        }


        playerImage.transform.Rotate(0, -180, 0);
        playerImage.transform.position = playerPos;
        battleScreen.gameObject.SetActive(false);
        yield break;
    }
}
