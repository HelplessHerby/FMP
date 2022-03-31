using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FinishLine : MonoBehaviour
{
	private Mover player;
	private PlayerInput playerInput;



	private void OnTriggerEnter(Collider other)
	{
		player = FindObjectOfType<Mover>();
		if (player != null)
		{
			player.Win();
			Debug.Log(other.name + " has won!");
		}
	}

}
