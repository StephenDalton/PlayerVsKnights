using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControls : MonoBehaviour {
	/*
	public GameObject player;
	public Transform target;
	public float smooth = 2000;
	private Vector3 _endPosition;
	private Vector3 _startPosition;

	private void Awake () {
		_startPosition = player.transform.position;
	}

	void Update () {
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer) {
			_endPosition = HandleTouchInput ();
		} else {
			_endPosition = HandleMouseInput ();
		}
		player.transform.position = Vector3.MoveTowards (transform.position, target.position, 3f);
		//player.transform.position = Vector3.Lerp (player.transform.position, new Vector3 (-5f, _endPosition.y, 0), Time.deltaTime * smooth);
	}

	private Vector3 HandleTouchInput() {
		for (var i = 0; i < Input.touchCount; i++) {
			if (Input.GetTouch (i).phase == TouchPhase.Began) {
				var screenPosition = Input.GetTouch (i).position;
				_startPosition = Camera.main.ScreenToWorldPoint (screenPosition);
			}
		}
		return _startPosition;
	}
	private Vector3 HandleMouseInput () {
		if (Input.GetMouseButtonDown (0)) {
			var screenPosition = Input.mousePosition;
			_startPosition = Camera.main.ScreenToWorldPoint (screenPosition);
		}
		return _startPosition;
	}*/
}