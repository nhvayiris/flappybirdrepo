using UnityEngine;

public class Score : MonoBehaviour
{

    public GameObject[] Number;
    public Transform[] field;
    GameObject[] activeNo;

    public int playerScore;

    public void Awake()
    {
        playerScore = 0;
        activeNo = new GameObject[field.Length]; //initialization of the array
    }


    public void IncreaseScore()
    {
        playerScore++;
        setValue(playerScore);
    }

     void setValue(int score)
    {
        int Convert = 1;
        for (int i=0; i<field.Length; i++)
        {
            int scoreConvert = (score / Convert) % 10;
            print(scoreConvert, i);
            Convert *= 10;
        }
    }



    void print(int score, int position)
    {
        if (this.activeNo[position] != null)
        {
            Destroy(this.activeNo[position]);
        } 
            this.activeNo[position] = Instantiate(this.Number[score], this.field[position].position, this.field[position].rotation);
            this.activeNo[position].name = this.field[position].name;
            this.activeNo[position].transform.parent = this.field[position];

    } 
}
