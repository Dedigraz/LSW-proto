using System;
using UnityEngine;

public class Wallet : MonoBehaviour
{
	[SerializeField] private int startingFunds = 1000;
	public static Wallet Instance;
	public Action Balance;

	public int money;

	private void Awake()
	{
		Instance = this;
	}
	// Start is called before the first frame update
	void Start()
	{
		Add(startingFunds);
	}

	public bool CanAfford(int cost) => money >= cost;

	public int GetBalance() => money;
	private void Add(int fund)
	{
		if(fund >= 0)
		{
			money += fund;
			Balance?.Invoke();
		}
	}
	

	public void TryWithdraw(int funds)
	{
		if (!CanAfford(funds))
		{
			return;
		}

		money -= funds;
		Balance?.Invoke();
	}

	public void WithdrawOnCredit(int amount,bool IsBroke = true)
	{
		if (IsBroke && money < 0)
			return;

		money -= amount;
		Balance.Invoke();
	}
}
