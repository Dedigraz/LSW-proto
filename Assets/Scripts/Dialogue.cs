using System.Collections;
using UnityEngine;


[System.Serializable]
public class Dialogue
{
	public string ClerkTalk = "Hello there adventurer, before you begin on your journey why not do it in a change of clothes";
	[TextArea(3, 10)]
	public string button1Text ="Just chilling";
	[TextArea(3, 10)]
	public string button2Text = "Buy from terminal";
}
