using UnityEngine;
using System.Collections;

public class Circle : MonoBehaviour {

	public GameObject prefab;

	private GameObject _myNewObject;

    int num = 12;

    void Start() {

		Vector3 mid = transform.position;
		for (int i = 0; i < (num/3); i++) {
			int a = i * 90;
			Vector3 pos = RandomCircle(mid, 3.0f ,a);
			_myNewObject = Instantiate(prefab, pos, Quaternion.identity);
			_myNewObject.GetComponent<Renderer> ().material.color = Color.red;
			_myNewObject.tag = "Red";
		}
		for (int i = 0; i < (num/3); i++) {
			int a = i * 90 + 30;
			Vector3 pos = RandomCircle(mid, 3.0f ,a);
			_myNewObject = Instantiate(prefab, pos, Quaternion.identity);
			_myNewObject.GetComponent<Renderer> ().material.color = Color.gray;
			_myNewObject.tag = "Gray";
		}
		for (int i = 0; i < (num/3); i++) {
			int a = i * 90 + 60;
			Vector3 pos = RandomCircle(mid, 3.0f ,a);
			_myNewObject = Instantiate(prefab, pos, Quaternion.identity);
			_myNewObject.GetComponent<Renderer> ().material.color = Color.green;
			_myNewObject.tag = "Green";
		}
	}
	Vector3 RandomCircle(Vector3 center, float radius,int a) {
		Debug.Log(a);
		float ang = a;
		Vector3 pos;
		pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
		pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
		pos.y = center.y;
		return pos;
	}
}