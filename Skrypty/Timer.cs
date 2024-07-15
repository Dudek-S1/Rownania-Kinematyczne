using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class Timer : MonoBehaviour
{
	public ParticleSystem m_ParticleSystem;
	public static float przewidywanyCzas;
	public Motor objektA;
	public Motor objektB;

	public float timeStep = 0.02f;


	float currentTime;
	bool yomen = true;
	bool yomen1 = true;
	[SerializeField] TextMeshProUGUI countdownText;
	// Use this for initialization
	void Start()
	{

		Time.fixedDeltaTime = timeStep;

		float h = objektA.transform.position.x - objektB.transform.position.x;

		float a = objektB.przyspieszenie - objektA.przyspieszenie;
		float b = 2 * (objektB.predkoscPoczatkowa - objektA.predkoscPoczatkowa);
		float c = -2 * h;

		przewidywanyCzas = (-b + Mathf.Sqrt(b * b - 4 * a * c)) / (2 * a);
		print("Przewidywany Czas: "+przewidywanyCzas);
		currentTime = 0;
	}
	void Update()
	{
        if (yomen)
        {
			currentTime += 1 * Time.deltaTime;
			countdownText.text = currentTime.ToString("Przewidywany czas: ") + currentTime;
        }
		


		if (currentTime >= 4)
        {
			if (yomen1)
			{
				m_ParticleSystem.Play();
				yomen1 = false;
			}

			yomen = false;
            currentTime = 4;
			countdownText.text = currentTime.ToString("Przewidywany czas: ") + currentTime;
			// Your Code Here
		}
    }

}
