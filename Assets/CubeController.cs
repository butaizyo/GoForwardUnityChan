using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	//Audioのコンポーネント（課題追加）
	public AudioClip audioClip1;
	private AudioSource audioSource;

	//キューブの移動速度
	private float speed = -0.2f;

	//消滅位置
	private float deadLine = -10f;


	// Use this for initialization
	void Start () {
		//AudioSourceコンポーネントを取得
		audioSource = gameObject.GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {
		//キューブを移動させる
		transform.Translate (this.speed, 0,0);

		//画面外に出たら破棄する
		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "ground.tag" || collision.gameObject.tag == "cube.tag") {
			audioSource.Play ();
		}
	}
}

		