﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketingSystem.Model;

public class Ticket : BaseModel
{
    private readonly string _ticketId;
    private DateTime _date; //Date - 2021-10-10
    private DateTime _time; //Time - 10:00 AM

    public Ticket()
    {
        _ticketId = Guid.NewGuid().ToString();
    }
}

public class Mall : BaseModel //Mall - SM North Edsa, MallAddress - Quezon City
{
    private string _mallName;
    private string _mallAddress;

    public string MallName
    {
        get => _mallName;
        set
        {
            _mallName = value;
            OnPropertyChanged();
        }
    }
    public string MallAddress
    {
        get => _mallAddress;
        set
        {
            _mallAddress = value;
            OnPropertyChanged();
        }
    }
}

//class is depedent to Seat and Mall class
public class Cinema : BaseModel
{
    public Mall Mall { get; set; } = new(); //Mall - SM
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

public class Seat : BaseModel
{
    //one cinema has many seats
    //one mall has many cinemas
    public Cinema Cinema { get; set; } = new(); //Cinema - SM, SeatCapacity - 100
    private int _seatRows; //SeatRows - 10
    private int _seatColumns; //SeatColumns - 10
    private bool _isAvailableSeat; //IsAvailableSeat - true or false

    public int SeatRows
    {
        get => _seatRows;
        set
        {
            _seatRows = value;
            OnPropertyChanged();
        }
    }
    public int SeatColumns
    {
        get => _seatColumns;
        set
        {
            _seatColumns = value;
            OnPropertyChanged();
        }
    }
    public bool IsAvailableSeat
    {
        get => _isAvailableSeat;
        set
        {
            _isAvailableSeat = value;
            OnPropertyChanged();
        }
    }
}

public class Booking : BaseModel
{
    public User User { get; set; } = new(); //User - John Doe
    private int _ticketQuantity;
    
    public int TicketQuantity
    {
        get => _ticketQuantity;
        set
        {
            _ticketQuantity = value;
            OnPropertyChanged();
        }
    }
}

public class Transaction : BaseModel
{
    public Ticket Ticket { get; set; }
}

