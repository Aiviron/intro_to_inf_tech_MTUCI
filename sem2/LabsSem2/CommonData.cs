using Microsoft.Office.Interop.Excel;
using System;
namespace DataNamespace;

enum AnswersTypes
{
	FreeText,
	Predefined
}

public static class DataForLab4
{

    public static string[] result = new string[5];
    public static int correct_answers_cnt = 0;
}
public class TQuetion
{
	public TQuetion(string _text)
	{
        Text = _text;
        Type = (int)AnswersTypes.Predefined;
		UserAnswerText = "";
        UserAnswerNumber = 0;
		CorrectAnswerNumber = 0;
    }

    public int Type;
    public string Text;
    public string[] SuggestAnswers {  get; set; }
    public int CorrectAnswerNumber { get; set; }
    public string CorrectAnswerText { get; set; }
    public string UserAnswerText;
    public int UserAnswerNumber;
}

public class TQuestionList
{
    
    public  TQuestionList() 
    {
        CurrentQuenstionNum = 0;
    }
    public static int CurrentQuenstionNum;

    public static TQuetion[] Questions;
    public static void GoNextQuenstion()
    {
        CurrentQuenstionNum++;
    }

    public static void GoFirstQuenstion()
    {
        CurrentQuenstionNum = 0;
    }
    public static int CulculateResult() 
    {
        return 0;
    }

  

    public static void InitDefaultQuetion()
	{
        TQuetion NewQuetion;
        Questions = new TQuetion[4];
        NewQuetion = new TQuetion("Вопрос 1?");
		NewQuetion.Type = (int)AnswersTypes.Predefined;
        NewQuetion.SuggestAnswers = new string[] { "Ответ1", "Ответ2", "Ответ3", "Ответ4" };
		NewQuetion.CorrectAnswerNumber = 3;
		Questions[0] = NewQuetion;

        NewQuetion = new TQuetion("Вопрос 2?");
        NewQuetion.Type = (int)AnswersTypes.Predefined;
        NewQuetion.SuggestAnswers = new string[] { "Ответ1", "Ответ2", "Ответ3", "Ответ4" };
        NewQuetion.CorrectAnswerNumber = 1;
        Questions[1] = NewQuetion;

        NewQuetion = new TQuetion("Вопрос 3? ");
        NewQuetion.Type = (int)AnswersTypes.Predefined;
        NewQuetion.SuggestAnswers = new string[] { "Ответ1", "Ответ2", "Ответ3" }; ;
        NewQuetion.CorrectAnswerNumber = 4;
        Questions[2] = NewQuetion;

        NewQuetion = new TQuetion("Река около Чегета");
        NewQuetion.Type = (int)AnswersTypes.FreeText;
        NewQuetion.CorrectAnswerText = "Боксан";
        Questions[3] = NewQuetion;



    }
}
