using UnityEngine;
using System.Collections;

public class KinematicWander : MonoBehaviour {

	public float max_angle = 0.4f;

	Move move;

    int time = 0;
    Vector3 velocity;

	// Use this for initialization
	void Start () {
		move = GetComponent<Move>();
        velocity = new Vector3(RandomBinominal(), 0, RandomBinominal());
    }

	// number [-1,1] values around 0 more likely
	float RandomBinominal()
	{
		return Random.value + Random.value;
	}
	
	// Update is called once per frame
	void Update () 
	{
        // TODO 9: Generate a velocity vector in a random rotation (use RandomBinominal) and some attenuation factor
        time += 50;
 
        if (time % 100 == 0)
        {

            Vector3 velocity = new Vector3(RandomBinominal(), 0,RandomBinominal());
            move.transform.Rotate(velocity);
            move.SetMovementVelocity(move.max_mov_velocity * velocity);

        }
        
	}
}
