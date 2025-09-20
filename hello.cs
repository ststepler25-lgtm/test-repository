{hello world!}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviourPunCallbacks
{

    GameManager gameManager;
    private int health;
    bool isPistol, isRifle, isMiniGun;
    [SerializeField] GameObject damageUi;
    [SerializeField] GameObject pistol, rifle, miniGun;
    [SerializeField] float movementSpeed = 5f;
                     float currentSpeed;
                           Rigidbody rb;
                           Vector3 direction;
    [SerializeField] float shiftSpeed = 10f;
    [SerializeField] float jumpForce = 7f;
    bool isGrounded = true;
    Animator anim;
    public bool dead;
    [SerializeField] AudioSource characterSounds;
    //Ссылка на звук прыжка
    [SerializeField] AudioClip jump;
    // Start is called before the first frame update