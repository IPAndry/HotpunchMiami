using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceSmash : MonoBehaviour
{
    bool nextFace = false;
    public float faceHealth = 70;

    public Animator faceClick;

    public AudioSource facePunch;
    public AudioSource faceSmash;

    public Slider faceHealthSlider;
    public Text faceHealthText;
    public Text faceHealthTextShade;

    public Sprite[] faceImage;
    public SpriteRenderer faceRenderer;

    public GameObject[] smashParticles;
    GameObject particleBlood;

    bool smashOne = true;
    bool smashTwo = false;

    private void Start()
    {
        faceHealthSlider.maxValue = faceHealth;
    }

    private void Update()
    {
        faceHealthText.text = faceHealth.ToString();
        faceHealthTextShade.text = faceHealth.ToString();
        faceHealthSlider.value = faceHealth;
    }

    private void OnMouseDown()
    {
        faceHealth -= ClearClickSystem.punchPower;

        faceClick.Play("FaceTouching");
        facePunch.Play();

        FaceOne();
    }

    public void FaceOne()
    {

        // Как-нибудь переделать этот кошмар, но потом
        if (faceHealth > 60)
        {
            faceRenderer.sprite = faceImage[7];
            smashTwo = false;
        }
        else if (faceHealth > 50)
        {
            faceRenderer.sprite = faceImage[6];
            smashOne = false;
            if (smashTwo == false)
            {
                faceSmash.Play();
                GameObject splash = Instantiate(smashParticles[0]);
                Destroy(splash, 1);
                smashTwo = true;
            }
        }
        else if (faceHealth > 40)
        {
            faceRenderer.sprite = faceImage[5];
            smashTwo = false;
            if (smashOne == false)
            {
                faceSmash.Play();
                GameObject splash = Instantiate(smashParticles[0]);
                Destroy(splash, 1);
                smashOne = true;
            }
        }
        else if (faceHealth > 30)
        {
            faceRenderer.sprite = faceImage[4];
            smashOne = false;
            if (smashTwo == false)
            {
                faceSmash.Play();
                GameObject splash = Instantiate(smashParticles[0]);
                Destroy(splash, 1);
                smashTwo = true;
            }
        }
        else if (faceHealth > 20)
        {
            faceRenderer.sprite = faceImage[3];
            smashTwo = false;
            if (smashOne == false)
            {
                faceSmash.Play();
                GameObject splash = Instantiate(smashParticles[0]);
                Destroy(splash, 1);
                smashOne = true;
            }
        }
        else if (faceHealth > 10)
        {
            faceRenderer.sprite = faceImage[2];
            smashOne = false;
            if (smashTwo == false)
            {
                faceSmash.Play();
                GameObject splash = Instantiate(smashParticles[0]);
                Destroy(splash, 1);
                smashTwo = true;
            }
        }
        else if (faceHealth > 0)
        {
            faceRenderer.sprite = faceImage[1];
            smashTwo = false;
            if (smashOne == false)
            {
                faceSmash.Play();
                GameObject splash = Instantiate(smashParticles[0]);
                Destroy(splash, 1);
                smashOne = true;
            }
        }
        else if (faceHealth <= 0 && nextFace == false)
        {
            faceSmash.Play();
            faceRenderer.sprite = faceImage[0];
            nextFace = true;
            smashOne = false;

            particleBlood = Instantiate(smashParticles[1]);

            if (smashTwo == false)
            {
                GameObject splash = Instantiate(smashParticles[0]);
                Destroy(splash, 1);
                smashTwo = true;
            }
        }
        else if (nextFace == true)
        {
            faceHealth = 70;
            nextFace = false;
            Destroy(particleBlood);
            faceRenderer.sprite = faceImage[7];
        }

    }
}
