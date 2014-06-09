using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		CharacterController controller = gameObject.GetComponentInChildren<CharacterController>();
		
		Vector3 vecDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		
		vecDir *= 3;
		
		if(vecDir.magnitude > 0)
		{
			animation.Play("run");
			transform.rotation = Quaternion.LookRotation(vecDir);
		}
		else
		{
			animation.Play("idle");
		}
		
		// 점프
		if(Input.GetKey(KeyCode.Space))
		{
			Vector3 vJump = new Vector3(0, 10 * Time.deltaTime, 0);
			controller.Move(vJump);
		}
		
		controller.SimpleMove(vecDir);	
	
	}
}
