using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorAnimation : MonoBehaviour
{
	#region Unity API
	
	private void Awake()
	{
		if(_conveyor == null) { _conveyor = GetComponent<Conveyor>(); }
	}

	private void Update()
	{
		BeltAnimation();
	}

	#endregion


	#region Utils

	private void BeltAnimation()
	{
		float offset = Time.time * _conveyor.GetSpeed() * -0.32f;

		_renderer.material.SetTextureOffset("_MainTex", new Vector2(0f, offset));
	}

	#endregion


	#region Private And Protected Members

	[SerializeField] private MeshRenderer _renderer;
	private Conveyor _conveyor;

	#endregion
}