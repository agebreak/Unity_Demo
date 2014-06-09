using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {
	public Vector2 offset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 textureOffset = renderer.material.mainTextureOffset;
		textureOffset += offset * Time.deltaTime;
		renderer.material.mainTextureOffset = textureOffset;
	
	}
}
