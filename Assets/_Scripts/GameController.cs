using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    //Public instance variable
    public int MonsterCount;
    public GameObject monster;

    

	// Use this for initialization
	void Start () {
        this.generateMonsters();
      
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    //generate/instantiate monster
    private void generateMonsters() {
        for (int count = 0; count < this.MonsterCount; count++)
        {
            Instantiate(monster);
        }
    }
    
}
