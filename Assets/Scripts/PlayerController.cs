using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : CharacterTemplate
{
    Vector3 movementInput;
    float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movementInput * moveSpeed * Time.deltaTime;
    }

    public void AddMovementInput(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
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

        StartCoroutine(Flee());
    }

    IEnumerator Flee()
    {
        characterImage.transform.Rotate(0, 180, 0);

        Vector3 playerPos = characterImage.transform.position;
        for (float f = 0; f <= 1.0f; f += Time.deltaTime)
        {
            characterImage.transform.position -= new Vector3(500.0f * Time.deltaTime, 0, 0);
            yield return null;
        }


        characterImage.transform.Rotate(0, -180, 0);
        characterImage.transform.position = playerPos;
        turnEnded.Invoke();
        yield break;
    }
}
