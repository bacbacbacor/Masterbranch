﻿using System.Collections.ObjectModel;

namespace MovieTicketingSystem.Model;

//class is dependent to Seat and Mall class
public class Cinema : BaseModel
{
    public Mall Mall { get; set; } = new(); //Mall - SM
    public ObservableCollection<Seat> Seats { get; set; } = new();
    private int seatCapacity; //Seat - 100

    public int SeatCapacity
    {
        get => seatCapacity;
        set
        {
            seatCapacity = value;
            OnPropertyChanged();
        }
    }
}

