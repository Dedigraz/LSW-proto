using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
	public Image icon;
	public GameObject InventoryObj;

	private void Update()
	{
		
	}
	public void UseItem()
	{ 
		FindObjectOfType<AttireRenderer>().ChangeSprite();
		FindObjectOfType<InventoryUI>().EndWindow();
	}

	//public override void Use()
	//{
	//	base.Use();

	//	ChangeSprite(item);
	//}

}
