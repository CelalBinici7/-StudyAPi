using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    [SerializeField] private float startingHealth;
    public float currentHealt {get; private set;}
    private Animator anima;
    private bool dead;

    
    [Header("iFrames")]
    [SerializeField] private float iFramesDuration;
    [SerializeField] private int numberOfFlashes;
    private SpriteRenderer spriteRend;

    
    private void Awake() {
        currentHealt = startingHealth;
        anima = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();
    }

  



}
