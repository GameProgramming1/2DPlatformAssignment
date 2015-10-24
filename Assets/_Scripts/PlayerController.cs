using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private AudioSource[] _audioSource;
    private AudioSource _coinSound;

	// Use this for initialization
	void Start () {

        this._audioSource = gameObject.GetComponents<AudioSource>();
        this._coinSound = this._audioSource[0];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Coin"))
        {
            this._coinSound.Play();
        }
    }
}
