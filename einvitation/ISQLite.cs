using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace einvitation
{
    public interface ISQLite
    {
        SQLiteConnection GetConnectionWithCreateDatabase();
        bool ButtonClicked3(Event evt);

        List<Event> GetEvents();
         void DeleteEvent(int Id);
    }
}
