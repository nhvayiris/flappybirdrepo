using UnityEngine;

public class Score : MonoBehaviour
{

    public GameObject[] Number;
    public Transform[] Field;
    GameObject[] ActiveNo;

    public int playerScore;

    public void Awake()
    {
        playerScore = 0;
        ActiveNo = new GameObject[Field.Length]; //initialization of the array
    }


    public void IncreaseScore()
    {
        playerScore++;
        setValue(playerScore);
    }

     void setValue(int score)
    {
        int Convert = 1;
        for (int i=0; i<Field.Length; i++)
        {
            int scoreConvert = (score / Convert) % 10;
            print(scoreConvert, i);
            Convert *= 10;
        }
    }



    void print(int score, int position)
    {
        if (this.ActiveNo[position] != null)
        {
            Destroy(this.ActiveNo[position]);
        } 
            this.ActiveNo[position] = Instantiate(this.Number[score], this.Field[position].position, this.Field[position].rotation);
            this.ActiveNo[position].name = this.Field[position].name;
            this.ActiveNo[position].transform.parent = this.Field[position];

    } 
}
