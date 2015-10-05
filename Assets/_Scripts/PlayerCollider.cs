using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour {
    //private instance variables
    private AudioSource[] _AudioSources; //collection of the sources
    private AudioSource _SlimeAudio, _SuccessAudio,_playerSound;

    //public GameObject eggs;
    public Text score;
    public Text lives;
    public Text gameOver;
    public Text StartGame;
    public int initialScore = 0;
    public int livesAmount = 5;

    // Use this for initialization



    void Start () {
        this._AudioSources = this.GetComponents<AudioSource>();
        this._SlimeAudio = this._AudioSources[0]; //reference slime sound
        this._SuccessAudio = this._AudioSources[1];
     
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D otherGameObject) {
        
        if (otherGameObject.tag == "Monster")
        {
            this._SlimeAudio.Play();
            this.livesAmount--;
            if (this.livesAmount <= 0) {
                this._EndGame();
            }
           
            
        }
        if (otherGameObject.tag == "Eggs")
        {
            this._SuccessAudio.Play();
        
          this.initialScore += 10;
           
        }
        this.FinalScore();
    }
    private void FinalScore()
    {
        this.score.text = "Score:" + this.initialScore;
        this.lives.text = "Lives:" + this.livesAmount;
    }
    private void _EndGame()
    {
       // this._AudioSources.Play();
        Destroy(gameObject);
        this.score.enabled = false;
        this.lives.enabled = false;
        this.gameOver.enabled = true;
        this.StartGame.enabled = true;
        this.StartGame.text = "Score: " + this.initialScore;
    }

}
