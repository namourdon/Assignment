using UnityEngine;
using System.Collections;
[System.Serializable]
public class Speed {
    public float minSpeed, maxSpeed;
}

[System.Serializable]
public class DRift
{
    public float minDrift, maxDrift;
}
public class MonsterController : MonoBehaviour {

    public Speed speed;

    private float currentSpeed;
    public DRift drift;
    private float currentDrift;

    // Use this for initialization
    void Start()
    {
        this.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPositon = new Vector2(0.0f, 0.0f);
        currentPositon = gameObject.GetComponent<Transform>().position;
        currentPositon.x -= this.currentSpeed;
        currentPositon.y += this.currentDrift;
        gameObject.GetComponent<Transform>().position = currentPositon;

        if (currentPositon.x <= -1100)
        {
            this.Reset();
        }

    }
    private void Reset()
    {
        this.currentSpeed = Random.Range(speed.minSpeed, speed.maxSpeed);
        this.currentDrift = Random.Range(drift.minDrift,drift.maxDrift);
        Vector2 resetBackground = new Vector2(1100f, Random.Range(-680f, 661f));
        gameObject.GetComponent<Transform>().position = resetBackground;
    }
}
