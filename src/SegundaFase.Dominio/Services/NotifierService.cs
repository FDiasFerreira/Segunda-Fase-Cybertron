using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SegundaFase.Business.Interfaces;
using SegundaFase.Business.Notifier;

namespace SegundaFase.Business.Services
{
    class NotifierService : INotifierService 
    {
        private List<Notification> list = new List<Notification>();

        public NotifierService() { }

        public void AddError(string erro)
        {
            list.Add(new Notification(erro));
        }

        public IEnumerable<Notification> GetAll()
        {
            return list;
        }

        public bool HasError()
        {
            return list.Any();
        }
    }
}
