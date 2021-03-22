using System.Collections;
using UnityEngine;


public class AttireRenderer : MonoBehaviour
{
	public static SpriteRenderer rend;
	public Sprite DefaultSprite, BeachSprite;
	public Animator animator;
	public  RuntimeAnimatorController defaultAnimatorController = Resources.Load<RuntimeAnimatorController>("Animations/Player");
	public  RuntimeAnimatorController beachAnimatorController = Resources.Load<RuntimeAnimatorController>("Animations/beachAnimation/Beach Costume");

	private void Awake()
	{
		rend = GetComponent<SpriteRenderer>();
		rend.sprite = DefaultSprite;
		animator.GetComponent<Animator>();
		animator.runtimeAnimatorController = defaultAnimatorController;
	}
	public void ChangeSprite()
	{
		if (rend.sprite == DefaultSprite)
		{
			rend.sprite = BeachSprite;
			animator.runtimeAnimatorController = beachAnimatorController;
		}
		if(rend.sprite == BeachSprite)
		{
			rend.sprite = DefaultSprite;
			animator.runtimeAnimatorController = defaultAnimatorController;
		}
	}

}
