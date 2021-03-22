using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
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
