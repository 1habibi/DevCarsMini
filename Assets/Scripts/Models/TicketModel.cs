using System;

[Serializable]
public class TicketModel
{
    // �������� �������
    public string Description;
    // ������
    public string[] Answers;
    // ������ �����
    public int CorrectAnswer;
    // �������
    public int Reward;
}

[Serializable]
public class GameMetaDataModels
{
    public TicketModel[] tickets;
}

