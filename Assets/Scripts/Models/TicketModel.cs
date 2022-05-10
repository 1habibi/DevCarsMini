using System;

[Serializable]
public class TicketModel
{
    // описание вопроса
    public string Description;
    // ответы
    public string[] Answers;
    // верный ответ
    public string CorrectAnswer;
    // награда
    public int Reward;
}

[Serializable]
public class GameMetaDataModels
{
    public TicketModel[] tickets;
}
