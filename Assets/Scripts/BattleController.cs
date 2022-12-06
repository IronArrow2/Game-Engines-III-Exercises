using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleController : MonoBehaviour
{
    private bool isPlayerTurn = true;

    [SerializeField]
    Canvas battleScreen;

    public PlayerController player;

    public EnemyController enemy;

    public List<GameObject> enemyPrefabs;

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
        if(isPlayerTurn)
        {
            player.PlayPhysicalAttackAnim();
            PlayerTurnEnded();
        }
    }

    public void SpecialAttackButtonClicked()
    {
        if(isPlayerTurn)
        {
            player.PlayMagicalAttackAnim();
            PlayerTurnEnded();
        }
    }

    public void DefendButtonClicked()
    {
        if(isPlayerTurn)
        {
            player.PlayStatBoostAnim();
            PlayerTurnEnded();
        }
    }

    public void FleeButtonClicked()
    {
        if(isPlayerTurn)
        {
            player.PlayUtilityAnim();
        }
    }

    public void BattleTriggered()
    {
        Debug.Log("Battle time!");
        isPlayerTurn = true;
        battleScreen.gameObject.SetActive(true);
    }

    public void PlayerTurnEnded()
    {
        isPlayerTurn = false;
        enemy.TakeTurn();
    }

    public void EnemyTurnEnded()
    {
        isPlayerTurn = true;
    }

     public void Flee()
    {
        battleScreen.gameObject.SetActive(false);
    }
}
