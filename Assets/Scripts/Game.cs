using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : Singleton<Game>
{
    [SerializeField] private TicketManager _ticketManager;
    [SerializeField] private TicketView ticketView;
    [SerializeField] private int active_ticket;
    void Start()
    {
        active_ticket = 0;
        _ticketManager = GetComponent<TicketManager>();
        _ticketManager.Parse();
        Begin();
    }
    public void Begin()
    {
        TicketModel model = _ticketManager.GetModel(active_ticket);
        if (model != null)
            ticketView.SetTicketModel(model);
    }
    public void Next()
    {
        TicketModel model = _ticketManager.GetModel(++active_ticket);
        if (model != null)
            ticketView.SetTicketModel(model);
        else
            // restore value of index
            active_ticket--;
    }
    public void Previous()
    {
        if (active_ticket == 0) return;
        TicketModel model = _ticketManager.GetModel(--active_ticket);
        if (model != null)
            ticketView.SetTicketModel(model);
    }
}
