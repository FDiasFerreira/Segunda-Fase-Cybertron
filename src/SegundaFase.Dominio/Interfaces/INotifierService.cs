using System;
using System.Collections.Generic;
using System.Text;
using SegundaFase.Business.Notifier;

namespace SegundaFase.Business.Interfaces
{
    public interface INotifierService
    {
        void AddError(string erro);
        IEnumerable<Notification> GetAll();
        bool HasError();
    }
}
