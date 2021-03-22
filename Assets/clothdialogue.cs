using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clothdialogue : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collider2D)
	{
		Debug.Log("ClothWindow Triggered");
		TriggerClothWindow();
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		FindObjectOfType<InventoryUI>().EndWindow();
	}

	private void TriggerClothWindow()
	{
		FindObjectOfType<InventoryUI>().StartWindow();
	}
}
