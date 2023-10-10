using UnityEngine;
using UnityEngine.UI;
public class ItemCollection : MonoBehaviour
{
    private int cherries = 0;
    [SerializeField] private Text cherriesText;

    [SerializeField] private AudioSource collecttionSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collecttionSoundEffect.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries: " + cherries;
        }
    }
}
