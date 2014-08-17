using UnityEngine;
using System.Collections;

public class zombieAnimator : MonoBehaviour {

	public Sprite[] sprites;
	public float framesPerSecond;
	private SpriteRenderer _spriteRenderer;

	// Use this for initialization
	void Start () {
		_spriteRenderer = renderer as SpriteRenderer;
	}
	
	// Update is called once per frame
	void Update () {
		int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
		index = index % sprites.Length;
		_spriteRenderer.sprite = sprites [index];
	}
}
