using System.Collections;
using UnityEngine;


public class AttireRenderer : MonoBehaviour
{
	public SpriteRenderer rend;
	public static Sprite DefaultSprite, BeachSprite;
	public Animator animator;
	public RuntimeAnimatorController defaultAnimatorController;
	public RuntimeAnimatorController beachAnimatorController;

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
		else
		{
			rend.sprite = DefaultSprite;
			animator.runtimeAnimatorController = defaultAnimatorController;
		}
	}
}
