using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatchingMechanic : MonoBehaviour
{
    [SerializeField] int baseCatchPercentage;
    WillSystem willSystem;
  //  MonsterScript monsterScript;   //Need to use the correct script to identify monsters
    int buttonMashTotal;
    int randomCatchNumber;
    [SerializeField] float mashDelay = 0.5f;
    bool pressed = false;
    bool started = false;
    float mash;
    [SerializeField] Slider slider;
    [SerializeField] float timerValue = 5.0f;
    float timer;
    bool calculatedCatch = false;

    [SerializeField] public bool buttonMashAccessibility = false;
    bool isLooping = false;
    bool pressAgain = true;
    [SerializeField] float timeBetweenPresses = 0.13f;  //This gives the same pressing speed as me. lol

    /*
    private void Awake()
    {
        slider = FindObjectOfType<Slider>();
        willSystem = FindObjectOfType<WillSystem>();
        monsterScript = FindObjectOfType<MonsterScript>();   //Need to use the correct script to identify monsters
    }

    private void Start()
    {
        mash = mashDelay;
        timer = timerValue;
        baseCatchPercentage = 1 + willSystem.playerRank - monsterScript.monsterRank;   //Need to use the correct script to identify monsters

        if (buttonMashAccessibility)
        {
            isLooping = true;
        }
    }


    private void Update()
    {
        if (!buttonMashAccessibility)
        {
            StartCatchingMonster();
        }

        else
        {
            StartAccessibleCatchingMonster();
        }
    }

    void StartCatchingMonster()
    {
        if (!started)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                started = true;
                mash -= Time.deltaTime;
                timer -= Time.deltaTime;
            }

        }

        if (started)
        {
            if (timer > 0)
            {
                mash -= Time.deltaTime;
                timer -= Time.deltaTime;

                if (Input.GetKeyDown(KeyCode.Space) && !pressed)
                {
                    pressed = true;
                    slider.value += 0.01f * baseCatchPercentage;
                    buttonMashTotal += baseCatchPercentage;
                    mash = mashDelay;
                }

                else if (Input.GetKeyUp(KeyCode.Space))
                {
                    pressed = false;
                }

                if (mash <= 0)
                {
                    slider.value -= 0.01f;
                    buttonMashTotal--;
                    mash = mashDelay;
                }
            }

            else
            {
                CalculateCatchChance();
            }
        }
    }

    void StartAccessibleCatchingMonster()
    {
        if (!started)
        {
            started = true;
            timer -= Time.deltaTime;
        }

        if (started)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;

                if (isLooping && pressAgain)
                {

                    StartCoroutine(ContinueButtonPress());
                }
            }

            else
            {
                CalculateCatchChance();
            }
        }
    }

    IEnumerator ContinueButtonPress()
    {
        pressAgain = false;

        slider.value += 0.01f * baseCatchPercentage;
        buttonMashTotal += baseCatchPercentage;

        yield return new WaitForSeconds(timeBetweenPresses);
        pressAgain = true;
    }


    void CalculateCatchChance()
    {
        if (!calculatedCatch)
        {

            randomCatchNumber = Random.Range(1, 101);

            if (buttonMashTotal >= randomCatchNumber)
            {
                //successful catch
                Debug.Log("You caught it! " + "button mash " + buttonMashTotal + " randon catch number " + randomCatchNumber);
                willSystem.playerCurrentWillPoints += willSystem.catchWillPoints;

                willSystem.GetPlayerRank();
            }

            else
            {
                //Failed catch
                Debug.Log("Failed to catch! " + " button mash " + buttonMashTotal + " randon catch number " + randomCatchNumber);
                willSystem.playerCurrentWillPoints -= willSystem.playerFailCatchWillPoints;

                willSystem.GetPlayerRank();
            }

        }

        calculatedCatch = true;
    }

    */
}
