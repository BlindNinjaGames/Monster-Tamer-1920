using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CatchingMechanic : MonoBehaviour
{
    [SerializeField] float baseCatchPercentage;
    [SerializeField] float lowHPBonus;  //If monster HP is 30% or lower, lowHPBonus is 0.2. Otherwise, it's zero. Must be set in the BattleSystem script.
    [SerializeField] float conditionBonus;  //If monster has a condition is true, conditionBonus is 0.2. Otherwise, it's zero. Must be set in the BattleSystem script.
    WillSystem willSystem;
 //   MonsterScript monsterScript;   //Need to use the correct script to identify monsters
    float buttonMashTotal;
    int randomCatchNumber;
    [SerializeField] float mashDelay = 0.2f;
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
    [SerializeField] float timeBetweenPresses = 0.13f;

    [SerializeField] TextMeshProUGUI caughtMonsterText;
    [SerializeField] TextMeshProUGUI failedCatchText;
    [SerializeField] TextMeshProUGUI countdownDisplay;
    int countdownTime = 5;

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

        //This line of code should probably be calculdated in the BattleSystem script and the result of baseCatchPercentage should just be brought over here to be used.
        baseCatchPercentage = 1 + willSystem.playerRank - monsterScript.monsterRank + lowHPBonus + conditionBonus;   //Need to use the correct script to identify monsters

        caughtMonsterText.gameObject.SetActive(false);
        failedCatchText.gameObject.SetActive(false);
        countdownDisplay.gameObject.SetActive(false);

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
                countdownDisplay.gameObject.SetActive(true);
                StartCoroutine(CountdownTimer());
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
                    if (baseCatchPercentage != 0)
                    {
                        pressed = true;
                        slider.value += 0.01f * baseCatchPercentage;
                        buttonMashTotal += baseCatchPercentage;
                        mash = mashDelay;
                    }

                }


                else if (Input.GetKeyUp(KeyCode.Space))
                {
                    pressed = false;
                }

                if (mash <= 0)
                {
                    if (baseCatchPercentage != 0)
                    {
                        slider.value -= 0.02f;
                        buttonMashTotal -= 2;
                        mash = mashDelay;
                    }

                    else
                    {
                        slider.value -= 0.03f;
                        buttonMashTotal -= 3;
                        mash = mashDelay;
                    }
                }
            }

            else
            {
                countdownDisplay.gameObject.SetActive(false);
                CalculateCatchChance();
            }
        }
    }

    void StartAccessibleCatchingMonster()
    {
        if (!started)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                started = true;
                mash -= Time.deltaTime;
                timer -= Time.deltaTime;
                countdownDisplay.gameObject.SetActive(true);
                StartCoroutine(CountdownTimer());
            }

        }

        if (started)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                isLooping = true;

                if (isLooping && pressAgain)
                {

                    StartCoroutine(ContinueButtonPress());
                }
            }

            else
            {
                countdownDisplay.gameObject.SetActive(false);
                CalculateCatchChance();
            }
        }
    }

    IEnumerator ContinueButtonPress()
    {
        if (baseCatchPercentage != 0)
        {
            pressAgain = false;

            slider.value += 0.01f * baseCatchPercentage;
            buttonMashTotal += baseCatchPercentage;

            yield return new WaitForSeconds(timeBetweenPresses);
            pressAgain = true;
        }

        else
        {
            pressAgain = false;

            slider.value -= 0.02f;
            buttonMashTotal -= 2;

            yield return new WaitForSeconds(timeBetweenPresses);
            pressAgain = true;
        }
    }


    void CalculateCatchChance()
    {
        if (!calculatedCatch)
        {

            randomCatchNumber = Random.Range(1, 101);

            if (buttonMashTotal >= randomCatchNumber)
            {
                caughtMonsterText.gameObject.SetActive(true);
                //successful catch
                Debug.Log("You caught it! " + "button mash " + buttonMashTotal + " randon catch number " + randomCatchNumber);
                willSystem.playerCurrentWillPoints += willSystem.catchWillPoints;

                willSystem.GetPlayerRank();
            }

            else
            {
                failedCatchText.gameObject.SetActive(true);
                //Failed catch
                Debug.Log("Failed to catch! " + " button mash " + buttonMashTotal + " randon catch number " + randomCatchNumber);
                willSystem.playerCurrentWillPoints -= willSystem.playerFailCatchWillPoints;

                willSystem.GetPlayerRank();
            }

        }

        calculatedCatch = true;
    }

    IEnumerator CountdownTimer()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1);
            // Debug.Log(countdownDisplay.text);
            countdownTime--;
        }

    }
    */

}
