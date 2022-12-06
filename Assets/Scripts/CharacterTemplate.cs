using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CharacterTemplate : MonoBehaviour
{
    public float health = 50.0f;
    public float physicalArmour = 5.0f;
    public float magicResistance = 10.0f;
    public float damage = 25.0f;

    public Image characterImage;

    [SerializeField]
    protected AnimationClip physicalAttackAnim;

    [SerializeField]
    protected AnimationClip magicalAttackAnim;

    [SerializeField]
    protected AnimationClip statBoostAnim;

    [SerializeField]
    protected AnimationClip utilityAnim;

    [SerializeField]
    protected Animator characterAnimator;

    public UnityEvent turnEnded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void PlayPhysicalAttackAnim() 
    {
        characterAnimator.Play(physicalAttackAnim.name);
    }
    public virtual void PlayMagicalAttackAnim()
    {
        characterAnimator.Play(magicalAttackAnim.name);
    }
    public virtual void PlayStatBoostAnim()
    {
        characterAnimator.Play(statBoostAnim.name);
    }
    public virtual void PlayUtilityAnim()
    {
        characterAnimator.Play(utilityAnim.name);
    }
}
