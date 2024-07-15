using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phys : MonoBehaviour
{
    private float currentJumpSpeed;
    private CharacterController characterController;
    private Vector3 moveDirection;

    private float grawitacja = -20f;
    private float przemieszczenie = 3f;
    private float predkoscKoncowa = 0f;
    private float predkoscPoczatkowa;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();

        //Oblicza pr�dko�� pocz�tkow� i wypisuje j� w konsoli
        predkoscPoczatkowa = Mathf.Pow(predkoscKoncowa, 2)-2*grawitacja*przemieszczenie;
        predkoscPoczatkowa = Mathf.Sqrt(predkoscPoczatkowa);
        print("Pr�dko�� pocz�tkowa wynosi: "+predkoscPoczatkowa);
    }

    private void Update()
    {
        // Sprawdzanie, czy gracz jest na ziemi
        if (characterController.isGrounded)
        {
            // Je�eli gracz jest na ziemi, resetuj pr�dko�� skoku
            currentJumpSpeed = 0f;

            // Po naci�ni�ciu Spacji gracz skacze
            if (Input.GetButtonDown("Jump"))
            {
                // Oblicz pr�dko�� skoku na podstawie pr�dko�ci pocz�tkowej i grawitacji
                currentJumpSpeed = predkoscPoczatkowa;
                moveDirection.y = currentJumpSpeed;
            }
        }

        // Zastosuj grawitacj�
        moveDirection.y += grawitacja * Time.deltaTime;

        // Ruch postaci
        characterController.Move(moveDirection * Time.deltaTime);
    }
}