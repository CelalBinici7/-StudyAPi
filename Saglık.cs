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

      public void TakeDamage(float _damage) {
        currentHealt = Mathf.Clamp(currentHealt - _damage, 0, startingHealth);

        if (currentHealt > 0)
        {
            anima.SetTrigger("hurt");
            StartCoroutine(Invunerability());
        }
        else
        {
            if (!dead)
            {
                anima.SetTrigger("die");
                GetComponent<PlayerMovment>().enabled = false;
                dead = true;
            }
        }
    }

    private IEnumerator Invunerability() {
        Physics2D.IgnoreLayerCollision(10, 11, true);
        for (int i = 0; i < numberOfFlashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
            spriteRend.color = Color.white;
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
        }
        Physics2D.IgnoreLayerCollision(10, 11, false);
    }



}
