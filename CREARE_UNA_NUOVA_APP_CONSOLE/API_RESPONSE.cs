using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CREARE_UNA_NUOVA_APP_CONSOLE
{
    internal class API_RESPONSE
    {
        private int _userId;
        private int _id;
        private string _title;
        private string _body;

        public API_RESPONSE(int userId, int id, string title, string body)
        {
            UserId = userId;
            Id = id;
            Title = title;
            Body = body;
        }

        public int UserId { get => _userId; set => _userId = value; }
        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Body { get => _body; set => _body = value; }
    }
}
