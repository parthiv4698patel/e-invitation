﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace einvitation
{
    public class Event
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
