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

        //Oblicza prêdkoœæ pocz¹tkow¹ i wypisuje j¹ w konsoli
        predkoscPoczatkowa = Mathf.Pow(predkoscKoncowa, 2)-2*grawitacja*przemieszczenie;
        predkoscPoczatkowa = Mathf.Sqrt(predkoscPoczatkowa);
        print("Prêdkoœæ pocz¹tkowa wynosi: "+predkoscPoczatkowa);
    }

    private void Update()
    {
        // Sprawdzanie, czy gracz jest na ziemi
        if (characterController.isGrounded)
        {
            // Je¿eli gracz jest na ziemi, resetuj prêdkoœæ skoku
            currentJumpSpeed = 0f;

            // Po naciœniêciu Spacji gracz skacze
            if (Input.GetButtonDown("Jump"))
            {
                // Oblicz prêdkoœæ skoku na podstawie prêdkoœci pocz¹tkowej i grawitacji
                currentJumpSpeed = predkoscPoczatkowa;
                moveDirection.y = currentJumpSpeed;
            }
        }

        // Zastosuj grawitacjê
        moveDirection.y += grawitacja * Time.deltaTime;

        // Ruch postaci
        characterController.Move(moveDirection * Time.deltaTime);
    }
}